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
        public DefaultController()
        {
          
        }
        /*
         *         https://secure.na1.echosign.com/public/static/oauthDoc.jsp#scopes
         *         
         *         https://secure.na1.echosign.com/public/docs/restapi/v6
         *         
         *         https://www.adobe.io/apis/documentcloud/sign/docs.html#!adobeio/adobeio-documentation/master/sign/api_usage/send_signing.md
         *         
         *         https://helpx.adobe.com/sign/help/field-types.html
         */

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

                             ViewBag.Stuff = JsonConvert.SerializeObject(nt, Formatting.Indented);
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

                }
                else if (Request["action"] == "CreateTransientDocument")
                {
                    var c = apiClient.GetTransientDocumentsApi();


                    
                    var r = c.CreateTransientDocument(
                            System.IO.File.ReadAllBytes(@"C:\Users\marco\Documents\Source Code Partners\UTBS\UTBS Completed Intake Doc Forms\Intake Docs - 011609 - 154932.pdf"),
                            "test file.pdf",
                            "application/PDF");
                    
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                    Session["TransientDocumentId"] = r.TransientDocumentId;


                }

                else if (Request["action"] == "CreateAgreement")
                {
                    var c = apiClient.GetAgreementsApi();
                    var r = c.CreateAgreement(new Agreements.Model.AgreementCreationInfo()
                    {
                        FileInfos = new List<Agreements.Model.FileInfo>()
                        {
                            new Agreements.Model.FileInfo()
                            {
                                 TransientDocumentId = (string)Session["TransientDocumentId"]
                            }
                        },
                        ExternalId= new Agreements.Model.ExternalId() {
                             Id =  "Intake-" + DateTime.Now.Second.ToString("00")
                        },
                        Name = "Test at " + DateTime.Now.ToString(),
                        ParticipantSetsInfo = new List<Agreements.Model.ParticipantSetInfo>()
                        {
                            new Agreements.Model.ParticipantSetInfo()
                            {
                                MemberInfos=new List<Agreements.Model.ParticipantSetMemberInfo>()
                                {
                                     new Agreements.Model.ParticipantSetMemberInfo()
                                     {
                                         Email = "caco@mpdo.com.br",
                                     }
                                },
                                Name="Siging User Name",
                                Role = "SIGNER", // SENDER / SHARE
                                Order=1
                            }
                        },
                        EmailOption = new Agreements.Model.EmailOption()
                        {
                            SendOptions = new Agreements.Model.SendOptions() {
                                InitEmails = "NONE",
                                InFlightEmails = "NONE",
                                CompletionEmails = "ALL",
                            }
                        },
                        SignatureType = "ESIGN",
                        State = "IN_PROCESS",
                        PostSignOption = new Agreements.Model.PostSignOption()
                        {
                            RedirectUrl = redirectURL
                        }
                    });

                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);


                    Session["AgreementId"] = r.Id;

                }
                else if (Request["action"] == "signingUrls")
                {
                    var c = apiClient.GetAgreementsApi();
                    var r = c.GetSigningUrl((string)Session["AgreementId"]);

                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);



                }
                else if (Request["action"] == "GetAgreements")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var r = c.GetAgreements();

                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                    Session["AgreementId"] = r.UserAgreementList
                        ?.Where(x=>x.Status== "OUT_FOR_SIGNATURE" || x.Status == "WAITING_FOR_MY_SIGNATURE")
                        ?.FirstOrDefault()?.Id;

                }
                else if (Request["action"] == "GetFormFields")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var r = c.GetFormFields((string)Session["AgreementId"]);
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);


                }
                else if (Request["action"] == "GetFormData")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var bytes = c.GetFormData((string)Session["AgreementId"]);

                    return File(bytes, "text/csv");

                }
                else if (Request["action"] == "GetCombinedDocument")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var bytes = c.GetCombinedDocument((string)Session["AgreementId"]);

                    return File(bytes, "application/pdf");

                }
                else if (Request["action"] == "GetCombinedDocumentUrl")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var r = c.GetCombinedDocumentUrl((string)Session["AgreementId"]);
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }
                else if (Request["action"] == "GetAgreementInfo")
                {
                    var c = new AdobeSign.Agreements.Api.AgreementsApi(apiClient);
                    var r = c.GetAgreementInfo((string)Session["AgreementId"]);
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }
                else if (Request["action"] == "GetBaseUris")
                {
                    var c = new AdobeSign.BaseUris.Api.BaseUrisApi(apiClient);
                    var r = c.GetBaseUris();
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }
                else if (Request["action"] == "GetUsers")
                {
                    var c = apiClient.GetUsersApi();
                    var r = c.GetUsers();

                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                    Session["UserId"] = r.UserInfoList?.FirstOrDefault()?.Id;

                }
                else if (Request["action"] == "GetUserDetail")
                {
                    var c = apiClient.GetUsersApi();
                    var r = c.GetUserDetail((string)Session["UserId"] ?? "me");
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }
                else if (Request["action"] == "GetGroupsOfUser")
                {
                    var c = apiClient.GetUsersApi();
                    var r = c.GetGroupsOfUser((string)Session["UserId"] ?? "me");
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }

                else if (Request["action"] == "GetWebhooks")
                {
                    var c = apiClient.GetWebhooksApi();
                    var r = c.GetWebhooks();
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                    Session["WebhookId"] = r.UserWebhookList
                        ?.Where(x => x.Status == "ACTIVE" )
                        ?.FirstOrDefault()?.Id;

                }
                else if (Request["action"] == "GetWebhookInfo")
                {
                    var c = apiClient.GetWebhooksApi();
                    var r = c.GetWebhookInfo((string)Session["WebhookId"]);
                    ViewBag.Stuff = JsonConvert.SerializeObject(r, Formatting.Indented);

                }
                else if (Request["action"] == "DeleteWebhook")
                {
                    var c = apiClient.GetWebhooksApi();

                    var r = c.GetWebhookInfo((string)Session["WebhookId"]);
                    c.DeleteWebhook(r.Id, apiClient.LastETag);
                    ViewBag.Stuff = "Ok";

                }
                else if (Request["action"] == "CreateWebhook")
                {
                    var c = apiClient.GetWebhooksApi();
                    var r = c.CreateWebhook(new Webhooks.Model.WebhookInfo()
                    {
                        Name = "Test " + DateTime.Now.ToString(),
                        Scope = "ACCOUNT",
                        State = "ACTIVE",
                        WebhookSubscriptionEvents = new List<string>()
                         {
                            "AGREEMENT_ALL"

                        },
                        WebhookUrlInfo = new Webhooks.Model.WebhookUrlInfo()
                        {
                            Url = "https://webapi.optomiser-development.com/AdobeSign/Webhook"
                        },
                        ApplicationDisplayName= "UTBS",

                         WebhookConditionalParams = new Webhooks.Model.WebhookConditionalParams()
                         {
                              WebhookAgreementEvents=new Webhooks.Model.WebhookAgreementEvents()
                              {
                                    IncludeDetailedInfo = true,
                                    IncludeDocumentsInfo =true, 
                                    IncludeParticipantsInfo = true,
                                    IncludeSignedDocuments =false
                              }
                         }
                         
                    });

                    Session["WebhookId"] = r.Id;
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