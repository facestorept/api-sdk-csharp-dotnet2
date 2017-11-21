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
  public class Brand {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public long? Position { get; set; }

    /// <summary>
    /// Gets or Sets ImageSmall
    /// </summary>
    [DataMember(Name="image_small", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_small")]
    public string ImageSmall { get; set; }

    /// <summary>
    /// Gets or Sets ImageLarger
    /// </summary>
    [DataMember(Name="image_larger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_larger")]
    public string ImageLarger { get; set; }

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
    /// channels that resource are showed
    /// </summary>
    /// <value>channels that resource are showed</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public List<string> Visibility { get; set; }

    /// <summary>
    /// I18n fields to brands
    /// </summary>
    /// <value>I18n fields to brands</value>
    [DataMember(Name="i18n", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "i18n")]
    public List<I18n> I18n { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Brand {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  ImageSmall: ").Append(ImageSmall).Append("\n");
      sb.Append("  ImageLarger: ").Append(ImageLarger).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  I18n: ").Append(I18n).Append("\n");
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
