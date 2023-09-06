/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2593
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Identity.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Identity.Sdk.Model
{
    /// <summary>
    /// AddScimResponse
    /// </summary>
    [DataContract(Name = "AddScimResponse")]
    public partial class AddScimResponse : IEquatable<AddScimResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddScimResponse" /> class.
        /// </summary>
        /// <param name="baseUrl">baseUrl.</param>
        /// <param name="apiToken">apiToken.</param>
        public AddScimResponse(string baseUrl = default(string), string apiToken = default(string))
        {
            this.BaseUrl = baseUrl;
            this.ApiToken = apiToken;
        }

        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [DataMember(Name = "baseUrl", EmitDefaultValue = true)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets ApiToken
        /// </summary>
        [DataMember(Name = "apiToken", EmitDefaultValue = true)]
        public string ApiToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddScimResponse {\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddScimResponse);
        }

        /// <summary>
        /// Returns true if AddScimResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddScimResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddScimResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
                ) && 
                (
                    this.ApiToken == input.ApiToken ||
                    (this.ApiToken != null &&
                    this.ApiToken.Equals(input.ApiToken))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BaseUrl != null)
                    hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.ApiToken != null)
                    hashCode = hashCode * 59 + this.ApiToken.GetHashCode();
                return hashCode;
            }
        }

    }
}
