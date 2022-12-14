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
    /// NormalizeRequestPreferencesTransformations
    /// </summary>
    [DataContract]
    public partial class NormalizeRequestPreferencesTransformations :  IEquatable<NormalizeRequestPreferencesTransformations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeRequestPreferencesTransformations" /> class.
        /// </summary>
        /// <param name="type">Type of transformation will be applied to the input term. Currect support value is \&quot;string_replace\&quot;..</param>
        /// <param name="location">Location of string to be transformed in the input term. Current support values are \&quot;beginning|end|*\&quot;. \&quot;*\&quot; means any places in the input term..</param>
        /// <param name="from">The original string value in the input term to be replaced. The pattern match is for whole word match only..</param>
        /// <param name="to">The new replacement string..</param>
        /// <param name="caseSensitive">Optional, Whether the string replacement should be case sensitive or not. Default is False..</param>
        public NormalizeRequestPreferencesTransformations(string type = default(string), string location = default(string), string from = default(string), string to = default(string), bool caseSensitive = default(bool))
        {
            this.Type = type;
            this.Location = location;
            this.From = from;
            this.To = to;
            this.CaseSensitive = caseSensitive;
        }
        
        /// <summary>
        /// Type of transformation will be applied to the input term. Currect support value is \&quot;string_replace\&quot;.
        /// </summary>
        /// <value>Type of transformation will be applied to the input term. Currect support value is \&quot;string_replace\&quot;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Location of string to be transformed in the input term. Current support values are \&quot;beginning|end|*\&quot;. \&quot;*\&quot; means any places in the input term.
        /// </summary>
        /// <value>Location of string to be transformed in the input term. Current support values are \&quot;beginning|end|*\&quot;. \&quot;*\&quot; means any places in the input term.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The original string value in the input term to be replaced. The pattern match is for whole word match only.
        /// </summary>
        /// <value>The original string value in the input term to be replaced. The pattern match is for whole word match only.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// The new replacement string.
        /// </summary>
        /// <value>The new replacement string.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Optional, Whether the string replacement should be case sensitive or not. Default is False.
        /// </summary>
        /// <value>Optional, Whether the string replacement should be case sensitive or not. Default is False.</value>
        [DataMember(Name="case_sensitive", EmitDefaultValue=false)]
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeRequestPreferencesTransformations {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
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
            return this.Equals(input as NormalizeRequestPreferencesTransformations);
        }

        /// <summary>
        /// Returns true if NormalizeRequestPreferencesTransformations instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeRequestPreferencesTransformations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeRequestPreferencesTransformations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    this.CaseSensitive.Equals(input.CaseSensitive)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
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
