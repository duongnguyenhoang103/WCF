﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUIDEMO.ServiceLogistic {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLogistic.IServiceLogistic")]
    public interface IServiceLogistic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/showLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/showLogisticResponse")]
        System.Data.DataTable showLogistic();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/showLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/showLogisticResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> showLogisticAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/addLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/addLogisticResponse")]
        void addLogistic(BusinesObject.BO_Logistic obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/addLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/addLogisticResponse")]
        System.Threading.Tasks.Task addLogisticAsync(BusinesObject.BO_Logistic obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/updateLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/updateLogisticResponse")]
        void updateLogistic(BusinesObject.BO_Logistic obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogistic/updateLogistic", ReplyAction="http://tempuri.org/IServiceLogistic/updateLogisticResponse")]
        System.Threading.Tasks.Task updateLogisticAsync(BusinesObject.BO_Logistic obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLogisticChannel : GUIDEMO.ServiceLogistic.IServiceLogistic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLogisticClient : System.ServiceModel.ClientBase<GUIDEMO.ServiceLogistic.IServiceLogistic>, GUIDEMO.ServiceLogistic.IServiceLogistic {
        
        public ServiceLogisticClient() {
        }
        
        public ServiceLogisticClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLogisticClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLogisticClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLogisticClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable showLogistic() {
            return base.Channel.showLogistic();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> showLogisticAsync() {
            return base.Channel.showLogisticAsync();
        }
        
        public void addLogistic(BusinesObject.BO_Logistic obj) {
            base.Channel.addLogistic(obj);
        }
        
        public System.Threading.Tasks.Task addLogisticAsync(BusinesObject.BO_Logistic obj) {
            return base.Channel.addLogisticAsync(obj);
        }
        
        public void updateLogistic(BusinesObject.BO_Logistic obj) {
            base.Channel.updateLogistic(obj);
        }
        
        public System.Threading.Tasks.Task updateLogisticAsync(BusinesObject.BO_Logistic obj) {
            return base.Channel.updateLogisticAsync(obj);
        }
    }
}
