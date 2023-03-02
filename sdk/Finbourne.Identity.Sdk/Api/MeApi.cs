/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2303
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
    public interface IMeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info
        /// </summary>
        /// <remarks>
        /// Get the requesting user&#39;s basic info
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrentUserResponse</returns>
        CurrentUserResponse GetUserInfo();

        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info
        /// </summary>
        /// <remarks>
        /// Get the requesting user&#39;s basic info
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrentUserResponse</returns>
        ApiResponse<CurrentUserResponse> GetUserInfoWithHttpInfo();
        /// <summary>
        /// SetPassword: Set password of current user
        /// </summary>
        /// <remarks>
        /// Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <returns>SetPasswordResponse</returns>
        SetPasswordResponse SetPassword(SetPassword setPassword);

        /// <summary>
        /// SetPassword: Set password of current user
        /// </summary>
        /// <remarks>
        /// Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <returns>ApiResponse of SetPasswordResponse</returns>
        ApiResponse<SetPasswordResponse> SetPasswordWithHttpInfo(SetPassword setPassword);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info
        /// </summary>
        /// <remarks>
        /// Get the requesting user&#39;s basic info
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CurrentUserResponse</returns>
        System.Threading.Tasks.Task<CurrentUserResponse> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info
        /// </summary>
        /// <remarks>
        /// Get the requesting user&#39;s basic info
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CurrentUserResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrentUserResponse>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// SetPassword: Set password of current user
        /// </summary>
        /// <remarks>
        /// Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SetPasswordResponse</returns>
        System.Threading.Tasks.Task<SetPasswordResponse> SetPasswordAsync(SetPassword setPassword, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// SetPassword: Set password of current user
        /// </summary>
        /// <remarks>
        /// Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SetPasswordResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SetPasswordResponse>> SetPasswordWithHttpInfoAsync(SetPassword setPassword, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMeApi : IMeApiSync, IMeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MeApi : IMeApi
    {
        private Finbourne.Identity.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MeApi(Finbourne.Identity.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MeApi(Finbourne.Identity.Sdk.Client.ISynchronousClient client, Finbourne.Identity.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Identity.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] GetUserInfo: Get User Info Get the requesting user&#39;s basic info
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrentUserResponse</returns>
        public CurrentUserResponse GetUserInfo()
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<CurrentUserResponse> localVarResponse = GetUserInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info Get the requesting user&#39;s basic info
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrentUserResponse</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<CurrentUserResponse> GetUserInfoWithHttpInfo()
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2303");

            // make the HTTP request
            var localVarResponse = this.Client.Get<CurrentUserResponse>("/api/me", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info Get the requesting user&#39;s basic info
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CurrentUserResponse</returns>
        public async System.Threading.Tasks.Task<CurrentUserResponse> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<CurrentUserResponse> localVarResponse = await GetUserInfoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetUserInfo: Get User Info Get the requesting user&#39;s basic info
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CurrentUserResponse)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<CurrentUserResponse>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2303");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CurrentUserResponse>("/api/me", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// SetPassword: Set password of current user Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <returns>SetPasswordResponse</returns>
        public SetPasswordResponse SetPassword(SetPassword setPassword)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<SetPasswordResponse> localVarResponse = SetPasswordWithHttpInfo(setPassword);
            return localVarResponse.Data;
        }

        /// <summary>
        /// SetPassword: Set password of current user Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <returns>ApiResponse of SetPasswordResponse</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<SetPasswordResponse> SetPasswordWithHttpInfo(SetPassword setPassword)
        {
            // verify the required parameter 'setPassword' is set
            if (setPassword == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'setPassword' when calling MeApi->SetPassword");

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = setPassword;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2303");

            // make the HTTP request
            var localVarResponse = this.Client.Put<SetPasswordResponse>("/api/me/password", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPassword", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// SetPassword: Set password of current user Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SetPasswordResponse</returns>
        public async System.Threading.Tasks.Task<SetPasswordResponse> SetPasswordAsync(SetPassword setPassword, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<SetPasswordResponse> localVarResponse = await SetPasswordWithHttpInfoAsync(setPassword, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// SetPassword: Set password of current user Set the password of the current user to the specified value.                Note this is feature is only available to Service users authenticated using OpenID. For further information  relating to usage of this feature please consult the documentation.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPassword">The request containing the new password value</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SetPasswordResponse)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<SetPasswordResponse>> SetPasswordWithHttpInfoAsync(SetPassword setPassword, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'setPassword' is set
            if (setPassword == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'setPassword' when calling MeApi->SetPassword");


            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = setPassword;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2303");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<SetPasswordResponse>("/api/me/password", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPassword", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}