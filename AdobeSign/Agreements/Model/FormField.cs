using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// A form field for an agreement.
  /// </summary>
  [DataContract]
  public class FormField {
    /// <summary>
    /// The type of radio button (if field is radio button, identified by inputType).
    /// </summary>
    /// <value>The type of radio button (if field is radio button, identified by inputType).</value>
    [DataMember(Name="radioCheckType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "radioCheckType")]
    public string RadioCheckType { get; set; }

    /// <summary>
    /// Color of the border of the field in RGB or HEX format
    /// </summary>
    /// <value>Color of the border of the field in RGB or HEX format</value>
    [DataMember(Name="borderColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borderColor")]
    public string BorderColor { get; set; }

    /// <summary>
    /// Expression to calculate value of the form field
    /// </summary>
    /// <value>Expression to calculate value of the form field</value>
    [DataMember(Name="valueExpression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueExpression")]
    public string ValueExpression { get; set; }

    /// <summary>
    /// Text to mask the masked form field
    /// </summary>
    /// <value>Text to mask the masked form field</value>
    [DataMember(Name="maskingText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maskingText")]
    public string MaskingText { get; set; }

    /// <summary>
    /// Default value of the form field
    /// </summary>
    /// <value>Default value of the form field</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// true if the input entered by the signer has to be masked (like password), false if it shouldn't be
    /// </summary>
    /// <value>true if the input entered by the signer has to be masked (like password), false if it shouldn't be</value>
    [DataMember(Name="masked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masked")]
    public bool? Masked { get; set; }

    /// <summary>
    /// Minimum length of the input text field in terms of no. of characters
    /// </summary>
    /// <value>Minimum length of the input text field in terms of no. of characters</value>
    [DataMember(Name="minLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minLength")]
    public int MinLength { get; set; }

    /// <summary>
    /// Origin of Form Field
    /// </summary>
    /// <value>Origin of Form Field</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Text that appears while hovering over the field
    /// </summary>
    /// <value>Text that appears while hovering over the field</value>
    [DataMember(Name="tooltip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tooltip")]
    public string Tooltip { get; set; }

    /// <summary>
    /// Text values which are hidden in a drop down form field
    /// </summary>
    /// <value>Text values which are hidden in a drop down form field</value>
    [DataMember(Name="hiddenOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hiddenOptions")]
    public List<string> HiddenOptions { get; set; }

    /// <summary>
    /// true if it is a mandatory field to be filled by the signer, else false
    /// </summary>
    /// <value>true if it is a mandatory field to be filled by the signer, else false</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Further data for validating input with regards to the field's specified format. The contents and interpretation of formatData depends on the value of validation.
    /// </summary>
    /// <value>Further data for validating input with regards to the field's specified format. The contents and interpretation of formatData depends on the value of validation.</value>
    [DataMember(Name="validationData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationData")]
    public string ValidationData { get; set; }

    /// <summary>
    /// Lower bound of the number that can be entered by the signer
    /// </summary>
    /// <value>Lower bound of the number that can be entered by the signer</value>
    [DataMember(Name="minValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minValue")]
    public double? MinValue { get; set; }

    /// <summary>
    /// Width of the border of the field in pixels
    /// </summary>
    /// <value>Width of the border of the field in pixels</value>
    [DataMember(Name="borderWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borderWidth")]
    public double? BorderWidth { get; set; }

    /// <summary>
    /// For widget text fields only - true if the default value may come from the URL, else false
    /// </summary>
    /// <value>For widget text fields only - true if the default value may come from the URL, else false</value>
    [DataMember(Name="urlOverridable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urlOverridable")]
    public bool? UrlOverridable { get; set; }

    /// <summary>
    /// Input type of the form field
    /// </summary>
    /// <value>Input type of the form field</value>
    [DataMember(Name="inputType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputType")]
    public string InputType { get; set; }

    /// <summary>
    /// Style of the border of the field.
    /// </summary>
    /// <value>Style of the border of the field.</value>
    [DataMember(Name="borderStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borderStyle")]
    public string BorderStyle { get; set; }

    /// <summary>
    /// true if this field's value is calculated from an expression, else false
    /// </summary>
    /// <value>true if this field's value is calculated from an expression, else false</value>
    [DataMember(Name="calculated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calculated")]
    public bool? Calculated { get; set; }

    /// <summary>
    /// Content Type of the form field.
    /// </summary>
    /// <value>Content Type of the form field.</value>
    [DataMember(Name="contentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contentType")]
    public string ContentType { get; set; }

    /// <summary>
    /// Rule for validating the field value.
    /// </summary>
    /// <value>Rule for validating the field value.</value>
    [DataMember(Name="validation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validation")]
    public string Validation { get; set; }

    /// <summary>
    /// Display label attached to the field
    /// </summary>
    /// <value>Display label attached to the field</value>
    [DataMember(Name="displayLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayLabel")]
    public string DisplayLabel { get; set; }

    /// <summary>
    /// Hyperlink-specific data (e.g. as url, link type)
    /// </summary>
    /// <value>Hyperlink-specific data (e.g. as url, link type)</value>
    [DataMember(Name="hyperlink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hyperlink")]
    public FormFieldHyperlink Hyperlink { get; set; }

    /// <summary>
    /// Background color of the form field in RGB or HEX format
    /// </summary>
    /// <value>Background color of the form field in RGB or HEX format</value>
    [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundColor")]
    public string BackgroundColor { get; set; }

    /// <summary>
    /// If set to false, then the form field is hidden.  Otherwise, it is visible.
    /// </summary>
    /// <value>If set to false, then the form field is hidden.  Otherwise, it is visible.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Format type of the text field.
    /// </summary>
    /// <value>Format type of the text field.</value>
    [DataMember(Name="displayFormatType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayFormatType")]
    public string DisplayFormatType { get; set; }

    /// <summary>
    /// Upper bound of the number that can be entered by the signer
    /// </summary>
    /// <value>Upper bound of the number that can be entered by the signer</value>
    [DataMember(Name="maxValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxValue")]
    public double? MaxValue { get; set; }

    /// <summary>
    /// Error message to be shown to the signer if filled value doesn't match the validations of the form field
    /// </summary>
    /// <value>Error message to be shown to the signer if filled value doesn't match the validations of the form field</value>
    [DataMember(Name="validationErrMsg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationErrMsg")]
    public string ValidationErrMsg { get; set; }

    /// <summary>
    /// Format of the value of the field to be displayed based on the displayFormatType property.
    /// </summary>
    /// <value>Format of the value of the field to be displayed based on the displayFormatType property.</value>
    [DataMember(Name="displayFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayFormat")]
    public string DisplayFormat { get; set; }

    /// <summary>
    /// Text values which are visible in a drop down form field
    /// </summary>
    /// <value>Text values which are visible in a drop down form field</value>
    [DataMember(Name="visibleOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibleOptions")]
    public List<string> VisibleOptions { get; set; }

    /// <summary>
    /// true if it is a read-only field, else false
    /// </summary>
    /// <value>true if it is a read-only field, else false</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// Font name of the form field
    /// </summary>
    /// <value>Font name of the form field</value>
    [DataMember(Name="fontName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fontName")]
    public string FontName { get; set; }

    /// <summary>
    /// A predicate (or set of predicates) that determines whether this field is visible and enabled.
    /// </summary>
    /// <value>A predicate (or set of predicates) that determines whether this field is visible and enabled.</value>
    [DataMember(Name="conditionalAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditionalAction")]
    public FormFieldConditionalAction ConditionalAction { get; set; }

    /// <summary>
    /// The name of the form field
    /// </summary>
    /// <value>The name of the form field</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Font size of the form field in points
    /// </summary>
    /// <value>Font size of the form field in points</value>
    [DataMember(Name="fontSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fontSize")]
    public double? FontSize { get; set; }

    /// <summary>
    /// All locations in a document where the form field is placed
    /// </summary>
    /// <value>All locations in a document where the form field is placed</value>
    [DataMember(Name="locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locations")]
    public List<FormFieldLocation> Locations { get; set; }

    /// <summary>
    /// Who the field is assigned to.  Either a participant set id, null, NOBODY or PREFILL.
    /// </summary>
    /// <value>Who the field is assigned to.  Either a participant set id, null, NOBODY or PREFILL.</value>
    [DataMember(Name="assignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignee")]
    public string Assignee { get; set; }

    /// <summary>
    /// Alignment of the text.
    /// </summary>
    /// <value>Alignment of the text.</value>
    [DataMember(Name="alignment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alignment")]
    public string Alignment { get; set; }

    /// <summary>
    /// Font color of the form field in RGB or HEX format
    /// </summary>
    /// <value>Font color of the form field in RGB or HEX format</value>
    [DataMember(Name="fontColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fontColor")]
    public string FontColor { get; set; }

    /// <summary>
    /// Maximum length of the input text field in terms of no. of characters
    /// </summary>
    /// <value>Maximum length of the input text field in terms of no. of characters</value>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public int MaxLength { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormField {\n");
      sb.Append("  RadioCheckType: ").Append(RadioCheckType).Append("\n");
      sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
      sb.Append("  ValueExpression: ").Append(ValueExpression).Append("\n");
      sb.Append("  MaskingText: ").Append(MaskingText).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Masked: ").Append(Masked).Append("\n");
      sb.Append("  MinLength: ").Append(MinLength).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
      sb.Append("  HiddenOptions: ").Append(HiddenOptions).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  ValidationData: ").Append(ValidationData).Append("\n");
      sb.Append("  MinValue: ").Append(MinValue).Append("\n");
      sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
      sb.Append("  UrlOverridable: ").Append(UrlOverridable).Append("\n");
      sb.Append("  InputType: ").Append(InputType).Append("\n");
      sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
      sb.Append("  Calculated: ").Append(Calculated).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
      sb.Append("  Validation: ").Append(Validation).Append("\n");
      sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
      sb.Append("  Hyperlink: ").Append(Hyperlink).Append("\n");
      sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  DisplayFormatType: ").Append(DisplayFormatType).Append("\n");
      sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
      sb.Append("  ValidationErrMsg: ").Append(ValidationErrMsg).Append("\n");
      sb.Append("  DisplayFormat: ").Append(DisplayFormat).Append("\n");
      sb.Append("  VisibleOptions: ").Append(VisibleOptions).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  FontName: ").Append(FontName).Append("\n");
      sb.Append("  ConditionalAction: ").Append(ConditionalAction).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FontSize: ").Append(FontSize).Append("\n");
      sb.Append("  Locations: ").Append(Locations).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  Alignment: ").Append(Alignment).Append("\n");
      sb.Append("  FontColor: ").Append(FontColor).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
