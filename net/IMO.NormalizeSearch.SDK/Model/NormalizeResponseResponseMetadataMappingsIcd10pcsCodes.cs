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
    /// NormalizeResponseResponseMetadataMappingsIcd10pcsCodes
    /// </summary>
    [DataContract]
    public partial class NormalizeResponseResponseMetadataMappingsIcd10pcsCodes :  IEquatable<NormalizeResponseResponseMetadataMappingsIcd10pcsCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeResponseResponseMetadataMappingsIcd10pcsCodes" /> class.
        /// </summary>
        /// <param name="code">A ICD-10-PCS code mapped to the IMO lexical.</param>
        /// <param name="title">The official description of the ICD-10-PCS code.</param>
        /// <param name="mapType">Indicates the relationship between the code and the IMO lexical.</param>
        /// <param name="codeMetadata">codeMetadata.</param>
        public NormalizeResponseResponseMetadataMappingsIcd10pcsCodes(string code = default(string), string title = default(string), string mapType = default(string), NormalizeResponseResponseMetadataMappingsIcd10pcsCodeMetadata codeMetadata = default(NormalizeResponseResponseMetadataMappingsIcd10pcsCodeMetadata))
        {
            this.Code = code;
            this.Title = title;
            this.MapType = mapType;
            this.CodeMetadata = codeMetadata;
        }
        
        /// <summary>
        /// A ICD-10-PCS code mapped to the IMO lexical
        /// </summary>
        /// <value>A ICD-10-PCS code mapped to the IMO lexical</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The official description of the ICD-10-PCS code
        /// </summary>
        /// <value>The official description of the ICD-10-PCS code</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Indicates the relationship between the code and the IMO lexical
        /// </summary>
        /// <value>Indicates the relationship between the code and the IMO lexical</value>
        [DataMember(Name="map_type", EmitDefaultValue=false)]
        public string MapType { get; set; }

        /// <summary>
        /// Gets or Sets CodeMetadata
        /// </summary>
        [DataMember(Name="code_metadata", EmitDefaultValue=false)]
        public NormalizeResponseResponseMetadataMappingsIcd10pcsCodeMetadata CodeMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeResponseResponseMetadataMappingsIcd10pcsCodes {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MapType: ").Append(MapType).Append("\n");
            sb.Append("  CodeMetadata: ").Append(CodeMetadata).Append("\n");
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
            return this.Equals(input as NormalizeResponseResponseMetadataMappingsIcd10pcsCodes);
        }

        /// <summary>
        /// Returns true if NormalizeResponseResponseMetadataMappingsIcd10pcsCodes instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeResponseResponseMetadataMappingsIcd10pcsCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeResponseResponseMetadataMappingsIcd10pcsCodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.MapType == input.MapType ||
                    (this.MapType != null &&
                    this.MapType.Equals(input.MapType))
                ) && 
                (
                    this.CodeMetadata == input.CodeMetadata ||
                    (this.CodeMetadata != null &&
                    this.CodeMetadata.Equals(input.CodeMetadata))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.MapType != null)
                    hashCode = hashCode * 59 + this.MapType.GetHashCode();
                if (this.CodeMetadata != null)
                    hashCode = hashCode * 59 + this.CodeMetadata.GetHashCode();
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
