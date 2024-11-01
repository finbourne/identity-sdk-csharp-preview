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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Finbourne.Identity.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <returns>AddScimResponse</returns>
        AddScimResponse AddScim(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?));

        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <returns>ApiResponse of AddScimResponse</returns>
        ApiResponse<AddScimResponse> AddScimWithHttpInfo(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?));
        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void RemoveScim();

        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveScimWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddScimResponse</returns>
        System.Threading.Tasks.Task<AddScimResponse> AddScimAsync(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddScimResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddScimResponse>> AddScimWithHttpInfoAsync(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveScimAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveScimWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApi : IIdentityProviderApiSync, IIdentityProviderApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IdentityProviderApi : IIdentityProviderApi
    {
        private Finbourne.Identity.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProviderApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProviderApi(String basePath)
        {
            this.Configuration = Finbourne.Identity.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Identity.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Identity.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IdentityProviderApi(Finbourne.Identity.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IdentityProviderApi(Finbourne.Identity.Sdk.Client.ISynchronousClient client, Finbourne.Identity.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Identity.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Identity.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <returns>AddScimResponse</returns>
        public AddScimResponse AddScim(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> localVarResponse = AddScimWithHttpInfo(apiTokenAction, oldApiTokenDeactivation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <returns>ApiResponse of AddScimResponse</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> AddScimWithHttpInfo(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?))
        {
            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (apiTokenAction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "apiTokenAction", apiTokenAction));
            }
            if (oldApiTokenDeactivation != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "oldApiTokenDeactivation", oldApiTokenDeactivation));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.3076");

            // make the HTTP request
            var localVarResponse = this.Client.Put<AddScimResponse>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddScim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddScimResponse</returns>
        public async System.Threading.Tasks.Task<AddScimResponse> AddScimAsync(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> localVarResponse = await AddScimWithHttpInfoAsync(apiTokenAction, oldApiTokenDeactivation, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddScimResponse)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse>> AddScimWithHttpInfoAsync(string apiTokenAction = default(string), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (apiTokenAction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "apiTokenAction", apiTokenAction));
            }
            if (oldApiTokenDeactivation != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "oldApiTokenDeactivation", oldApiTokenDeactivation));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.3076");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AddScimResponse>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddScim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void RemoveScim()
        {
            RemoveScimWithHttpInfo();
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<Object> RemoveScimWithHttpInfo()
        {
            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.3076");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveScim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveScimAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveScimWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<Object>> RemoveScimWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.3076");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveScim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}