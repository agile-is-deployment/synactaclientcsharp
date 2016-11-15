/* 
 * Synacta
 *
 * WebApi
 *
 * OpenAPI spec version: v1
 * Contact: bhofmann@agile-is.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// DocumentVersion
    /// </summary>
    [DataContract]
    public partial class DocumentVersion :  IEquatable<DocumentVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVersion" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="FileSize">FileSize.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="ParentType">ParentType.</param>
        /// <param name="OdataContext">OdataContext.</param>
        /// <param name="OdataReadLink">OdataReadLink.</param>
        /// <param name="FileodataNavigationLink">FileodataNavigationLink.</param>
        /// <param name="RestoreodataNavigationLink">RestoreodataNavigationLink.</param>
        /// <param name="FullODataLinkodataNavigationLink">FullODataLinkodataNavigationLink.</param>
        /// <param name="StandardODataLinkodataNavigationLink">StandardODataLinkodataNavigationLink.</param>
        /// <param name="NoneODataLinkodataNavigationLink">NoneODataLinkodataNavigationLink.</param>
        public DocumentVersion(string Version = null, string CreatedBy = null, Object CreatedAt = null, long? FileSize = null, string ParentId = null, string ParentType = null, string OdataContext = null, string OdataReadLink = null, string FileodataNavigationLink = null, string RestoreodataNavigationLink = null, string FullODataLinkodataNavigationLink = null, string StandardODataLinkodataNavigationLink = null, string NoneODataLinkodataNavigationLink = null)
        {
            this.Version = Version;
            this.CreatedBy = CreatedBy;
            this.CreatedAt = CreatedAt;
            this.FileSize = FileSize;
            this.ParentId = ParentId;
            this.ParentType = ParentType;
            this.OdataContext = OdataContext;
            this.OdataReadLink = OdataReadLink;
            this.FileodataNavigationLink = FileodataNavigationLink;
            this.RestoreodataNavigationLink = RestoreodataNavigationLink;
            this.FullODataLinkodataNavigationLink = FullODataLinkodataNavigationLink;
            this.StandardODataLinkodataNavigationLink = StandardODataLinkodataNavigationLink;
            this.NoneODataLinkodataNavigationLink = NoneODataLinkodataNavigationLink;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public Object CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="FileSize", EmitDefaultValue=false)]
        public long? FileSize { get; set; }
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="ParentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }
        /// <summary>
        /// Gets or Sets ParentType
        /// </summary>
        [DataMember(Name="ParentType", EmitDefaultValue=false)]
        public string ParentType { get; set; }
        /// <summary>
        /// Gets or Sets OdataContext
        /// </summary>
        [DataMember(Name="@odata.context", EmitDefaultValue=false)]
        public string OdataContext { get; set; }
        /// <summary>
        /// Gets or Sets OdataReadLink
        /// </summary>
        [DataMember(Name="@odata.readLink", EmitDefaultValue=false)]
        public string OdataReadLink { get; set; }
        /// <summary>
        /// Gets or Sets FileodataNavigationLink
        /// </summary>
        [DataMember(Name="File@odata.navigationLink", EmitDefaultValue=false)]
        public string FileodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets RestoreodataNavigationLink
        /// </summary>
        [DataMember(Name="Restore@odata.navigationLink", EmitDefaultValue=false)]
        public string RestoreodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets FullODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="FullODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string FullODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets StandardODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="StandardODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string StandardODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets NoneODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="NoneODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string NoneODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentVersion {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ParentType: ").Append(ParentType).Append("\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  OdataReadLink: ").Append(OdataReadLink).Append("\n");
            sb.Append("  FileodataNavigationLink: ").Append(FileodataNavigationLink).Append("\n");
            sb.Append("  RestoreodataNavigationLink: ").Append(RestoreodataNavigationLink).Append("\n");
            sb.Append("  FullODataLinkodataNavigationLink: ").Append(FullODataLinkodataNavigationLink).Append("\n");
            sb.Append("  StandardODataLinkodataNavigationLink: ").Append(StandardODataLinkodataNavigationLink).Append("\n");
            sb.Append("  NoneODataLinkodataNavigationLink: ").Append(NoneODataLinkodataNavigationLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DocumentVersion);
        }

        /// <summary>
        /// Returns true if DocumentVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.FileSize == other.FileSize ||
                    this.FileSize != null &&
                    this.FileSize.Equals(other.FileSize)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.ParentType == other.ParentType ||
                    this.ParentType != null &&
                    this.ParentType.Equals(other.ParentType)
                ) && 
                (
                    this.OdataContext == other.OdataContext ||
                    this.OdataContext != null &&
                    this.OdataContext.Equals(other.OdataContext)
                ) && 
                (
                    this.OdataReadLink == other.OdataReadLink ||
                    this.OdataReadLink != null &&
                    this.OdataReadLink.Equals(other.OdataReadLink)
                ) && 
                (
                    this.FileodataNavigationLink == other.FileodataNavigationLink ||
                    this.FileodataNavigationLink != null &&
                    this.FileodataNavigationLink.Equals(other.FileodataNavigationLink)
                ) && 
                (
                    this.RestoreodataNavigationLink == other.RestoreodataNavigationLink ||
                    this.RestoreodataNavigationLink != null &&
                    this.RestoreodataNavigationLink.Equals(other.RestoreodataNavigationLink)
                ) && 
                (
                    this.FullODataLinkodataNavigationLink == other.FullODataLinkodataNavigationLink ||
                    this.FullODataLinkodataNavigationLink != null &&
                    this.FullODataLinkodataNavigationLink.Equals(other.FullODataLinkodataNavigationLink)
                ) && 
                (
                    this.StandardODataLinkodataNavigationLink == other.StandardODataLinkodataNavigationLink ||
                    this.StandardODataLinkodataNavigationLink != null &&
                    this.StandardODataLinkodataNavigationLink.Equals(other.StandardODataLinkodataNavigationLink)
                ) && 
                (
                    this.NoneODataLinkodataNavigationLink == other.NoneODataLinkodataNavigationLink ||
                    this.NoneODataLinkodataNavigationLink != null &&
                    this.NoneODataLinkodataNavigationLink.Equals(other.NoneODataLinkodataNavigationLink)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.FileSize != null)
                    hash = hash * 59 + this.FileSize.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.ParentType != null)
                    hash = hash * 59 + this.ParentType.GetHashCode();
                if (this.OdataContext != null)
                    hash = hash * 59 + this.OdataContext.GetHashCode();
                if (this.OdataReadLink != null)
                    hash = hash * 59 + this.OdataReadLink.GetHashCode();
                if (this.FileodataNavigationLink != null)
                    hash = hash * 59 + this.FileodataNavigationLink.GetHashCode();
                if (this.RestoreodataNavigationLink != null)
                    hash = hash * 59 + this.RestoreodataNavigationLink.GetHashCode();
                if (this.FullODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.FullODataLinkodataNavigationLink.GetHashCode();
                if (this.StandardODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.StandardODataLinkodataNavigationLink.GetHashCode();
                if (this.NoneODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.NoneODataLinkodataNavigationLink.GetHashCode();
                return hash;
            }
        }
    }

}