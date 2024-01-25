/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2765
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
    /// Users directory query response
    /// </summary>
    [DataContract(Name = "ListUsersResponse")]
    public partial class ListUsersResponse : IEquatable<ListUsersResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUsersResponse" /> class.
        /// </summary>
        /// <param name="href">Uri of this response.</param>
        /// <param name="values">Successful entities, indexed by their id.</param>
        /// <param name="failed">Failed entities, indexed by their id.</param>
        /// <param name="links">links.</param>
        public ListUsersResponse(string href = default(string), Dictionary<string, UserSummary> values = default(Dictionary<string, UserSummary>), Dictionary<string, ErrorDetail> failed = default(Dictionary<string, ErrorDetail>), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            this.Values = values;
            this.Failed = failed;
            this.Links = links;
        }

        /// <summary>
        /// Uri of this response
        /// </summary>
        /// <value>Uri of this response</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Successful entities, indexed by their id
        /// </summary>
        /// <value>Successful entities, indexed by their id</value>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public Dictionary<string, UserSummary> Values { get; set; }

        /// <summary>
        /// Failed entities, indexed by their id
        /// </summary>
        /// <value>Failed entities, indexed by their id</value>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public Dictionary<string, ErrorDetail> Failed { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as ListUsersResponse);
        }

        /// <summary>
        /// Returns true if ListUsersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUsersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUsersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed != null &&
                    input.Failed != null &&
                    this.Failed.SequenceEqual(input.Failed)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
