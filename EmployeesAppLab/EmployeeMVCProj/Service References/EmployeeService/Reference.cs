﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeMVCProj.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeWcfServiceApplication")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfJoiningField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarketedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MarketingStartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TechnologyField;
        
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
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfJoining {
            get {
                return this.DateOfJoiningField;
            }
            set {
                if ((this.DateOfJoiningField.Equals(value) != true)) {
                    this.DateOfJoiningField = value;
                    this.RaisePropertyChanged("DateOfJoining");
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
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string MarketedBy {
            get {
                return this.MarketedByField;
            }
            set {
                if ((object.ReferenceEquals(this.MarketedByField, value) != true)) {
                    this.MarketedByField = value;
                    this.RaisePropertyChanged("MarketedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MarketingStartDate {
            get {
                return this.MarketingStartDateField;
            }
            set {
                if ((this.MarketingStartDateField.Equals(value) != true)) {
                    this.MarketingStartDateField = value;
                    this.RaisePropertyChanged("MarketingStartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhNo {
            get {
                return this.PhNoField;
            }
            set {
                if ((this.PhNoField.Equals(value) != true)) {
                    this.PhNoField = value;
                    this.RaisePropertyChanged("PhNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Technology {
            get {
                return this.TechnologyField;
            }
            set {
                if ((object.ReferenceEquals(this.TechnologyField, value) != true)) {
                    this.TechnologyField = value;
                    this.RaisePropertyChanged("Technology");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmploeeService")]
    public interface IEmploeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmploeeService/GetEmployeesResponse")]
        EmployeeMVCProj.EmployeeService.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmploeeService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<EmployeeMVCProj.EmployeeService.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmploeeService/GetEmployeeResponse")]
        EmployeeMVCProj.EmployeeService.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmploeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeMVCProj.EmployeeService.Employee> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/InsertEmployee", ReplyAction="http://tempuri.org/IEmploeeService/InsertEmployeeResponse")]
        void InsertEmployee(EmployeeMVCProj.EmployeeService.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/InsertEmployee", ReplyAction="http://tempuri.org/IEmploeeService/InsertEmployeeResponse")]
        System.Threading.Tasks.Task InsertEmployeeAsync(EmployeeMVCProj.EmployeeService.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmploeeService/UpdateEmployeeResponse")]
        void UpdateEmployee(EmployeeMVCProj.EmployeeService.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmploeeService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task UpdateEmployeeAsync(EmployeeMVCProj.EmployeeService.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmploeeService/DeleteEmployeeResponse")]
        void DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploeeService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmploeeService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task DeleteEmployeeAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmploeeServiceChannel : EmployeeMVCProj.EmployeeService.IEmploeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmploeeServiceClient : System.ServiceModel.ClientBase<EmployeeMVCProj.EmployeeService.IEmploeeService>, EmployeeMVCProj.EmployeeService.IEmploeeService {
        
        public EmploeeServiceClient() {
        }
        
        public EmploeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmploeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmploeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmploeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeMVCProj.EmployeeService.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<EmployeeMVCProj.EmployeeService.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public EmployeeMVCProj.EmployeeService.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeMVCProj.EmployeeService.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public void InsertEmployee(EmployeeMVCProj.EmployeeService.Employee emp) {
            base.Channel.InsertEmployee(emp);
        }
        
        public System.Threading.Tasks.Task InsertEmployeeAsync(EmployeeMVCProj.EmployeeService.Employee emp) {
            return base.Channel.InsertEmployeeAsync(emp);
        }
        
        public void UpdateEmployee(EmployeeMVCProj.EmployeeService.Employee emp) {
            base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task UpdateEmployeeAsync(EmployeeMVCProj.EmployeeService.Employee emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
        
        public void DeleteEmployee(int id) {
            base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
    }
}
