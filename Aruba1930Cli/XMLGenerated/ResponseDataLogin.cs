namespace Aruba1930Cli.XMLGenerated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "ResponseData")]
    public partial class ResponseDataLogin
    {

        private ResponseDataActionStatus actionStatusField;

        /// <remarks/>
        public ResponseDataActionStatus ActionStatus
        {
            get
            {
                return this.actionStatusField;
            }
            set
            {
                this.actionStatusField = value;
            }
        }
    }
}
