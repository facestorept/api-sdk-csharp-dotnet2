using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Product {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets Manual
    /// </summary>
    [DataMember(Name="manual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manual")]
    public string Manual { get; set; }

    /// <summary>
    /// Gets or Sets UrlVideo
    /// </summary>
    [DataMember(Name="url_video", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_video")]
    public string UrlVideo { get; set; }

    /// <summary>
    /// channels that resource are showed
    /// </summary>
    /// <value>channels that resource are showed</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public List<string> Visibility { get; set; }

    /// <summary>
    /// Gets or Sets InHomepage
    /// </summary>
    [DataMember(Name="in_homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "in_homepage")]
    public bool? InHomepage { get; set; }

    /// <summary>
    /// Gets or Sets IsPrefered
    /// </summary>
    [DataMember(Name="is_prefered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_prefered")]
    public bool? IsPrefered { get; set; }

    /// <summary>
    /// Gets or Sets IsDigital
    /// </summary>
    [DataMember(Name="is_digital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_digital")]
    public bool? IsDigital { get; set; }

    /// <summary>
    /// Gets or Sets UrlDigital
    /// </summary>
    [DataMember(Name="url_digital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_digital")]
    public string UrlDigital { get; set; }

    /// <summary>
    /// Gets or Sets IsNew
    /// </summary>
    [DataMember(Name="is_new", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_new")]
    public bool? IsNew { get; set; }

    /// <summary>
    /// Gets or Sets I18n
    /// </summary>
    [DataMember(Name="i18n", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "i18n")]
    public I18nProduct I18n { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public DateTime? ExpiresAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Product {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Manual: ").Append(Manual).Append("\n");
      sb.Append("  UrlVideo: ").Append(UrlVideo).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  InHomepage: ").Append(InHomepage).Append("\n");
      sb.Append("  IsPrefered: ").Append(IsPrefered).Append("\n");
      sb.Append("  IsDigital: ").Append(IsDigital).Append("\n");
      sb.Append("  UrlDigital: ").Append(UrlDigital).Append("\n");
      sb.Append("  IsNew: ").Append(IsNew).Append("\n");
      sb.Append("  I18n: ").Append(I18n).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
