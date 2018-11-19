using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Widgets.Model;

namespace AdobeSign.Widgets.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWidgetsApi
    {
        /// <summary>
        /// Creates a widget and and returns the widgetId in the response to the client. This is a primary endpoint which is used to create a new widget. You can create a widget in one of the 3 mentioned states: a) &lt;b&gt;DRAFT&lt;/b&gt; - to incrementally build the widget, b) &lt;b&gt;AUTHORING&lt;/b&gt; - to add/edit form fields in the widget, c) &lt;b&gt;ACTIVE&lt;/b&gt; - to immediately host the widget. You can use the PUT /widgets/{widgetId}/state endpoint to transition a widget between the above mentioned states. An allowed transition would follow the any of the following sequences: DRAFT-&gt;AUTHORING-&gt;ACTIVE, ACTIVE&lt;-&gt;INACTIVE, DRAFT-&gt;CANCELLED.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetInfo">Information about the widget that you want to create.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns>WidgetCreationResponse</returns>
        WidgetCreationResponse CreateWidget (string authorization, WidgetCreationInfoV6 widgetInfo, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Retrieves detailed member info along with IDs for different types of participants. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>WidgetMembersInfo</returns>
        WidgetMembersInfo GetAllWidgetMembers (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves the events information for a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>WidgetEventList</returns>
        WidgetEventList GetEvents (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves the participant set of a widget identified by widgetId in the path. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="participantSetId">The participant set identifier</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>DetailedWidgetParticipantSetInfo</returns>
        DetailedWidgetParticipantSetInfo GetParticipantSet (string authorization, string widgetId, string participantSetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves agreements for the widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="showHiddenAgreements">A query parameter to fetch all the hidden agreements along with the visible agreements. Default value is false.</param>
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param>
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param>
        /// <returns>WidgetAgreements</returns>
        WidgetAgreements GetWidgetAgreements (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, bool? showHiddenAgreements, string cursor, int? pageSize);
        /// <summary>
        /// Retrieves the audit trail of a widget identified by widgetId. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetAuditTrail (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves a single combined PDF document for the documents associated with a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param>
        /// <param name="participantId">The ID of the participant to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param>
        /// <param name="attachAuditReport">When set to YES, attach an audit report to the signed Widget PDF. Default value is false</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetCombinedDocument (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch, string versionId, string participantId, bool? attachAuditReport);
        /// <summary>
        /// Retrieves the file stream of a document of a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified widget</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetDocumentInfo (string authorization, string widgetId, string documentId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves the IDs of the documents associated with widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param>
        /// <param name="participantId">The ID of the participant to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param>
        /// <returns>WidgetDocuments</returns>
        WidgetDocuments GetWidgetDocuments (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch, string versionId, string participantId);
        /// <summary>
        /// Retrieves data entered by the user into interactive form fields at the time they signed the widget CSV file stream containing form data information
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetFormData (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Retrieves the details of a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param>
        /// <returns>WidgetCreationInfoV6</returns>
        WidgetCreationInfoV6 GetWidgetInfo (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch);
        /// <summary>
        /// Retrieves the latest note of a widget for the API user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns>Note</returns>
        Note GetWidgetNoteForApiUser (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Retrieves the requested views for a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt; - widget read is always required&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="widgetViewInfo">Name of the required view and its desired configuration.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns>WidgetViews</returns>
        WidgetViews GetWidgetView (string authorization, string widgetId, WidgetViewInfo widgetViewInfo, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Retrieves widgets for a user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="showHiddenWidgets">A query parameter to fetch all the hidden widgets along with the visible widgets. Default value is false.</param>
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param>
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param>
        /// <returns>UserWidgets</returns>
        UserWidgets GetWidgets (string authorization, string xApiUser, string xOnBehalfOfUser, bool? showHiddenWidgets, string cursor, int? pageSize);
        /// <summary>
        /// Updates a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="widgetInfo">Widget update information object.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns></returns>
        void UpdateWidget (string authorization, string ifMatch, string widgetId, WidgetInfo widgetInfo, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Updates the latest note of a widget for the API user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="note">The note to be associated with the widget.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns></returns>
        void UpdateWidgetNoteForApiUser (string authorization, string widgetId, Note note, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Updates the state of a widget identified by widgetId in the path. This endpoint can be used by creator of the widget to transition between the states of widget. An allowed transition would follow any of the following sequence :  DRAFT-&gt;AUTHORING-&gt;ACTIVE, ACTIVE&lt;-&gt;INACTIVE, DRAFT-&gt;CANCELLED.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="widgetStateInfo"></param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns></returns>
        void UpdateWidgetState (string authorization, string ifMatch, string widgetId, WidgetStateInfo widgetStateInfo, string xApiUser, string xOnBehalfOfUser);
        /// <summary>
        /// Updates the visibility of widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="visibilityInfo">Information to update visibility of widget</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <returns></returns>
        void UpdateWidgetVisibility (string authorization, string widgetId, VisibilityInfo visibilityInfo, string xApiUser, string xOnBehalfOfUser);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WidgetsApi : IWidgetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WidgetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WidgetsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Creates a widget and and returns the widgetId in the response to the client. This is a primary endpoint which is used to create a new widget. You can create a widget in one of the 3 mentioned states: a) &lt;b&gt;DRAFT&lt;/b&gt; - to incrementally build the widget, b) &lt;b&gt;AUTHORING&lt;/b&gt; - to add/edit form fields in the widget, c) &lt;b&gt;ACTIVE&lt;/b&gt; - to immediately host the widget. You can use the PUT /widgets/{widgetId}/state endpoint to transition a widget between the above mentioned states. An allowed transition would follow the any of the following sequences: DRAFT-&gt;AUTHORING-&gt;ACTIVE, ACTIVE&lt;-&gt;INACTIVE, DRAFT-&gt;CANCELLED.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetInfo">Information about the widget that you want to create.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>WidgetCreationResponse</returns>            
        public WidgetCreationResponse CreateWidget (string authorization, WidgetCreationInfoV6 widgetInfo, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateWidget");
            
            // verify the required parameter 'widgetInfo' is set
            if (widgetInfo == null) throw new ApiException(400, "Missing required parameter 'widgetInfo' when calling CreateWidget");
            
    
            var path = "/widgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                        postBody = ApiClient.Serialize(widgetInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetCreationResponse) ApiClient.Deserialize(response.Content, typeof(WidgetCreationResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves detailed member info along with IDs for different types of participants. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>WidgetMembersInfo</returns>            
        public WidgetMembersInfo GetAllWidgetMembers (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetAllWidgetMembers");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetAllWidgetMembers");
            
    
            var path = "/widgets/{widgetId}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllWidgetMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllWidgetMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetMembersInfo) ApiClient.Deserialize(response.Content, typeof(WidgetMembersInfo), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the events information for a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>WidgetEventList</returns>            
        public WidgetEventList GetEvents (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetEvents");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetEvents");
            
    
            var path = "/widgets/{widgetId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetEventList) ApiClient.Deserialize(response.Content, typeof(WidgetEventList), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the participant set of a widget identified by widgetId in the path. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="participantSetId">The participant set identifier</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>DetailedWidgetParticipantSetInfo</returns>            
        public DetailedWidgetParticipantSetInfo GetParticipantSet (string authorization, string widgetId, string participantSetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetParticipantSet");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetParticipantSet");
            
            // verify the required parameter 'participantSetId' is set
            if (participantSetId == null) throw new ApiException(400, "Missing required parameter 'participantSetId' when calling GetParticipantSet");
            
    
            var path = "/widgets/{widgetId}/members/participantSets/{participantSetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
path = path.Replace("{" + "participantSetId" + "}", ApiClient.ParameterToString(participantSetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParticipantSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParticipantSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedWidgetParticipantSetInfo) ApiClient.Deserialize(response.Content, typeof(DetailedWidgetParticipantSetInfo), response.Headers);
        }
    
        /// <summary>
        /// Retrieves agreements for the widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="showHiddenAgreements">A query parameter to fetch all the hidden agreements along with the visible agreements. Default value is false.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>WidgetAgreements</returns>            
        public WidgetAgreements GetWidgetAgreements (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, bool? showHiddenAgreements, string cursor, int? pageSize)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetAgreements");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetAgreements");
            
    
            var path = "/widgets/{widgetId}/agreements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showHiddenAgreements != null) queryParams.Add("showHiddenAgreements", ApiClient.ParameterToString(showHiddenAgreements)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAgreements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAgreements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetAgreements) ApiClient.Deserialize(response.Content, typeof(WidgetAgreements), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the audit trail of a widget identified by widgetId. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetAuditTrail (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetAuditTrail");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetAuditTrail");
            
    
            var path = "/widgets/{widgetId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAuditTrail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAuditTrail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a single combined PDF document for the documents associated with a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The ID of the participant to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <param name="attachAuditReport">When set to YES, attach an audit report to the signed Widget PDF. Default value is false</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetCombinedDocument (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch, string versionId, string participantId, bool? attachAuditReport)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetCombinedDocument");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetCombinedDocument");
            
    
            var path = "/widgets/{widgetId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
 if (attachAuditReport != null) queryParams.Add("attachAuditReport", ApiClient.ParameterToString(attachAuditReport)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the file stream of a document of a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified widget</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetDocumentInfo (string authorization, string widgetId, string documentId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetDocumentInfo");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetDocumentInfo");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetWidgetDocumentInfo");
            
    
            var path = "/widgets/{widgetId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocumentInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocumentInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the IDs of the documents associated with widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The ID of the participant to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <returns>WidgetDocuments</returns>            
        public WidgetDocuments GetWidgetDocuments (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch, string versionId, string participantId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetDocuments");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetDocuments");
            
    
            var path = "/widgets/{widgetId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetDocuments) ApiClient.Deserialize(response.Content, typeof(WidgetDocuments), response.Headers);
        }
    
        /// <summary>
        /// Retrieves data entered by the user into interactive form fields at the time they signed the widget CSV file stream containing form data information
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetFormData (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetFormData");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetFormData");
            
    
            var path = "/widgets/{widgetId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetFormData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetFormData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the details of a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>WidgetCreationInfoV6</returns>            
        public WidgetCreationInfoV6 GetWidgetInfo (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser, string ifNoneMatch)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetInfo");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetInfo");
            
    
            var path = "/widgets/{widgetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetCreationInfoV6) ApiClient.Deserialize(response.Content, typeof(WidgetCreationInfoV6), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the latest note of a widget for the API user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>Note</returns>            
        public Note GetWidgetNoteForApiUser (string authorization, string widgetId, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetNoteForApiUser");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetNoteForApiUser");
            
    
            var path = "/widgets/{widgetId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Note) ApiClient.Deserialize(response.Content, typeof(Note), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the requested views for a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt; - widget read is always required&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="widgetViewInfo">Name of the required view and its desired configuration.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>WidgetViews</returns>            
        public WidgetViews GetWidgetView (string authorization, string widgetId, WidgetViewInfo widgetViewInfo, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgetView");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetView");
            
            // verify the required parameter 'widgetViewInfo' is set
            if (widgetViewInfo == null) throw new ApiException(400, "Missing required parameter 'widgetViewInfo' when calling GetWidgetView");
            
    
            var path = "/widgets/{widgetId}/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                        postBody = ApiClient.Serialize(widgetViewInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetView: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetView: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetViews) ApiClient.Deserialize(response.Content, typeof(WidgetViews), response.Headers);
        }
    
        /// <summary>
        /// Retrieves widgets for a user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="showHiddenWidgets">A query parameter to fetch all the hidden widgets along with the visible widgets. Default value is false.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>UserWidgets</returns>            
        public UserWidgets GetWidgets (string authorization, string xApiUser, string xOnBehalfOfUser, bool? showHiddenWidgets, string cursor, int? pageSize)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetWidgets");
            
    
            var path = "/widgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showHiddenWidgets != null) queryParams.Add("showHiddenWidgets", ApiClient.ParameterToString(showHiddenWidgets)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserWidgets) ApiClient.Deserialize(response.Content, typeof(UserWidgets), response.Headers);
        }
    
        /// <summary>
        /// Updates a widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="widgetInfo">Widget update information object.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWidget (string authorization, string ifMatch, string widgetId, WidgetInfo widgetInfo, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling UpdateWidget");
            
            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateWidget");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidget");
            
            // verify the required parameter 'widgetInfo' is set
            if (widgetInfo == null) throw new ApiException(400, "Missing required parameter 'widgetInfo' when calling UpdateWidget");
            
    
            var path = "/widgets/{widgetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
                        postBody = ApiClient.Serialize(widgetInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the latest note of a widget for the API user. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="note">The note to be associated with the widget.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWidgetNoteForApiUser (string authorization, string widgetId, Note note, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling UpdateWidgetNoteForApiUser");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidgetNoteForApiUser");
            
            // verify the required parameter 'note' is set
            if (note == null) throw new ApiException(400, "Missing required parameter 'note' when calling UpdateWidgetNoteForApiUser");
            
    
            var path = "/widgets/{widgetId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                        postBody = ApiClient.Serialize(note); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the state of a widget identified by widgetId in the path. This endpoint can be used by creator of the widget to transition between the states of widget. An allowed transition would follow any of the following sequence :  DRAFT-&gt;AUTHORING-&gt;ACTIVE, ACTIVE&lt;-&gt;INACTIVE, DRAFT-&gt;CANCELLED.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="widgetStateInfo"></param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWidgetState (string authorization, string ifMatch, string widgetId, WidgetStateInfo widgetStateInfo, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling UpdateWidgetState");
            
            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateWidgetState");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidgetState");
            
            // verify the required parameter 'widgetStateInfo' is set
            if (widgetStateInfo == null) throw new ApiException(400, "Missing required parameter 'widgetStateInfo' when calling UpdateWidgetState");
            
    
            var path = "/widgets/{widgetId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
                        postBody = ApiClient.Serialize(widgetStateInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetState: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the visibility of widget. 
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="visibilityInfo">Information to update visibility of widget</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWidgetVisibility (string authorization, string widgetId, VisibilityInfo visibilityInfo, string xApiUser, string xOnBehalfOfUser)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling UpdateWidgetVisibility");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidgetVisibility");
            
            // verify the required parameter 'visibilityInfo' is set
            if (visibilityInfo == null) throw new ApiException(400, "Missing required parameter 'visibilityInfo' when calling UpdateWidgetVisibility");
            
    
            var path = "/widgets/{widgetId}/me/visibility";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                        postBody = ApiClient.Serialize(visibilityInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetVisibility: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetVisibility: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
