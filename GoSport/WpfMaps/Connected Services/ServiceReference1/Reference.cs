﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfMaps.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.CityInfo CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.CityInfo City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CityInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class CityInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.CountryInfo CountryInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.CountryInfo CountryInfo {
            get {
                return this.CountryInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryInfoField, value) != true)) {
                    this.CountryInfoField = value;
                    this.RaisePropertyChanged("CountryInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class CountryInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.CityInfo[] CityInfosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.CityInfo[] CityInfos {
            get {
                return this.CityInfosField;
            }
            set {
                if ((object.ReferenceEquals(this.CityInfosField, value) != true)) {
                    this.CityInfosField = value;
                    this.RaisePropertyChanged("CityInfos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class IncorrectInputData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class TokenInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.UserInfo SessionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.UserInfo Session {
            get {
                return this.SessionField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionField, value) != true)) {
                    this.SessionField = value;
                    this.RaisePropertyChanged("Session");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class ActivityInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.ImageInfo[] ActivityImagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.RouteInfo RouteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.UserInfo[] UsersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.ImageInfo[] ActivityImages {
            get {
                return this.ActivityImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.ActivityImagesField, value) != true)) {
                    this.ActivityImagesField = value;
                    this.RaisePropertyChanged("ActivityImages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.RouteInfo Route {
            get {
                return this.RouteField;
            }
            set {
                if ((object.ReferenceEquals(this.RouteField, value) != true)) {
                    this.RouteField = value;
                    this.RaisePropertyChanged("Route");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.UserInfo[] Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RouteInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class RouteInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.CityInfo CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.PointInfo[] PointsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.CityInfo City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.PointInfo[] Points {
            get {
                return this.PointsField;
            }
            set {
                if ((object.ReferenceEquals(this.PointsField, value) != true)) {
                    this.PointsField = value;
                    this.RaisePropertyChanged("Points");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class ImageInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfMaps.ServiceReference1.ActivityInfo ActivityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] BinaryImageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfMaps.ServiceReference1.ActivityInfo Activity {
            get {
                return this.ActivityField;
            }
            set {
                if ((object.ReferenceEquals(this.ActivityField, value) != true)) {
                    this.ActivityField = value;
                    this.RaisePropertyChanged("Activity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] BinaryImage {
            get {
                return this.BinaryImageField;
            }
            set {
                if ((object.ReferenceEquals(this.BinaryImageField, value) != true)) {
                    this.BinaryImageField = value;
                    this.RaisePropertyChanged("BinaryImage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PointInfo", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    [System.SerializableAttribute()]
    public partial class PointInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LongitudeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SignUp", ReplyAction="http://tempuri.org/IService/SignUpResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WpfMaps.ServiceReference1.IncorrectInputData), Action="http://tempuri.org/IService/SignUpIncorrectInputDataFault", Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
        void SignUp(WpfMaps.ServiceReference1.UserInfo user, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SignUp", ReplyAction="http://tempuri.org/IService/SignUpResponse")]
        System.Threading.Tasks.Task SignUpAsync(WpfMaps.ServiceReference1.UserInfo user, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendCode", ReplyAction="http://tempuri.org/IService/SendCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WpfMaps.ServiceReference1.IncorrectInputData), Action="http://tempuri.org/IService/SendCodeIncorrectInputDataFault", Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
        void SendCode(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendCode", ReplyAction="http://tempuri.org/IService/SendCodeResponse")]
        System.Threading.Tasks.Task SendCodeAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConfirmEmail", ReplyAction="http://tempuri.org/IService/ConfirmEmailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WpfMaps.ServiceReference1.IncorrectInputData), Action="http://tempuri.org/IService/ConfirmEmailIncorrectInputDataFault", Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
        string ConfirmEmail(string Email, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConfirmEmail", ReplyAction="http://tempuri.org/IService/ConfirmEmailResponse")]
        System.Threading.Tasks.Task<string> ConfirmEmailAsync(string Email, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListCountries", ReplyAction="http://tempuri.org/IService/GetListCountriesResponse")]
        WpfMaps.ServiceReference1.CountryInfo[] GetListCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListCountries", ReplyAction="http://tempuri.org/IService/GetListCountriesResponse")]
        System.Threading.Tasks.Task<WpfMaps.ServiceReference1.CountryInfo[]> GetListCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListCities", ReplyAction="http://tempuri.org/IService/GetListCitiesResponse")]
        WpfMaps.ServiceReference1.CityInfo[] GetListCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListCities", ReplyAction="http://tempuri.org/IService/GetListCitiesResponse")]
        System.Threading.Tasks.Task<WpfMaps.ServiceReference1.CityInfo[]> GetListCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SignIn", ReplyAction="http://tempuri.org/IService/SignInResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WpfMaps.ServiceReference1.IncorrectInputData), Action="http://tempuri.org/IService/SignInIncorrectInputDataFault", Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
        WpfMaps.ServiceReference1.TokenInfo SignIn(string Email, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SignIn", ReplyAction="http://tempuri.org/IService/SignInResponse")]
        System.Threading.Tasks.Task<WpfMaps.ServiceReference1.TokenInfo> SignInAsync(string Email, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateActivity", ReplyAction="http://tempuri.org/IService/CreateActivityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WpfMaps.ServiceReference1.IncorrectInputData), Action="http://tempuri.org/IService/CreateActivityIncorrectInputDataFault", Name="IncorrectInputData", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
        void CreateActivity(WpfMaps.ServiceReference1.ActivityInfo activity, WpfMaps.ServiceReference1.TokenInfo token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateActivity", ReplyAction="http://tempuri.org/IService/CreateActivityResponse")]
        System.Threading.Tasks.Task CreateActivityAsync(WpfMaps.ServiceReference1.ActivityInfo activity, WpfMaps.ServiceReference1.TokenInfo token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllActivities", ReplyAction="http://tempuri.org/IService/GetAllActivitiesResponse")]
        WpfMaps.ServiceReference1.ActivityInfo[] GetAllActivities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllActivities", ReplyAction="http://tempuri.org/IService/GetAllActivitiesResponse")]
        System.Threading.Tasks.Task<WpfMaps.ServiceReference1.ActivityInfo[]> GetAllActivitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMyActivities", ReplyAction="http://tempuri.org/IService/GetMyActivitiesResponse")]
        WpfMaps.ServiceReference1.ActivityInfo[] GetMyActivities(WpfMaps.ServiceReference1.TokenInfo token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMyActivities", ReplyAction="http://tempuri.org/IService/GetMyActivitiesResponse")]
        System.Threading.Tasks.Task<WpfMaps.ServiceReference1.ActivityInfo[]> GetMyActivitiesAsync(WpfMaps.ServiceReference1.TokenInfo token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActivityTypes", ReplyAction="http://tempuri.org/IService/GetActivityTypesResponse")]
        string[] GetActivityTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActivityTypes", ReplyAction="http://tempuri.org/IService/GetActivityTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetActivityTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WpfMaps.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WpfMaps.ServiceReference1.IService>, WpfMaps.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SignUp(WpfMaps.ServiceReference1.UserInfo user, string Password) {
            base.Channel.SignUp(user, Password);
        }
        
        public System.Threading.Tasks.Task SignUpAsync(WpfMaps.ServiceReference1.UserInfo user, string Password) {
            return base.Channel.SignUpAsync(user, Password);
        }
        
        public void SendCode(string Email) {
            base.Channel.SendCode(Email);
        }
        
        public System.Threading.Tasks.Task SendCodeAsync(string Email) {
            return base.Channel.SendCodeAsync(Email);
        }
        
        public string ConfirmEmail(string Email, string code) {
            return base.Channel.ConfirmEmail(Email, code);
        }
        
        public System.Threading.Tasks.Task<string> ConfirmEmailAsync(string Email, string code) {
            return base.Channel.ConfirmEmailAsync(Email, code);
        }
        
        public WpfMaps.ServiceReference1.CountryInfo[] GetListCountries() {
            return base.Channel.GetListCountries();
        }
        
        public System.Threading.Tasks.Task<WpfMaps.ServiceReference1.CountryInfo[]> GetListCountriesAsync() {
            return base.Channel.GetListCountriesAsync();
        }
        
        public WpfMaps.ServiceReference1.CityInfo[] GetListCities() {
            return base.Channel.GetListCities();
        }
        
        public System.Threading.Tasks.Task<WpfMaps.ServiceReference1.CityInfo[]> GetListCitiesAsync() {
            return base.Channel.GetListCitiesAsync();
        }
        
        public WpfMaps.ServiceReference1.TokenInfo SignIn(string Email, string Password) {
            return base.Channel.SignIn(Email, Password);
        }
        
        public System.Threading.Tasks.Task<WpfMaps.ServiceReference1.TokenInfo> SignInAsync(string Email, string Password) {
            return base.Channel.SignInAsync(Email, Password);
        }
        
        public void CreateActivity(WpfMaps.ServiceReference1.ActivityInfo activity, WpfMaps.ServiceReference1.TokenInfo token) {
            base.Channel.CreateActivity(activity, token);
        }
        
        public System.Threading.Tasks.Task CreateActivityAsync(WpfMaps.ServiceReference1.ActivityInfo activity, WpfMaps.ServiceReference1.TokenInfo token) {
            return base.Channel.CreateActivityAsync(activity, token);
        }
        
        public WpfMaps.ServiceReference1.ActivityInfo[] GetAllActivities() {
            return base.Channel.GetAllActivities();
        }
        
        public System.Threading.Tasks.Task<WpfMaps.ServiceReference1.ActivityInfo[]> GetAllActivitiesAsync() {
            return base.Channel.GetAllActivitiesAsync();
        }
        
        public WpfMaps.ServiceReference1.ActivityInfo[] GetMyActivities(WpfMaps.ServiceReference1.TokenInfo token) {
            return base.Channel.GetMyActivities(token);
        }
        
        public System.Threading.Tasks.Task<WpfMaps.ServiceReference1.ActivityInfo[]> GetMyActivitiesAsync(WpfMaps.ServiceReference1.TokenInfo token) {
            return base.Channel.GetMyActivitiesAsync(token);
        }
        
        public string[] GetActivityTypes() {
            return base.Channel.GetActivityTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetActivityTypesAsync() {
            return base.Channel.GetActivityTypesAsync();
        }
    }
}
