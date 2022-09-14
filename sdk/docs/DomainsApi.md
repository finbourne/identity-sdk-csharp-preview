# Finbourne.Identity.Sdk.Api.DomainsApi

All URIs are relative to *https://www.lusid.com/identity*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDomain**](DomainsApi.md#createdomain) | **POST** /api/domains | CreateDomain: Create Domain
[**GetAgreement**](DomainsApi.md#getagreement) | **HEAD** /api/domains/me/agreements/{agreement} | GetAgreement: Get Agreement
[**GetMyDomain**](DomainsApi.md#getmydomain) | **GET** /api/domains/me | GetMyDomain: Get current Domain
[**ListAgreements**](DomainsApi.md#listagreements) | **GET** /api/domains/me/agreements | ListAgreements: List Agreements
[**SignAgreement**](DomainsApi.md#signagreement) | **PUT** /api/domains/me/agreements/{agreement} | SignAgreement: Sign Agreement


<a name="createdomain"></a>
# **CreateDomain**
> DomainResponse CreateDomain (string code, CreateDomainRequest createDomainRequest)

CreateDomain: Create Domain

Creates a Domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class CreateDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DomainsApi(config);
            var code = code_example;  // string | The verification code necessary to create domains
            var createDomainRequest = new CreateDomainRequest(); // CreateDomainRequest | The definition of the domain

            try
            {
                // CreateDomain: Create Domain
                DomainResponse result = apiInstance.CreateDomain(code, createDomainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.CreateDomain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The verification code necessary to create domains | 
 **createDomainRequest** | [**CreateDomainRequest**](CreateDomainRequest.md)| The definition of the domain | 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created domain |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreement"></a>
# **GetAgreement**
> void GetAgreement (string agreement)

GetAgreement: Get Agreement

Check whether the domain has signed a specific agreement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetAgreementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DomainsApi(config);
            var agreement = agreement_example;  // string | Name of the agreement

            try
            {
                // GetAgreement: Get Agreement
                apiInstance.GetAgreement(agreement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetAgreement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreement** | **string**| Name of the agreement | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | The agreement is not signed |  -  |
| **200** | The agreement is signed |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmydomain"></a>
# **GetMyDomain**
> DomainResponse GetMyDomain ()

GetMyDomain: Get current Domain

Gets the Domain of the requesting User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetMyDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DomainsApi(config);

            try
            {
                // GetMyDomain: Get current Domain
                DomainResponse result = apiInstance.GetMyDomain();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetMyDomain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The current domain |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listagreements"></a>
# **ListAgreements**
> Dictionary&lt;string, AgreementResponse&gt; ListAgreements ()

ListAgreements: List Agreements

Lists the signed agreements for the current domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class ListAgreementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DomainsApi(config);

            try
            {
                // ListAgreements: List Agreements
                Dictionary<string, AgreementResponse> result = apiInstance.ListAgreements();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.ListAgreements: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Dictionary&lt;string, AgreementResponse&gt;**](AgreementResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List the signed agreements for the current domain |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signagreement"></a>
# **SignAgreement**
> AgreementResponse SignAgreement (string agreement)

SignAgreement: Sign Agreement

Signs a specified agreement. Only the owner of a domain can sign an agreement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class SignAgreementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DomainsApi(config);
            var agreement = agreement_example;  // string | Name of the agreement being signed

            try
            {
                // SignAgreement: Sign Agreement
                AgreementResponse result = apiInstance.SignAgreement(agreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.SignAgreement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreement** | **string**| Name of the agreement being signed | 

### Return type

[**AgreementResponse**](AgreementResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Signs a specified agreement |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

