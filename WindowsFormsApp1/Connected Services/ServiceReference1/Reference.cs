﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dsPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet dsPersona();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dsPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> dsPersonaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int agregarPersona(string ci, string nom, string ap, string am);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<int> agregarPersonaAsync(string ci, string nom, string ap, string am);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarDatosPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ActualizarDatosPersona(string ci, string nnom, string nap, string nam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarDatosPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ActualizarDatosPersonaAsync(string ci, string nnom, string nap, string nam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminarPersona(string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminarPersonaAsync(string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/obtenerPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet obtenerPersona(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/obtenerPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> obtenerPersonaAsync(int ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet dsPersona() {
            return base.Channel.dsPersona();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> dsPersonaAsync() {
            return base.Channel.dsPersonaAsync();
        }
        
        public int agregarPersona(string ci, string nom, string ap, string am) {
            return base.Channel.agregarPersona(ci, nom, ap, am);
        }
        
        public System.Threading.Tasks.Task<int> agregarPersonaAsync(string ci, string nom, string ap, string am) {
            return base.Channel.agregarPersonaAsync(ci, nom, ap, am);
        }
        
        public int ActualizarDatosPersona(string ci, string nnom, string nap, string nam) {
            return base.Channel.ActualizarDatosPersona(ci, nnom, nap, nam);
        }
        
        public System.Threading.Tasks.Task<int> ActualizarDatosPersonaAsync(string ci, string nnom, string nap, string nam) {
            return base.Channel.ActualizarDatosPersonaAsync(ci, nnom, nap, nam);
        }
        
        public int eliminarPersona(string ci) {
            return base.Channel.eliminarPersona(ci);
        }
        
        public System.Threading.Tasks.Task<int> eliminarPersonaAsync(string ci) {
            return base.Channel.eliminarPersonaAsync(ci);
        }
        
        public System.Data.DataSet obtenerPersona(int ci) {
            return base.Channel.obtenerPersona(ci);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> obtenerPersonaAsync(int ci) {
            return base.Channel.obtenerPersonaAsync(ci);
        }
    }
}