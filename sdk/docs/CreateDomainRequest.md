# Finbourne.Identity.Sdk.Model.CreateDomainRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The name LUSID domain to create | 
**Description** | **string** | Optional. Free text description of the domain. | [optional] 
**CompanyName** | **string** | The name of the company to which the domain is registered | 
**Owner** | [**CreateUserRequest**](CreateUserRequest.md) |  | 
**TechnicalContact** | [**CreateUserRequest**](CreateUserRequest.md) |  | [optional] 
**BillingContact** | [**CreateUserRequest**](CreateUserRequest.md) |  | [optional] 
**SignedAgreements** | **List&lt;string&gt;** | Optional. If Terms and Conditions agreements have been signed during the sign up process | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

