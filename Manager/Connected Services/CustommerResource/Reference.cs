﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager.CustommerResource {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Custommer", Namespace="http://schemas.datacontract.org/2004/07/Resource.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Custommer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDCustommerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResumeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public System.Guid IDCustommer {
            get {
                return this.IDCustommerField;
            }
            set {
                if ((this.IDCustommerField.Equals(value) != true)) {
                    this.IDCustommerField = value;
                    this.RaisePropertyChanged("IDCustommer");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resume {
            get {
                return this.ResumeField;
            }
            set {
                if ((object.ReferenceEquals(this.ResumeField, value) != true)) {
                    this.ResumeField = value;
                    this.RaisePropertyChanged("Resume");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustommerResource.ICustommerResource")]
    public interface ICustommerResource {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/GetAllCustommers", ReplyAction="http://tempuri.org/ICustommerResource/GetAllCustommersResponse")]
        Manager.CustommerResource.Custommer[] GetAllCustommers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/GetAllCustommers", ReplyAction="http://tempuri.org/ICustommerResource/GetAllCustommersResponse")]
        System.Threading.Tasks.Task<Manager.CustommerResource.Custommer[]> GetAllCustommersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/GetCustommerByID", ReplyAction="http://tempuri.org/ICustommerResource/GetCustommerByIDResponse")]
        Manager.CustommerResource.Custommer GetCustommerByID(System.Guid ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/GetCustommerByID", ReplyAction="http://tempuri.org/ICustommerResource/GetCustommerByIDResponse")]
        System.Threading.Tasks.Task<Manager.CustommerResource.Custommer> GetCustommerByIDAsync(System.Guid ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/InsertCustommer", ReplyAction="http://tempuri.org/ICustommerResource/InsertCustommerResponse")]
        void InsertCustommer(Manager.CustommerResource.Custommer custommer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/InsertCustommer", ReplyAction="http://tempuri.org/ICustommerResource/InsertCustommerResponse")]
        System.Threading.Tasks.Task InsertCustommerAsync(Manager.CustommerResource.Custommer custommer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/UpdateCustommer", ReplyAction="http://tempuri.org/ICustommerResource/UpdateCustommerResponse")]
        void UpdateCustommer(Manager.CustommerResource.Custommer custommer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/UpdateCustommer", ReplyAction="http://tempuri.org/ICustommerResource/UpdateCustommerResponse")]
        System.Threading.Tasks.Task UpdateCustommerAsync(Manager.CustommerResource.Custommer custommer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/DeleteCustommer", ReplyAction="http://tempuri.org/ICustommerResource/DeleteCustommerResponse")]
        void DeleteCustommer(System.Guid ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustommerResource/DeleteCustommer", ReplyAction="http://tempuri.org/ICustommerResource/DeleteCustommerResponse")]
        System.Threading.Tasks.Task DeleteCustommerAsync(System.Guid ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustommerResourceChannel : Manager.CustommerResource.ICustommerResource, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustommerResourceClient : System.ServiceModel.ClientBase<Manager.CustommerResource.ICustommerResource>, Manager.CustommerResource.ICustommerResource {
        
        public CustommerResourceClient() {
        }
        
        public CustommerResourceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustommerResourceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustommerResourceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustommerResourceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Manager.CustommerResource.Custommer[] GetAllCustommers() {
            return base.Channel.GetAllCustommers();
        }
        
        public System.Threading.Tasks.Task<Manager.CustommerResource.Custommer[]> GetAllCustommersAsync() {
            return base.Channel.GetAllCustommersAsync();
        }
        
        public Manager.CustommerResource.Custommer GetCustommerByID(System.Guid ID) {
            return base.Channel.GetCustommerByID(ID);
        }
        
        public System.Threading.Tasks.Task<Manager.CustommerResource.Custommer> GetCustommerByIDAsync(System.Guid ID) {
            return base.Channel.GetCustommerByIDAsync(ID);
        }
        
        public void InsertCustommer(Manager.CustommerResource.Custommer custommer) {
            base.Channel.InsertCustommer(custommer);
        }
        
        public System.Threading.Tasks.Task InsertCustommerAsync(Manager.CustommerResource.Custommer custommer) {
            return base.Channel.InsertCustommerAsync(custommer);
        }
        
        public void UpdateCustommer(Manager.CustommerResource.Custommer custommer) {
            base.Channel.UpdateCustommer(custommer);
        }
        
        public System.Threading.Tasks.Task UpdateCustommerAsync(Manager.CustommerResource.Custommer custommer) {
            return base.Channel.UpdateCustommerAsync(custommer);
        }
        
        public void DeleteCustommer(System.Guid ID) {
            base.Channel.DeleteCustommer(ID);
        }
        
        public System.Threading.Tasks.Task DeleteCustommerAsync(System.Guid ID) {
            return base.Channel.DeleteCustommerAsync(ID);
        }
    }
}
