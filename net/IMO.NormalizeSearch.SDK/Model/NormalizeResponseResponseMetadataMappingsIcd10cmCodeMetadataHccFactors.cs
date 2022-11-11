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
    /// An HCC factor
    /// </summary>
    [DataContract]
    public partial class NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors :  IEquatable<NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors" /> class.
        /// </summary>
        /// <param name="institutional">HCC Institutional factor.</param>
        /// <param name="communityFbdualAged">HCC Community FBDual Aged factor.</param>
        /// <param name="communityPbdualAged">HCC Community PBDual Aged factor.</param>
        /// <param name="communityNondualAged">HCC Community NonDual Aged factor.</param>
        /// <param name="communityFbdualDisabled">HCC Community FBDual Disabled factor.</param>
        /// <param name="communityPbdualDisabled">HCC Community PBDual Disabled factor.</param>
        /// <param name="communityNondualDisabled">HCC Community NonDual Disabled factor.</param>
        public NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors(string institutional = default(string), string communityFbdualAged = default(string), string communityPbdualAged = default(string), string communityNondualAged = default(string), string communityFbdualDisabled = default(string), string communityPbdualDisabled = default(string), string communityNondualDisabled = default(string))
        {
            this.Institutional = institutional;
            this.CommunityFbdualAged = communityFbdualAged;
            this.CommunityPbdualAged = communityPbdualAged;
            this.CommunityNondualAged = communityNondualAged;
            this.CommunityFbdualDisabled = communityFbdualDisabled;
            this.CommunityPbdualDisabled = communityPbdualDisabled;
            this.CommunityNondualDisabled = communityNondualDisabled;
        }
        
        /// <summary>
        /// HCC Institutional factor
        /// </summary>
        /// <value>HCC Institutional factor</value>
        [DataMember(Name="institutional", EmitDefaultValue=false)]
        public string Institutional { get; set; }

        /// <summary>
        /// HCC Community FBDual Aged factor
        /// </summary>
        /// <value>HCC Community FBDual Aged factor</value>
        [DataMember(Name="community_fbdual_aged", EmitDefaultValue=false)]
        public string CommunityFbdualAged { get; set; }

        /// <summary>
        /// HCC Community PBDual Aged factor
        /// </summary>
        /// <value>HCC Community PBDual Aged factor</value>
        [DataMember(Name="community_pbdual_aged", EmitDefaultValue=false)]
        public string CommunityPbdualAged { get; set; }

        /// <summary>
        /// HCC Community NonDual Aged factor
        /// </summary>
        /// <value>HCC Community NonDual Aged factor</value>
        [DataMember(Name="community_nondual_aged", EmitDefaultValue=false)]
        public string CommunityNondualAged { get; set; }

        /// <summary>
        /// HCC Community FBDual Disabled factor
        /// </summary>
        /// <value>HCC Community FBDual Disabled factor</value>
        [DataMember(Name="community_fbdual_disabled", EmitDefaultValue=false)]
        public string CommunityFbdualDisabled { get; set; }

        /// <summary>
        /// HCC Community PBDual Disabled factor
        /// </summary>
        /// <value>HCC Community PBDual Disabled factor</value>
        [DataMember(Name="community_pbdual_disabled", EmitDefaultValue=false)]
        public string CommunityPbdualDisabled { get; set; }

        /// <summary>
        /// HCC Community NonDual Disabled factor
        /// </summary>
        /// <value>HCC Community NonDual Disabled factor</value>
        [DataMember(Name="community_nondual_disabled", EmitDefaultValue=false)]
        public string CommunityNondualDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors {\n");
            sb.Append("  Institutional: ").Append(Institutional).Append("\n");
            sb.Append("  CommunityFbdualAged: ").Append(CommunityFbdualAged).Append("\n");
            sb.Append("  CommunityPbdualAged: ").Append(CommunityPbdualAged).Append("\n");
            sb.Append("  CommunityNondualAged: ").Append(CommunityNondualAged).Append("\n");
            sb.Append("  CommunityFbdualDisabled: ").Append(CommunityFbdualDisabled).Append("\n");
            sb.Append("  CommunityPbdualDisabled: ").Append(CommunityPbdualDisabled).Append("\n");
            sb.Append("  CommunityNondualDisabled: ").Append(CommunityNondualDisabled).Append("\n");
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
            return this.Equals(input as NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors);
        }

        /// <summary>
        /// Returns true if NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizeResponseResponseMetadataMappingsIcd10cmCodeMetadataHccFactors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Institutional == input.Institutional ||
                    (this.Institutional != null &&
                    this.Institutional.Equals(input.Institutional))
                ) && 
                (
                    this.CommunityFbdualAged == input.CommunityFbdualAged ||
                    (this.CommunityFbdualAged != null &&
                    this.CommunityFbdualAged.Equals(input.CommunityFbdualAged))
                ) && 
                (
                    this.CommunityPbdualAged == input.CommunityPbdualAged ||
                    (this.CommunityPbdualAged != null &&
                    this.CommunityPbdualAged.Equals(input.CommunityPbdualAged))
                ) && 
                (
                    this.CommunityNondualAged == input.CommunityNondualAged ||
                    (this.CommunityNondualAged != null &&
                    this.CommunityNondualAged.Equals(input.CommunityNondualAged))
                ) && 
                (
                    this.CommunityFbdualDisabled == input.CommunityFbdualDisabled ||
                    (this.CommunityFbdualDisabled != null &&
                    this.CommunityFbdualDisabled.Equals(input.CommunityFbdualDisabled))
                ) && 
                (
                    this.CommunityPbdualDisabled == input.CommunityPbdualDisabled ||
                    (this.CommunityPbdualDisabled != null &&
                    this.CommunityPbdualDisabled.Equals(input.CommunityPbdualDisabled))
                ) && 
                (
                    this.CommunityNondualDisabled == input.CommunityNondualDisabled ||
                    (this.CommunityNondualDisabled != null &&
                    this.CommunityNondualDisabled.Equals(input.CommunityNondualDisabled))
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
                if (this.Institutional != null)
                    hashCode = hashCode * 59 + this.Institutional.GetHashCode();
                if (this.CommunityFbdualAged != null)
                    hashCode = hashCode * 59 + this.CommunityFbdualAged.GetHashCode();
                if (this.CommunityPbdualAged != null)
                    hashCode = hashCode * 59 + this.CommunityPbdualAged.GetHashCode();
                if (this.CommunityNondualAged != null)
                    hashCode = hashCode * 59 + this.CommunityNondualAged.GetHashCode();
                if (this.CommunityFbdualDisabled != null)
                    hashCode = hashCode * 59 + this.CommunityFbdualDisabled.GetHashCode();
                if (this.CommunityPbdualDisabled != null)
                    hashCode = hashCode * 59 + this.CommunityPbdualDisabled.GetHashCode();
                if (this.CommunityNondualDisabled != null)
                    hashCode = hashCode * 59 + this.CommunityNondualDisabled.GetHashCode();
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
