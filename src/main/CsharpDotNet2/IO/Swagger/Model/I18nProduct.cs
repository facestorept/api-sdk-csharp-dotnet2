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
  public class I18nProduct {
    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Synopsis
    /// </summary>
    [DataMember(Name="synopsis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synopsis")]
    public string Synopsis { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Characteristics
    /// </summary>
    [DataMember(Name="characteristics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characteristics")]
    public string Characteristics { get; set; }

    /// <summary>
    /// Gets or Sets Seo
    /// </summary>
    [DataMember(Name="seo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seo")]
    public I18nProductSeo Seo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class I18nProduct {\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Synopsis: ").Append(Synopsis).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
      sb.Append("  Seo: ").Append(Seo).Append("\n");
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
