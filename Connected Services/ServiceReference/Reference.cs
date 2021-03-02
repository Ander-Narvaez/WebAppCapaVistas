﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppCapaPersonas.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoPersona(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoPersonaAsync(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaPersonas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaPersonas(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaPersonas", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaPersonasAsync(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoMedico", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoMedico(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoMedico", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoMedicoAsync(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaMedicos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaMedicos(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaMedicos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaMedicosAsync(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoEmpleados", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoEmpleados(string pNif_Empleado, string pPuesto_Empleado, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoEmpleados", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoEmpleadosAsync(string pNif_Empleado, string pPuesto_Empleado, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaEmpleados", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaEmpleados(string pNif_Empleado, string pPuesto_Empleado, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaEmpleados", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaEmpleadosAsync(string pNif_Empleado, string pPuesto_Empleado, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoPacientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoPacientes(string pNif_Paciente, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoPacientes", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoPacientesAsync(string pNif_Paciente, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaPacientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaPacientes(string pNif_Paciente, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaPacientes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaPacientesAsync(string pNif_Paciente, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoHorarios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoHorarios(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoHorarios", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoHorariosAsync(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaHorarios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaHorarios(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaHorarios", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaHorariosAsync(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoVacaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MantenimientoVacaciones(string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MantenimientoVacaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MantenimientoVacacionesAsync(string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaVacaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetListaVacaciones(string pMedico, string pAccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListaVacaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetListaVacacionesAsync(string pMedico, string pAccion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WebAppCapaPersonas.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WebAppCapaPersonas.ServiceReference.WebServiceSoap>, WebAppCapaPersonas.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string MantenimientoPersona(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion) {
            return base.Channel.MantenimientoPersona(pNif, pNombre_Completo, pDireccion, pTelefono, pPoblacion, pProvincia, pCodigo_Postal, pNum_Seguridad_Social, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoPersonaAsync(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion) {
            return base.Channel.MantenimientoPersonaAsync(pNif, pNombre_Completo, pDireccion, pTelefono, pPoblacion, pProvincia, pCodigo_Postal, pNum_Seguridad_Social, pAccion);
        }
        
        public System.Data.DataSet GetListaPersonas(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion) {
            return base.Channel.GetListaPersonas(pNif, pNombre_Completo, pDireccion, pTelefono, pPoblacion, pProvincia, pCodigo_Postal, pNum_Seguridad_Social, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaPersonasAsync(string pNif, string pNombre_Completo, string pDireccion, string pTelefono, string pPoblacion, string pProvincia, string pCodigo_Postal, string pNum_Seguridad_Social, string pAccion) {
            return base.Channel.GetListaPersonasAsync(pNif, pNombre_Completo, pDireccion, pTelefono, pPoblacion, pProvincia, pCodigo_Postal, pNum_Seguridad_Social, pAccion);
        }
        
        public string MantenimientoMedico(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion) {
            return base.Channel.MantenimientoMedico(pNif_Medico, pFecha_Alta, pFecha_Baja, pNum_Colegiado, pEstatus, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoMedicoAsync(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion) {
            return base.Channel.MantenimientoMedicoAsync(pNif_Medico, pFecha_Alta, pFecha_Baja, pNum_Colegiado, pEstatus, pAccion);
        }
        
        public System.Data.DataSet GetListaMedicos(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion) {
            return base.Channel.GetListaMedicos(pNif_Medico, pFecha_Alta, pFecha_Baja, pNum_Colegiado, pEstatus, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaMedicosAsync(string pNif_Medico, string pFecha_Alta, string pFecha_Baja, string pNum_Colegiado, string pEstatus, string pAccion) {
            return base.Channel.GetListaMedicosAsync(pNif_Medico, pFecha_Alta, pFecha_Baja, pNum_Colegiado, pEstatus, pAccion);
        }
        
        public string MantenimientoEmpleados(string pNif_Empleado, string pPuesto_Empleado, string pAccion) {
            return base.Channel.MantenimientoEmpleados(pNif_Empleado, pPuesto_Empleado, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoEmpleadosAsync(string pNif_Empleado, string pPuesto_Empleado, string pAccion) {
            return base.Channel.MantenimientoEmpleadosAsync(pNif_Empleado, pPuesto_Empleado, pAccion);
        }
        
        public System.Data.DataSet GetListaEmpleados(string pNif_Empleado, string pPuesto_Empleado, string pAccion) {
            return base.Channel.GetListaEmpleados(pNif_Empleado, pPuesto_Empleado, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaEmpleadosAsync(string pNif_Empleado, string pPuesto_Empleado, string pAccion) {
            return base.Channel.GetListaEmpleadosAsync(pNif_Empleado, pPuesto_Empleado, pAccion);
        }
        
        public string MantenimientoPacientes(string pNif_Paciente, string pMedico, string pAccion) {
            return base.Channel.MantenimientoPacientes(pNif_Paciente, pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoPacientesAsync(string pNif_Paciente, string pMedico, string pAccion) {
            return base.Channel.MantenimientoPacientesAsync(pNif_Paciente, pMedico, pAccion);
        }
        
        public System.Data.DataSet GetListaPacientes(string pNif_Paciente, string pMedico, string pAccion) {
            return base.Channel.GetListaPacientes(pNif_Paciente, pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaPacientesAsync(string pNif_Paciente, string pMedico, string pAccion) {
            return base.Channel.GetListaPacientesAsync(pNif_Paciente, pMedico, pAccion);
        }
        
        public string MantenimientoHorarios(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion) {
            return base.Channel.MantenimientoHorarios(pCodigoH, pDia, pJornada, pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoHorariosAsync(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion) {
            return base.Channel.MantenimientoHorariosAsync(pCodigoH, pDia, pJornada, pMedico, pAccion);
        }
        
        public System.Data.DataSet GetListaHorarios(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion) {
            return base.Channel.GetListaHorarios(pCodigoH, pDia, pJornada, pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaHorariosAsync(string pCodigoH, string pDia, string pJornada, string pMedico, string pAccion) {
            return base.Channel.GetListaHorariosAsync(pCodigoH, pDia, pJornada, pMedico, pAccion);
        }
        
        public string MantenimientoVacaciones(string pMedico, string pAccion) {
            return base.Channel.MantenimientoVacaciones(pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<string> MantenimientoVacacionesAsync(string pMedico, string pAccion) {
            return base.Channel.MantenimientoVacacionesAsync(pMedico, pAccion);
        }
        
        public System.Data.DataSet GetListaVacaciones(string pMedico, string pAccion) {
            return base.Channel.GetListaVacaciones(pMedico, pAccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetListaVacacionesAsync(string pMedico, string pAccion) {
            return base.Channel.GetListaVacacionesAsync(pMedico, pAccion);
        }
    }
}
