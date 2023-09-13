/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2621
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
    public interface IPersonalAuthenticationTokensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <returns>CreatedApiKey</returns>
        CreatedApiKey CreateApiKey(CreateApiKey createApiKey);

        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <returns>ApiResponse of CreatedApiKey</returns>
        ApiResponse<CreatedApiKey> CreateApiKeyWithHttpInfo(CreateApiKey createApiKey);
        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Immediately invalidates the specified Personal Access Token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <returns>ApiKey</returns>
        ApiKey DeleteApiKey(string id);

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Immediately invalidates the specified Personal Access Token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <returns>ApiResponse of ApiKey</returns>
        ApiResponse<ApiKey> DeleteApiKeyWithHttpInfo(string id);
        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens.
        /// </summary>
        /// <remarks>
        /// Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;ApiKey&gt;</returns>
        ICollection<ApiKey> ListOwnApiKeys();

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens.
        /// </summary>
        /// <remarks>
        /// Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;ApiKey&gt;</returns>
        ApiResponse<ICollection<ApiKey>> ListOwnApiKeysWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPersonalAuthenticationTokensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatedApiKey</returns>
        System.Threading.Tasks.Task<CreatedApiKey> CreateApiKeyAsync(CreateApiKey createApiKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatedApiKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreatedApiKey>> CreateApiKeyWithHttpInfoAsync(CreateApiKey createApiKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Immediately invalidates the specified Personal Access Token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiKey</returns>
        System.Threading.Tasks.Task<ApiKey> DeleteApiKeyAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
        /// </summary>
        /// <remarks>
        /// Immediately invalidates the specified Personal Access Token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKey>> DeleteApiKeyWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens.
        /// </summary>
        /// <remarks>
        /// Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;ApiKey&gt;</returns>
        System.Threading.Tasks.Task<ICollection<ApiKey>> ListOwnApiKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens.
        /// </summary>
        /// <remarks>
        /// Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;ApiKey&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<ApiKey>>> ListOwnApiKeysWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPersonalAuthenticationTokensApi : IPersonalAuthenticationTokensApiSync, IPersonalAuthenticationTokensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PersonalAuthenticationTokensApi : IPersonalAuthenticationTokensApi
    {
        private Finbourne.Identity.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAuthenticationTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PersonalAuthenticationTokensApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAuthenticationTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PersonalAuthenticationTokensApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PersonalAuthenticationTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PersonalAuthenticationTokensApi(Finbourne.Identity.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAuthenticationTokensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PersonalAuthenticationTokensApi(Finbourne.Identity.Sdk.Client.ISynchronousClient client, Finbourne.Identity.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Identity.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <returns>CreatedApiKey</returns>
        public CreatedApiKey CreateApiKey(CreateApiKey createApiKey)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<CreatedApiKey> localVarResponse = CreateApiKeyWithHttpInfo(createApiKey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <returns>ApiResponse of CreatedApiKey</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<CreatedApiKey> CreateApiKeyWithHttpInfo(CreateApiKey createApiKey)
        {
            // verify the required parameter 'createApiKey' is set
            if (createApiKey == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'createApiKey' when calling PersonalAuthenticationTokensApi->CreateApiKey");

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

            localVarRequestOptions.Data = createApiKey;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request
            var localVarResponse = this.Client.Post<CreatedApiKey>("/api/keys", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApiKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatedApiKey</returns>
        public async System.Threading.Tasks.Task<CreatedApiKey> CreateApiKeyAsync(CreateApiKey createApiKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<CreatedApiKey> localVarResponse = await CreateApiKeyWithHttpInfoAsync(createApiKey, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateApiKey: Create a Personal Access Token Generates a Personal Access Token and returns the new key and its associated metadata.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createApiKey">The request to create a new Personal Access Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatedApiKey)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<CreatedApiKey>> CreateApiKeyWithHttpInfoAsync(CreateApiKey createApiKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createApiKey' is set
            if (createApiKey == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'createApiKey' when calling PersonalAuthenticationTokensApi->CreateApiKey");


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

            localVarRequestOptions.Data = createApiKey;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<CreatedApiKey>("/api/keys", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApiKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token Immediately invalidates the specified Personal Access Token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <returns>ApiKey</returns>
        public ApiKey DeleteApiKey(string id)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ApiKey> localVarResponse = DeleteApiKeyWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token Immediately invalidates the specified Personal Access Token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <returns>ApiResponse of ApiKey</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<ApiKey> DeleteApiKeyWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling PersonalAuthenticationTokensApi->DeleteApiKey");

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

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request
            var localVarResponse = this.Client.Delete<ApiKey>("/api/keys/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApiKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token Immediately invalidates the specified Personal Access Token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiKey</returns>
        public async System.Threading.Tasks.Task<ApiKey> DeleteApiKeyAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ApiKey> localVarResponse = await DeleteApiKeyWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token Immediately invalidates the specified Personal Access Token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the Personal Access Token to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiKey)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<ApiKey>> DeleteApiKeyWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Identity.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling PersonalAuthenticationTokensApi->DeleteApiKey");


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

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<ApiKey>("/api/keys/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApiKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;ApiKey&gt;</returns>
        public ICollection<ApiKey> ListOwnApiKeys()
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ICollection<ApiKey>> localVarResponse = ListOwnApiKeysWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;ApiKey&gt;</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<ICollection<ApiKey>> ListOwnApiKeysWithHttpInfo()
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<ApiKey>>("/api/keys", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOwnApiKeys", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;ApiKey&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<ApiKey>> ListOwnApiKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ICollection<ApiKey>> localVarResponse = await ListOwnApiKeysWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. Gets the meta data for all of the user&#39;s Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;ApiKey&gt;)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<ICollection<ApiKey>>> ListOwnApiKeysWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.2621");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<ApiKey>>("/api/keys", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOwnApiKeys", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}