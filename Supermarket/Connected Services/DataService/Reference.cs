//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermarket.DataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/DatabaseData")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Supermarket.DataService.KPI[] KPIListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Supermarket.DataService.Response.StatusEnum StatusField;
        
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
        public Supermarket.DataService.KPI[] KPIList {
            get {
                return this.KPIListField;
            }
            set {
                if ((object.ReferenceEquals(this.KPIListField, value) != true)) {
                    this.KPIListField = value;
                    this.RaisePropertyChanged("KPIList");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Supermarket.DataService.Response.StatusEnum Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="Response.StatusEnum", Namespace="http://schemas.datacontract.org/2004/07/DatabaseData")]
        public enum StatusEnum : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Success = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Fail = 1,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KPI", Namespace="http://schemas.datacontract.org/2004/07/DatabaseData.Model")]
    [System.SerializableAttribute()]
    public partial class KPI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DowmthresholdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal GoalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UpthresholdField;
        
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
        public decimal Dowmthreshold {
            get {
                return this.DowmthresholdField;
            }
            set {
                if ((this.DowmthresholdField.Equals(value) != true)) {
                    this.DowmthresholdField = value;
                    this.RaisePropertyChanged("Dowmthreshold");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Goal {
            get {
                return this.GoalField;
            }
            set {
                if ((this.GoalField.Equals(value) != true)) {
                    this.GoalField = value;
                    this.RaisePropertyChanged("Goal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Upthreshold {
            get {
                return this.UpthresholdField;
            }
            set {
                if ((this.UpthresholdField.Equals(value) != true)) {
                    this.UpthresholdField = value;
                    this.RaisePropertyChanged("Upthreshold");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataService.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetKPIS", ReplyAction="http://tempuri.org/IDataService/GetKPISResponse")]
        Supermarket.DataService.Response GetKPIS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetKPIS", ReplyAction="http://tempuri.org/IDataService/GetKPISResponse")]
        System.Threading.Tasks.Task<Supermarket.DataService.Response> GetKPISAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/CreateKPI", ReplyAction="http://tempuri.org/IDataService/CreateKPIResponse")]
        Supermarket.DataService.Response CreateKPI(Supermarket.DataService.KPI kpi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/CreateKPI", ReplyAction="http://tempuri.org/IDataService/CreateKPIResponse")]
        System.Threading.Tasks.Task<Supermarket.DataService.Response> CreateKPIAsync(Supermarket.DataService.KPI kpi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : Supermarket.DataService.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<Supermarket.DataService.IDataService>, Supermarket.DataService.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Supermarket.DataService.Response GetKPIS() {
            return base.Channel.GetKPIS();
        }
        
        public System.Threading.Tasks.Task<Supermarket.DataService.Response> GetKPISAsync() {
            return base.Channel.GetKPISAsync();
        }
        
        public Supermarket.DataService.Response CreateKPI(Supermarket.DataService.KPI kpi) {
            return base.Channel.CreateKPI(kpi);
        }
        
        public System.Threading.Tasks.Task<Supermarket.DataService.Response> CreateKPIAsync(Supermarket.DataService.KPI kpi) {
            return base.Channel.CreateKPIAsync(kpi);
        }
    }
}
