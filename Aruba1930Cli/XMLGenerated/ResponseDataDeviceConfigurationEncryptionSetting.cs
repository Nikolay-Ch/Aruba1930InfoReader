#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable IDE1006 // Naming Styles

namespace Aruba1930Cli.XMLGenerated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "ResponseData")]
    public partial class ResponseDataEncriptionSettings
    {

        private ResponseDataEncriptionSettingsDeviceConfiguration deviceConfigurationField;

        private ResponseDataEncriptionSettingsActionStatus actionStatusField;

        /// <remarks/>
        public ResponseDataEncriptionSettingsDeviceConfiguration DeviceConfiguration
        {
            get
            {
                return this.deviceConfigurationField;
            }
            set
            {
                this.deviceConfigurationField = value;
            }
        }

        /// <remarks/>
        public ResponseDataEncriptionSettingsActionStatus ActionStatus
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataEncriptionSettingsDeviceConfiguration
    {

        private decimal versionField;

        private ResponseDataEncriptionSettingsDeviceConfigurationEncryptionSetting encryptionSettingField;

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
        public ResponseDataEncriptionSettingsDeviceConfigurationEncryptionSetting EncryptionSetting
        {
            get
            {
                return this.encryptionSettingField;
            }
            set
            {
                this.encryptionSettingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataEncriptionSettingsDeviceConfigurationEncryptionSetting
    {

        private byte passwEncryptEnableField;

        private string rsaPublicKeyField;

        private string loginTokenField;

        private string typeField;

        /// <remarks/>
        public byte passwEncryptEnable
        {
            get
            {
                return this.passwEncryptEnableField;
            }
            set
            {
                this.passwEncryptEnableField = value;
            }
        }

        /// <remarks/>
        public string rsaPublicKey
        {
            get
            {
                return this.rsaPublicKeyField;
            }
            set
            {
                this.rsaPublicKeyField = value;
            }
        }

        /// <remarks/>
        public string loginToken
        {
            get
            {
                return this.loginTokenField;
            }
            set
            {
                this.loginTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataEncriptionSettingsActionStatus
    {

        private string requestURLField;

        private object statusCodeField;

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
        public object statusCode
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
    }
}

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
