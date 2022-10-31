using System.Xml.Serialization;

namespace Aruba1930Cli.XMLGenerated
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataActionStatus
    {

        private decimal versionField;

        private string requestURLField;

        private string statusCodeField;

        private string deviceStatusCodeField;

        private string statusStringField;

        /// <remarks/>
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string requestURL
        {
            get
            {
                return this.requestURLField;
            }
            set
            {
                this.requestURLField = value;
            }
        }

        /// <remarks/>
        public string statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string deviceStatusCode
        {
            get
            {
                return this.deviceStatusCodeField;
            }
            set
            {
                this.deviceStatusCodeField = value;
            }
        }

        /// <remarks/>
        public string statusString
        {
            get
            {
                return this.statusStringField;
            }
            set
            {
                this.statusStringField = value;
            }
        }
    }
}
