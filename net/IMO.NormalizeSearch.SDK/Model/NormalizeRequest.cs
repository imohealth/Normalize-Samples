/* 
 * IMO® Precision Normalize API
 *
 * <p>IMO® Precision Normalize provides normalization capabilities enabling standardization of inconsistent clinical data from diverse health information systems to a common, clinically validated terminology to ensure that problems, procedures, and medications have clean, enriched, and consistent meanings. This API normalizes input terms or codes to IMO identifiers.</p> <p>The information provided is confidential and proprietary. Any use of this outside an agreement or engagement with IMO is prohibited.</p>
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: customersupport@imo-online.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IMO.NormalizeSearch.SDK.Client.OpenAPIDateConverter;

namespace IMO.NormalizeSearch.SDK.Model
{
    /// <summary>
    /// NormalizeRequest
    /// </summary>
    [DataContract]
    public partial class NormalizeRequest : IEquatable<NormalizeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeRequest" /> class.
        /// </summary>
        /// <param name="clientRequestId">Unique identifier of the request from the partner application (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="requests">requests (required).</param>
        /// <remarks>
        /// This was manually modified. If the OpenAPI Generator is run again, these changes will get overwritten
        /// and need to be manually reverted. The modification was to remove the thrown ArgumentNullException when
        /// a required property was null. This was removed since it would introduce a breaking change to the way
        /// the request object could be created.  More specifically, creation via object initializer syntax will no
        /// longer work if this constructor throws an exception.
        /// </remarks>
        public NormalizeRequest(string clientRequestId = default(string), NormalizeRequestPreferences preferences = default(NormalizeRequestPreferences), List<NormalizeRequestRequests> requests = default(List<NormalizeRequestRequests>))
        {
            this.ClientRequestId = clientRequestId;
            this.Requests = requests;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Unique identifier of the request from the partner application
        /// </summary>
        /// <value>Unique identifier of the request from the partner application</value>
        [DataMember(Name = "client_request_id", EmitDefaultValue = false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public NormalizeRequestPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name = "requests", EmitDefaultValue = false)]
        public List<NormalizeRequestRequests> Requests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeRequest {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NormalizeRequest);
        }

        /// <summary>
        /// Returns true if NormalizeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) &&
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) &&
                (
                    this.Requests == input.Requests ||
                    this.Requests != null &&
                    input.Requests != null &&
                    this.Requests.SequenceEqual(input.Requests)
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Requests != null)
                    hashCode = hashCode * 59 + this.Requests.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
