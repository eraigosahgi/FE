﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HGInetZonaPagos.ZonaVirtualServicioVerfica {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", ConfigurationName="ZonaVirtualServicioVerfica.ServiceSoap")]
    public interface ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.zonapagos.com/ws_verificar_pagos/ds_verificar_pago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse ds_verificar_pago(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.zonapagos.com/ws_verificar_pagos/ds_verificar_pago", ReplyAction="*")]
        System.IAsyncResult Beginds_verificar_pago(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request, System.AsyncCallback callback, object asyncState);
        
        HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse Endds_verificar_pago(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.zonapagos.com/ws_verificar_pagos/ds_verificar_pago_v2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response ds_verificar_pago_v2(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.zonapagos.com/ws_verificar_pagos/ds_verificar_pago_v2", ReplyAction="*")]
        System.IAsyncResult Beginds_verificar_pago_v2(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request, System.AsyncCallback callback, object asyncState);
        
        HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response Endds_verificar_pago_v2(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.zonapagos.com/ws_verificar_pagos/verificar_pago_v3", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response verificar_pago_v3(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.zonapagos.com/ws_verificar_pagos/verificar_pago_v3", ReplyAction="*")]
        System.IAsyncResult Beginverificar_pago_v3(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request, System.AsyncCallback callback, object asyncState);
        
        HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response Endverificar_pago_v3(System.IAsyncResult result);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos")]
    public partial class Respuesta : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int codigoField;
        
        private string descripcionField;
        
        private System.Data.DataSet ds_verificar_pagoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Data.DataSet ds_verificar_pago {
            get {
                return this.ds_verificar_pagoField;
            }
            set {
                this.ds_verificar_pagoField = value;
                this.RaisePropertyChanged("ds_verificar_pago");
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos")]
    public partial class pagos_v3 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string str_id_pagoField;
        
        private int int_estado_pagoField;
        
        private int int_id_forma_pagoField;
        
        private double dbl_valor_pagadoField;
        
        private string str_ticketIDField;
        
        private string str_id_claveField;
        
        private string str_id_clienteField;
        
        private string str_franquiciaField;
        
        private int int_cod_aprobacionField;
        
        private int int_codigo_servicoField;
        
        private int int_codigo_bancoField;
        
        private string str_nombre_bancoField;
        
        private string str_codigo_transaccionField;
        
        private int int_ciclo_transaccionField;
        
        private string str_campo1Field;
        
        private string str_campo2Field;
        
        private string str_campo3Field;
        
        private System.DateTime dat_fechaField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string str_id_pago {
            get {
                return this.str_id_pagoField;
            }
            set {
                this.str_id_pagoField = value;
                this.RaisePropertyChanged("str_id_pago");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int int_estado_pago {
            get {
                return this.int_estado_pagoField;
            }
            set {
                this.int_estado_pagoField = value;
                this.RaisePropertyChanged("int_estado_pago");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int int_id_forma_pago {
            get {
                return this.int_id_forma_pagoField;
            }
            set {
                this.int_id_forma_pagoField = value;
                this.RaisePropertyChanged("int_id_forma_pago");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double dbl_valor_pagado {
            get {
                return this.dbl_valor_pagadoField;
            }
            set {
                this.dbl_valor_pagadoField = value;
                this.RaisePropertyChanged("dbl_valor_pagado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string str_ticketID {
            get {
                return this.str_ticketIDField;
            }
            set {
                this.str_ticketIDField = value;
                this.RaisePropertyChanged("str_ticketID");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string str_id_clave {
            get {
                return this.str_id_claveField;
            }
            set {
                this.str_id_claveField = value;
                this.RaisePropertyChanged("str_id_clave");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string str_id_cliente {
            get {
                return this.str_id_clienteField;
            }
            set {
                this.str_id_clienteField = value;
                this.RaisePropertyChanged("str_id_cliente");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string str_franquicia {
            get {
                return this.str_franquiciaField;
            }
            set {
                this.str_franquiciaField = value;
                this.RaisePropertyChanged("str_franquicia");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int int_cod_aprobacion {
            get {
                return this.int_cod_aprobacionField;
            }
            set {
                this.int_cod_aprobacionField = value;
                this.RaisePropertyChanged("int_cod_aprobacion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int int_codigo_servico {
            get {
                return this.int_codigo_servicoField;
            }
            set {
                this.int_codigo_servicoField = value;
                this.RaisePropertyChanged("int_codigo_servico");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int int_codigo_banco {
            get {
                return this.int_codigo_bancoField;
            }
            set {
                this.int_codigo_bancoField = value;
                this.RaisePropertyChanged("int_codigo_banco");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string str_nombre_banco {
            get {
                return this.str_nombre_bancoField;
            }
            set {
                this.str_nombre_bancoField = value;
                this.RaisePropertyChanged("str_nombre_banco");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string str_codigo_transaccion {
            get {
                return this.str_codigo_transaccionField;
            }
            set {
                this.str_codigo_transaccionField = value;
                this.RaisePropertyChanged("str_codigo_transaccion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int int_ciclo_transaccion {
            get {
                return this.int_ciclo_transaccionField;
            }
            set {
                this.int_ciclo_transaccionField = value;
                this.RaisePropertyChanged("int_ciclo_transaccion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string str_campo1 {
            get {
                return this.str_campo1Field;
            }
            set {
                this.str_campo1Field = value;
                this.RaisePropertyChanged("str_campo1");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string str_campo2 {
            get {
                return this.str_campo2Field;
            }
            set {
                this.str_campo2Field = value;
                this.RaisePropertyChanged("str_campo2");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string str_campo3 {
            get {
                return this.str_campo3Field;
            }
            set {
                this.str_campo3Field = value;
                this.RaisePropertyChanged("str_campo3");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public System.DateTime dat_fecha {
            get {
                return this.dat_fechaField;
            }
            set {
                this.dat_fechaField = value;
                this.RaisePropertyChanged("dat_fecha");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ds_verificar_pago", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class ds_verificar_pagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public string id_pago;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=1)]
        public int id_tienda;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=2)]
        public string id_clave;
        
        public ds_verificar_pagoRequest() {
        }
        
        public ds_verificar_pagoRequest(string id_pago, int id_tienda, string id_clave) {
            this.id_pago = id_pago;
            this.id_tienda = id_tienda;
            this.id_clave = id_clave;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ds_verificar_pagoResponse", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class ds_verificar_pagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.Respuesta ds_verificar_pagoResult;
        
        public ds_verificar_pagoResponse() {
        }
        
        public ds_verificar_pagoResponse(HGInetZonaPagos.ZonaVirtualServicioVerfica.Respuesta ds_verificar_pagoResult) {
            this.ds_verificar_pagoResult = ds_verificar_pagoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ds_verificar_pago_v2", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class ds_verificar_pago_v2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public string id_pago;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=1)]
        public int id_tienda;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=2)]
        public string id_clave;
        
        public ds_verificar_pago_v2Request() {
        }
        
        public ds_verificar_pago_v2Request(string id_pago, int id_tienda, string id_clave) {
            this.id_pago = id_pago;
            this.id_tienda = id_tienda;
            this.id_clave = id_clave;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ds_verificar_pago_v2Response", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class ds_verificar_pago_v2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.Respuesta ds_verificar_pago_v2Result;
        
        public ds_verificar_pago_v2Response() {
        }
        
        public ds_verificar_pago_v2Response(HGInetZonaPagos.ZonaVirtualServicioVerfica.Respuesta ds_verificar_pago_v2Result) {
            this.ds_verificar_pago_v2Result = ds_verificar_pago_v2Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificar_pago_v3", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class verificar_pago_v3Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public string str_id_pago;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=1)]
        public int int_id_tienda;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=2)]
        public string str_id_clave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=3)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.pagos_v3[] res_pagos_v3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=4)]
        public int int_error;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=5)]
        public string str_error;
        
        public verificar_pago_v3Request() {
        }
        
        public verificar_pago_v3Request(string str_id_pago, int int_id_tienda, string str_id_clave, HGInetZonaPagos.ZonaVirtualServicioVerfica.pagos_v3[] res_pagos_v3, int int_error, string str_error) {
            this.str_id_pago = str_id_pago;
            this.int_id_tienda = int_id_tienda;
            this.str_id_clave = str_id_clave;
            this.res_pagos_v3 = res_pagos_v3;
            this.int_error = int_error;
            this.str_error = str_error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificar_pago_v3Response", WrapperNamespace="http://www.zonapagos.com/ws_verificar_pagos", IsWrapped=true)]
    public partial class verificar_pago_v3Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=0)]
        public int verificar_pago_v3Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=1)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.pagos_v3[] res_pagos_v3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=2)]
        public int int_error;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.zonapagos.com/ws_verificar_pagos", Order=3)]
        public string str_error;
        
        public verificar_pago_v3Response() {
        }
        
        public verificar_pago_v3Response(int verificar_pago_v3Result, HGInetZonaPagos.ZonaVirtualServicioVerfica.pagos_v3[] res_pagos_v3, int int_error, string str_error) {
            this.verificar_pago_v3Result = verificar_pago_v3Result;
            this.res_pagos_v3 = res_pagos_v3;
            this.int_error = int_error;
            this.str_error = str_error;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : HGInetZonaPagos.ZonaVirtualServicioVerfica.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ds_verificar_pagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ds_verificar_pagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ds_verificar_pago_v2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ds_verificar_pago_v2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class verificar_pago_v3CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public verificar_pago_v3CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<HGInetZonaPagos.ZonaVirtualServicioVerfica.ServiceSoap>, HGInetZonaPagos.ZonaVirtualServicioVerfica.ServiceSoap {
        
        private BeginOperationDelegate onBeginds_verificar_pagoDelegate;
        
        private EndOperationDelegate onEndds_verificar_pagoDelegate;
        
        private System.Threading.SendOrPostCallback onds_verificar_pagoCompletedDelegate;
        
        private BeginOperationDelegate onBeginds_verificar_pago_v2Delegate;
        
        private EndOperationDelegate onEndds_verificar_pago_v2Delegate;
        
        private System.Threading.SendOrPostCallback onds_verificar_pago_v2CompletedDelegate;
        
        private BeginOperationDelegate onBeginverificar_pago_v3Delegate;
        
        private EndOperationDelegate onEndverificar_pago_v3Delegate;
        
        private System.Threading.SendOrPostCallback onverificar_pago_v3CompletedDelegate;
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<ds_verificar_pagoCompletedEventArgs> ds_verificar_pagoCompleted;
        
        public event System.EventHandler<ds_verificar_pago_v2CompletedEventArgs> ds_verificar_pago_v2Completed;
        
        public event System.EventHandler<verificar_pago_v3CompletedEventArgs> verificar_pago_v3Completed;
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse ds_verificar_pago(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request) {
            return base.Channel.ds_verificar_pago(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginds_verificar_pago(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginds_verificar_pago(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse Endds_verificar_pago(System.IAsyncResult result) {
            return base.Channel.Endds_verificar_pago(result);
        }
        
        private System.IAsyncResult OnBeginds_verificar_pago(object[] inValues, System.AsyncCallback callback, object asyncState) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request = ((HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest)(inValues[0]));
            return this.Beginds_verificar_pago(request, callback, asyncState);
        }
        
        private object[] OnEndds_verificar_pago(System.IAsyncResult result) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoResponse retVal = this.Endds_verificar_pago(result);
            return new object[] {
                    retVal};
        }
        
        private void Onds_verificar_pagoCompleted(object state) {
            if ((this.ds_verificar_pagoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ds_verificar_pagoCompleted(this, new ds_verificar_pagoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ds_verificar_pagoAsync(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request) {
            this.ds_verificar_pagoAsync(request, null);
        }
        
        public void ds_verificar_pagoAsync(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pagoRequest request, object userState) {
            if ((this.onBeginds_verificar_pagoDelegate == null)) {
                this.onBeginds_verificar_pagoDelegate = new BeginOperationDelegate(this.OnBeginds_verificar_pago);
            }
            if ((this.onEndds_verificar_pagoDelegate == null)) {
                this.onEndds_verificar_pagoDelegate = new EndOperationDelegate(this.OnEndds_verificar_pago);
            }
            if ((this.onds_verificar_pagoCompletedDelegate == null)) {
                this.onds_verificar_pagoCompletedDelegate = new System.Threading.SendOrPostCallback(this.Onds_verificar_pagoCompleted);
            }
            base.InvokeAsync(this.onBeginds_verificar_pagoDelegate, new object[] {
                        request}, this.onEndds_verificar_pagoDelegate, this.onds_verificar_pagoCompletedDelegate, userState);
        }
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response ds_verificar_pago_v2(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request) {
            return base.Channel.ds_verificar_pago_v2(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginds_verificar_pago_v2(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginds_verificar_pago_v2(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response Endds_verificar_pago_v2(System.IAsyncResult result) {
            return base.Channel.Endds_verificar_pago_v2(result);
        }
        
        private System.IAsyncResult OnBeginds_verificar_pago_v2(object[] inValues, System.AsyncCallback callback, object asyncState) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request = ((HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request)(inValues[0]));
            return this.Beginds_verificar_pago_v2(request, callback, asyncState);
        }
        
        private object[] OnEndds_verificar_pago_v2(System.IAsyncResult result) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Response retVal = this.Endds_verificar_pago_v2(result);
            return new object[] {
                    retVal};
        }
        
        private void Onds_verificar_pago_v2Completed(object state) {
            if ((this.ds_verificar_pago_v2Completed != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ds_verificar_pago_v2Completed(this, new ds_verificar_pago_v2CompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ds_verificar_pago_v2Async(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request) {
            this.ds_verificar_pago_v2Async(request, null);
        }
        
        public void ds_verificar_pago_v2Async(HGInetZonaPagos.ZonaVirtualServicioVerfica.ds_verificar_pago_v2Request request, object userState) {
            if ((this.onBeginds_verificar_pago_v2Delegate == null)) {
                this.onBeginds_verificar_pago_v2Delegate = new BeginOperationDelegate(this.OnBeginds_verificar_pago_v2);
            }
            if ((this.onEndds_verificar_pago_v2Delegate == null)) {
                this.onEndds_verificar_pago_v2Delegate = new EndOperationDelegate(this.OnEndds_verificar_pago_v2);
            }
            if ((this.onds_verificar_pago_v2CompletedDelegate == null)) {
                this.onds_verificar_pago_v2CompletedDelegate = new System.Threading.SendOrPostCallback(this.Onds_verificar_pago_v2Completed);
            }
            base.InvokeAsync(this.onBeginds_verificar_pago_v2Delegate, new object[] {
                        request}, this.onEndds_verificar_pago_v2Delegate, this.onds_verificar_pago_v2CompletedDelegate, userState);
        }
        
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response verificar_pago_v3(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request) {
            return base.Channel.verificar_pago_v3(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginverificar_pago_v3(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginverificar_pago_v3(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response Endverificar_pago_v3(System.IAsyncResult result) {
            return base.Channel.Endverificar_pago_v3(result);
        }
        
        private System.IAsyncResult OnBeginverificar_pago_v3(object[] inValues, System.AsyncCallback callback, object asyncState) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request = ((HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request)(inValues[0]));
            return this.Beginverificar_pago_v3(request, callback, asyncState);
        }
        
        private object[] OnEndverificar_pago_v3(System.IAsyncResult result) {
            HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Response retVal = this.Endverificar_pago_v3(result);
            return new object[] {
                    retVal};
        }
        
        private void Onverificar_pago_v3Completed(object state) {
            if ((this.verificar_pago_v3Completed != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.verificar_pago_v3Completed(this, new verificar_pago_v3CompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void verificar_pago_v3Async(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request) {
            this.verificar_pago_v3Async(request, null);
        }
        
        public void verificar_pago_v3Async(HGInetZonaPagos.ZonaVirtualServicioVerfica.verificar_pago_v3Request request, object userState) {
            if ((this.onBeginverificar_pago_v3Delegate == null)) {
                this.onBeginverificar_pago_v3Delegate = new BeginOperationDelegate(this.OnBeginverificar_pago_v3);
            }
            if ((this.onEndverificar_pago_v3Delegate == null)) {
                this.onEndverificar_pago_v3Delegate = new EndOperationDelegate(this.OnEndverificar_pago_v3);
            }
            if ((this.onverificar_pago_v3CompletedDelegate == null)) {
                this.onverificar_pago_v3CompletedDelegate = new System.Threading.SendOrPostCallback(this.Onverificar_pago_v3Completed);
            }
            base.InvokeAsync(this.onBeginverificar_pago_v3Delegate, new object[] {
                        request}, this.onEndverificar_pago_v3Delegate, this.onverificar_pago_v3CompletedDelegate, userState);
        }
    }
}