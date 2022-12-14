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
    /// NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr
    /// </summary>
    [DataContract]
    public partial class NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr :  IEquatable<NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr" /> class.
        /// </summary>
        /// <param name="ccsrCategory">A CCSR category code.</param>
        /// <param name="ccsrDescription">The ccsr_category&#39;s description.</param>
        public NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr(string ccsrCategory = default(string), string ccsrDescription = default(string))
        {
            this.CcsrCategory = ccsrCategory;
            this.CcsrDescription = ccsrDescription;
        }
        
        /// <summary>
        /// A CCSR category code
        /// </summary>
        /// <value>A CCSR category code</value>
        [DataMember(Name="ccsr_category", EmitDefaultValue=false)]
        public string CcsrCategory { get; set; }

        /// <summary>
        /// The ccsr_category&#39;s description
        /// </summary>
        /// <value>The ccsr_category&#39;s description</value>
        [DataMember(Name="ccsr_description", EmitDefaultValue=false)]
        public string CcsrDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr {\n");
            sb.Append("  CcsrCategory: ").Append(CcsrCategory).Append("\n");
            sb.Append("  CcsrDescription: ").Append(CcsrDescription).Append("\n");
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
            return this.Equals(input as NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr);
        }

        /// <summary>
        /// Returns true if NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataCcsr input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CcsrCategory == input.CcsrCategory ||
                    (this.CcsrCategory != null &&
                    this.CcsrCategory.Equals(input.CcsrCategory))
                ) && 
                (
                    this.CcsrDescription == input.CcsrDescription ||
                    (this.CcsrDescription != null &&
                    this.CcsrDescription.Equals(input.CcsrDescription))
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
                if (this.CcsrCategory != null)
                    hashCode = hashCode * 59 + this.CcsrCategory.GetHashCode();
                if (this.CcsrDescription != null)
                    hashCode = hashCode * 59 + this.CcsrDescription.GetHashCode();
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
