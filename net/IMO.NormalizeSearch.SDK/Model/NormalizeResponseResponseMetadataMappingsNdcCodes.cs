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
    /// NormalizeResponseResponseMetadataMappingsNdcCodes
    /// </summary>
    [DataContract]
    public partial class NormalizeResponseResponseMetadataMappingsNdcCodes :  IEquatable<NormalizeResponseResponseMetadataMappingsNdcCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeResponseResponseMetadataMappingsNdcCodes" /> class.
        /// </summary>
        /// <param name="ndcCode">An NDC code mapped to the IMO lexical.</param>
        /// <param name="ndcMetadata">ndcMetadata.</param>
        public NormalizeResponseResponseMetadataMappingsNdcCodes(string ndcCode = default(string), List<NormalizeResponseResponseMetadataMappingsNdcNdcMetadata> ndcMetadata = default(List<NormalizeResponseResponseMetadataMappingsNdcNdcMetadata>))
        {
            this.NdcCode = ndcCode;
            this.NdcMetadata = ndcMetadata;
        }
        
        /// <summary>
        /// An NDC code mapped to the IMO lexical
        /// </summary>
        /// <value>An NDC code mapped to the IMO lexical</value>
        [DataMember(Name="ndc_code", EmitDefaultValue=false)]
        public string NdcCode { get; set; }

        /// <summary>
        /// Gets or Sets NdcMetadata
        /// </summary>
        [DataMember(Name="ndc_metadata", EmitDefaultValue=false)]
        public List<NormalizeResponseResponseMetadataMappingsNdcNdcMetadata> NdcMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeResponseResponseMetadataMappingsNdcCodes {\n");
            sb.Append("  NdcCode: ").Append(NdcCode).Append("\n");
            sb.Append("  NdcMetadata: ").Append(NdcMetadata).Append("\n");
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
            return this.Equals(input as NormalizeResponseResponseMetadataMappingsNdcCodes);
        }

        /// <summary>
        /// Returns true if NormalizeResponseResponseMetadataMappingsNdcCodes instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeResponseResponseMetadataMappingsNdcCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeResponseResponseMetadataMappingsNdcCodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NdcCode == input.NdcCode ||
                    (this.NdcCode != null &&
                    this.NdcCode.Equals(input.NdcCode))
                ) && 
                (
                    this.NdcMetadata == input.NdcMetadata ||
                    this.NdcMetadata != null &&
                    input.NdcMetadata != null &&
                    this.NdcMetadata.SequenceEqual(input.NdcMetadata)
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
                if (this.NdcCode != null)
                    hashCode = hashCode * 59 + this.NdcCode.GetHashCode();
                if (this.NdcMetadata != null)
                    hashCode = hashCode * 59 + this.NdcMetadata.GetHashCode();
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