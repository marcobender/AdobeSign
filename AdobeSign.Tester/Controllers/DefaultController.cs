using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdobeSign.Client;
using Newtonsoft.Json;
using RestSharp;

namespace AdobeSign.Tester.Controllers
{
    public class DefaultController : Controller
    {

        string client_id = "CBJCHBCAABAAFccdLHz99aDtW7L4nlXqO9aUi_0GPQr8";
        string client_secret = "CRZi8Zp7NTx3IRLz5xOnBH0v-sYBovF-";
        string redirectURL = "https://localhost:44304/";

        public string loginURL { get; set; }

        public ApiClient apiClient { get; set; }

        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Stuff = null;

            apiClient = new ApiClient(
                this.client_id,
                this.client_secret);

            ViewBag.LoginURL = apiClient.GetAuthorizationRequestURL(redirectURL);
            // https://secure.na1.echosign.com/public/oauth?redirect_uri=https://www.google.co.in&response_type=code&client_id=CBJCHBCAABAAo9FZgq31_5BVG_kcIXEe6gNtn-R-gdNe&scope=user_login:self+agreement_send:account

            try
            {
                if (Session["AccessToken"] != null)
                {
                    apiClient.SetAccessToken(
                        (string)Session["AccessToken"],
                        (string)Session["RefreshToken"],
                        (DateTime)Session["TokenExpireDate"],
                        (string)Session["ApiAccessPoint"]);
                }
                else if (Request.Cookies["ApiToken"] != null
                    && Request.Cookies["ApiToken"].Value != "")
                {

                    try
                    {
                        var t = JsonConvert.DeserializeObject<AdobeSign.Model.ApiToken>(Request.Cookies["ApiToken"].Value);
                        if (t != null)
                        {

                            var nt = apiClient.RefreshAccessToken(t.RefreshToken, Request.Cookies["ApiAccessPoint"]?.Value);

                            Session["AccessToken"] = nt.AccessToken;
                            Session["RefreshToken"] = nt.RefreshToken;
                            Session["TokenExpireDate"] = apiClient.TokenExpireDate;
                            Session["ApiAccessPoint"] = apiClient.ApiAccessPoint;

                            // ViewBag.Stuff = JsonConvert.SerializeObject(nt, Formatting.Indented);
                            //return View();

                        }
                    }
                    catch (Exception ex)
                    {

                        ViewBag.Stuff = $"Error: {ex.Message}";
                        Response.Cookies.Add(new System.Web.HttpCookie("ApiToken", "")
                        {
                            Expires = DateTime.Today
                        });
                    }
                }




                if (Request["code"] != null)
                {
                    // https://secure.na1.echosign.com/public/static/oauthDoc.jsp

                    var t = apiClient.GetAccessToken(redirectURL, Request["code"], Request["api_access_point"]);

                    Session["AccessToken"] = t.AccessToken;
                    Session["RefreshToken"] = t.RefreshToken;
                    Session["TokenExpireDate"] = apiClient.TokenExpireDate;
                    Session["ApiAccessPoint"] = apiClient.ApiAccessPoint;

                    ViewBag.Stuff = JsonConvert.SerializeObject(t, Formatting.Indented);

                    Response.Cookies.Add(new System.Web.HttpCookie("ApiToken")
                    {
                        Value = JsonConvert.SerializeObject(t),
                        Expires = DateTime.Today.AddDays(30)
                    });
                    Response.Cookies.Add(new System.Web.HttpCookie("ApiAccessPoint", apiClient.ApiAccessPoint)
                    {
                        Expires = DateTime.Today.AddDays(30)
                    });
                    return View();

                }

                if (Request["action"] == "refresh")
                {
                    var t = apiClient.RefreshAccessToken();

                    Session["AccessToken"] = t.AccessToken;
                    Session["RefreshToken"] = t.RefreshToken;
                    Session["TokenExpireDate"] = apiClient.TokenExpireDate;

                    ViewBag.Stuff = JsonConvert.SerializeObject(t, Formatting.Indented);
                    return View();

                }/*
            else if (Request["action"] == "CreateTransientDocument")
            {
                var c = new AdobeSign.TransientDocuments.Api.TransientDocumentsApi(apiClient);
                using (var f = System.IO.File.Open(@"C:\Users\marco\Documents\Source Code Partners\UTBS\UTBS Completed Intake Doc Forms\Intake Docs - 011609 - 154932.pdf", System.IO.FileMode.Open))
                {
                    var r = c.CreateTransientDocument(
                         authorization,
                         f,
                         null, null, "test file.pdf",
                         "application/PDF");
                    
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);
                }


            }*/
                else if (Request["action"] == "GetAgreements")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var r = c.GetAgreements();

                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);



                }
                else if (apiClient.AccessToken != null)
                {
                    var c = new AdobeSign.BaseUris.Api.BaseUrisApi(apiClient);
                    var r = c.GetBaseUris();
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }


            }
            catch (ApiException ex)
            {

                ViewBag.Stuff = $"Error: {ex.Message}\r\n{ex.ErrorContent}";
            }

            return View();
        }

    }
}