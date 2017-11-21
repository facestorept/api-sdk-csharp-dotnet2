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
  public class MetaPartialResponse {
    /// <summary>
    /// Gets or Sets FirstPageUrl
    /// </summary>
    [DataMember(Name="first_page_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_page_url")]
    public string FirstPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets LastPageUrl
    /// </summary>
    [DataMember(Name="last_page_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_page_url")]
    public string LastPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets NextPageUrl
    /// </summary>
    [DataMember(Name="next_page_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_page_url")]
    public string NextPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets PrevPageUrl
    /// </summary>
    [DataMember(Name="prev_page_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prev_page_url")]
    public string PrevPageUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetaPartialResponse {\n");
      sb.Append("  FirstPageUrl: ").Append(FirstPageUrl).Append("\n");
      sb.Append("  LastPageUrl: ").Append(LastPageUrl).Append("\n");
      sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  PrevPageUrl: ").Append(PrevPageUrl).Append("\n");
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
