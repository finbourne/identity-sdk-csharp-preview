/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2798
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
    /// AccessControlledResource
    /// </summary>
    [DataContract(Name = "AccessControlledResource")]
    public partial class AccessControlledResource : IEquatable<AccessControlledResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessControlledResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledResource" /> class.
        /// </summary>
        /// <param name="application">application.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description (required).</param>
        /// <param name="actions">actions (required).</param>
        /// <param name="identifierParts">identifierParts.</param>
        /// <param name="links">links.</param>
        public AccessControlledResource(string application = default(string), string name = default(string), string description = default(string), List<AccessControlledAction> actions = default(List<AccessControlledAction>), List<IdentifierPartSchema> identifierParts = default(List<IdentifierPartSchema>), List<Link> links = default(List<Link>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for AccessControlledResource and cannot be null");
            // to ensure "actions" is required (not null)
            this.Actions = actions ?? throw new ArgumentNullException("actions is a required property for AccessControlledResource and cannot be null");
            this.Application = application;
            this.Name = name;
            this.IdentifierParts = identifierParts;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = false)]
        public List<AccessControlledAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierParts
        /// </summary>
        [DataMember(Name = "identifierParts", EmitDefaultValue = true)]
        public List<IdentifierPartSchema> IdentifierParts { get; set; }

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
            sb.Append("class AccessControlledResource {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  IdentifierParts: ").Append(IdentifierParts).Append("\n");
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
            return this.Equals(input as AccessControlledResource);
        }

        /// <summary>
        /// Returns true if AccessControlledResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlledResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlledResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.IdentifierParts == input.IdentifierParts ||
                    this.IdentifierParts != null &&
                    input.IdentifierParts != null &&
                    this.IdentifierParts.SequenceEqual(input.IdentifierParts)
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
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.IdentifierParts != null)
                    hashCode = hashCode * 59 + this.IdentifierParts.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
