/*
 * FINBOURNE Identity Service API
 *
 * Identity manages user authentication for LUSID, ensuring secure sign-ins and integrations with single sign-on (SSO) providers, and facilitating the setup of both personal and service user accounts. It works in conjunction with the Access SDK.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"238\">238</a>|Max User Api Key Limit Reached|  | | <a name=\"239\">239</a>|API Key not found|  | | <a name=\"657\">657</a>|User does not exist|The specified user does not exist | | <a name=\"658\">658</a>|User already exists|A user with the specified identifier already exists | | <a name=\"659\">659</a>|API Key display name already in use|There is already an active API Key with the specified display name | | <a name=\"660\">660</a>|Role does not exist|The specified role does not exist | | <a name=\"661\">661</a>|Role does not exist in identity provider|One or more of the roles specified do not exist in your identity provider (Okta) | | <a name=\"662\">662</a>|Application does not exist|The specified application does not exist | | <a name=\"663\">663</a>|Token does not exist|The specified domain token does not exist | | <a name=\"679\">679</a>|Single Sign-on (SSO) Incorrectly Configured|This condition is encountered when the necessary configuration required to enable Single Sign-on (SSO) for your LUSID account is missing or not complete. To resolve this you will need to contact your LUSID administrator or LUSID Support to request that the correct configuration is applied. | | <a name=\"680\">680</a>|Identity Provider Not Found|The specified identity provider does not exist | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"705\">705</a>|User In A Deleted State|  | | <a name=\"706\">706</a>|User is not locked out|  | | <a name=\"707\">707</a>|User is already activated|  | | <a name=\"717\">717</a>|User's status is invalid for the given operation|  | | <a name=\"718\">718</a>|User's status is invalid for resetting the user's password|  | | <a name=\"719\">719</a>|User's status is invalid for expiring the user's password|  | | <a name=\"784\">784</a>|Cannot update password|  | | <a name=\"785\">785</a>|Incorrect authentication type for action|  | | <a name=\"786\">786</a>|Action not valid for user of this type|  | | <a name=\"787\">787</a>|Password validation failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"2153\">2153</a>|Invalid Authentication Token|  | | <a name=\"2154\">2154</a>|Invalid Identity Provider Access Token|  | | <a name=\"2200\">2200</a>|Tenant Scheduler Domain Job Error|  | 
 *
 * The version of the OpenAPI document: 0.0.3076
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Net;

namespace Finbourne.Identity.Sdk.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// The data type of <see cref="Content"/>
        /// </summary>
        Type ResponseType { get; }

        /// <summary>
        /// The content of this response
        /// </summary>
        Object Content { get; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        Multimap<string, string> Headers { get; }

        /// <summary>
        /// Gets or sets any error text defined by the calling client.
        /// </summary>
        String ErrorText { get; set; }

        /// <summary>
        /// Gets or sets any cookies passed along on the response.
        /// </summary>
        List<Cookie> Cookies { get; set; }

        /// <summary>
        /// The raw content of this response
        /// </summary>
        string RawContent { get; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public class ApiResponse<T> : IApiResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public Multimap<string, string> Headers { get; }

        /// <summary>
        /// Gets or sets the data (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get; }

        /// <summary>
        /// Gets or sets any error text defined by the calling client.
        /// </summary>
        public String ErrorText { get; set; }

        /// <summary>
        /// Gets or sets any cookies passed along on the response.
        /// </summary>
        public List<Cookie> Cookies { get; set; }

        /// <summary>
        /// The content of this response
        /// </summary>
        public Type ResponseType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// The data type of <see cref="Content"/>
        /// </summary>
        public object Content
        {
            get { return Data; }
        }

        /// <summary>
        /// The raw content
        /// </summary>
        public string RawContent { get; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        /// <param name="rawContent">Raw content.</param>
        public ApiResponse(HttpStatusCode statusCode, Multimap<string, string> headers, T data, string rawContent)
        {
            StatusCode = statusCode;
            Headers = headers;
            Data = data;
            RawContent = rawContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(HttpStatusCode statusCode, Multimap<string, string> headers, T data) : this(statusCode, headers, data, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        /// <param name="rawContent">Raw content.</param>
        public ApiResponse(HttpStatusCode statusCode, T data, string rawContent) : this(statusCode, null, data, rawContent)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(HttpStatusCode statusCode, T data) : this(statusCode, data, null)
        {
        }

        #endregion Constructors
    }
}
