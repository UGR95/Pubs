﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pubs.WCFPubs {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleUsuario", Namespace="http://schemas.datacontract.org/2004/07/WcfSPubs.Fachada")]
    [System.SerializableAttribute()]
    public partial class DetalleUsuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreUsuarioField;
        
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
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EsAdmin {
            get {
                return this.EsAdminField;
            }
            set {
                if ((this.EsAdminField.Equals(value) != true)) {
                    this.EsAdminField = value;
                    this.RaisePropertyChanged("EsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreUsuario {
            get {
                return this.NombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreUsuarioField, value) != true)) {
                    this.NombreUsuarioField = value;
                    this.RaisePropertyChanged("NombreUsuario");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleVistaAutores", Namespace="http://schemas.datacontract.org/2004/07/WcfSPubs.Fachada")]
    [System.SerializableAttribute()]
    public partial class DetalleVistaAutores : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoPostalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContratoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdAutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoPostal {
            get {
                return this.CodigoPostalField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoPostalField, value) != true)) {
                    this.CodigoPostalField = value;
                    this.RaisePropertyChanged("CodigoPostal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Contrato {
            get {
                return this.ContratoField;
            }
            set {
                if ((this.ContratoField.Equals(value) != true)) {
                    this.ContratoField = value;
                    this.RaisePropertyChanged("Contrato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdAutor {
            get {
                return this.IdAutorField;
            }
            set {
                if ((object.ReferenceEquals(this.IdAutorField, value) != true)) {
                    this.IdAutorField = value;
                    this.RaisePropertyChanged("IdAutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeError {
            get {
                return this.MensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeErrorField, value) != true)) {
                    this.MensajeErrorField = value;
                    this.RaisePropertyChanged("MensajeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleTitulos", Namespace="http://schemas.datacontract.org/2004/07/WcfSPubs.Fachada")]
    [System.SerializableAttribute()]
    public partial class DetalleTitulos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AnticipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaPublicacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdEditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> RegaliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoLibroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> VentasAnioField;
        
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
        public double Anticipo {
            get {
                return this.AnticipoField;
            }
            set {
                if ((this.AnticipoField.Equals(value) != true)) {
                    this.AnticipoField = value;
                    this.RaisePropertyChanged("Anticipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaPublicacion {
            get {
                return this.FechaPublicacionField;
            }
            set {
                if ((this.FechaPublicacionField.Equals(value) != true)) {
                    this.FechaPublicacionField = value;
                    this.RaisePropertyChanged("FechaPublicacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdEditorial {
            get {
                return this.IdEditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.IdEditorialField, value) != true)) {
                    this.IdEditorialField = value;
                    this.RaisePropertyChanged("IdEditorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdTitulo {
            get {
                return this.IdTituloField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTituloField, value) != true)) {
                    this.IdTituloField = value;
                    this.RaisePropertyChanged("IdTitulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nota {
            get {
                return this.NotaField;
            }
            set {
                if ((object.ReferenceEquals(this.NotaField, value) != true)) {
                    this.NotaField = value;
                    this.RaisePropertyChanged("Nota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Regalias {
            get {
                return this.RegaliasField;
            }
            set {
                if ((this.RegaliasField.Equals(value) != true)) {
                    this.RegaliasField = value;
                    this.RaisePropertyChanged("Regalias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoLibro {
            get {
                return this.TipoLibroField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoLibroField, value) != true)) {
                    this.TipoLibroField = value;
                    this.RaisePropertyChanged("TipoLibro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> VentasAnio {
            get {
                return this.VentasAnioField;
            }
            set {
                if ((this.VentasAnioField.Equals(value) != true)) {
                    this.VentasAnioField = value;
                    this.RaisePropertyChanged("VentasAnio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFPubs.IServicePubs")]
    public interface IServicePubs {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ValidaUsuario", ReplyAction="http://tempuri.org/IServicePubs/ValidaUsuarioResponse")]
        Pubs.WCFPubs.DetalleUsuario[] ValidaUsuario(string Usuario, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ValidaUsuario", ReplyAction="http://tempuri.org/IServicePubs/ValidaUsuarioResponse")]
        System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleUsuario[]> ValidaUsuarioAsync(string Usuario, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ObtenerAutores", ReplyAction="http://tempuri.org/IServicePubs/ObtenerAutoresResponse")]
        Pubs.WCFPubs.DetalleVistaAutores[] ObtenerAutores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ObtenerAutores", ReplyAction="http://tempuri.org/IServicePubs/ObtenerAutoresResponse")]
        System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleVistaAutores[]> ObtenerAutoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/InsertarAutor", ReplyAction="http://tempuri.org/IServicePubs/InsertarAutorResponse")]
        string InsertarAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/InsertarAutor", ReplyAction="http://tempuri.org/IServicePubs/InsertarAutorResponse")]
        System.Threading.Tasks.Task<string> InsertarAutorAsync(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ActualizaAutor", ReplyAction="http://tempuri.org/IServicePubs/ActualizaAutorResponse")]
        string ActualizaAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ActualizaAutor", ReplyAction="http://tempuri.org/IServicePubs/ActualizaAutorResponse")]
        System.Threading.Tasks.Task<string> ActualizaAutorAsync(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ObtenerTitluos", ReplyAction="http://tempuri.org/IServicePubs/ObtenerTitluosResponse")]
        Pubs.WCFPubs.DetalleTitulos[] ObtenerTitluos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePubs/ObtenerTitluos", ReplyAction="http://tempuri.org/IServicePubs/ObtenerTitluosResponse")]
        System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleTitulos[]> ObtenerTitluosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePubsChannel : Pubs.WCFPubs.IServicePubs, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePubsClient : System.ServiceModel.ClientBase<Pubs.WCFPubs.IServicePubs>, Pubs.WCFPubs.IServicePubs {
        
        public ServicePubsClient() {
        }
        
        public ServicePubsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePubsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePubsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePubsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Pubs.WCFPubs.DetalleUsuario[] ValidaUsuario(string Usuario, string Contrasena) {
            return base.Channel.ValidaUsuario(Usuario, Contrasena);
        }
        
        public System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleUsuario[]> ValidaUsuarioAsync(string Usuario, string Contrasena) {
            return base.Channel.ValidaUsuarioAsync(Usuario, Contrasena);
        }
        
        public Pubs.WCFPubs.DetalleVistaAutores[] ObtenerAutores() {
            return base.Channel.ObtenerAutores();
        }
        
        public System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleVistaAutores[]> ObtenerAutoresAsync() {
            return base.Channel.ObtenerAutoresAsync();
        }
        
        public string InsertarAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato) {
            return base.Channel.InsertarAutor(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }
        
        public System.Threading.Tasks.Task<string> InsertarAutorAsync(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato) {
            return base.Channel.InsertarAutorAsync(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }
        
        public string ActualizaAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato) {
            return base.Channel.ActualizaAutor(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }
        
        public System.Threading.Tasks.Task<string> ActualizaAutorAsync(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato) {
            return base.Channel.ActualizaAutorAsync(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }
        
        public Pubs.WCFPubs.DetalleTitulos[] ObtenerTitluos() {
            return base.Channel.ObtenerTitluos();
        }
        
        public System.Threading.Tasks.Task<Pubs.WCFPubs.DetalleTitulos[]> ObtenerTitluosAsync() {
            return base.Channel.ObtenerTitluosAsync();
        }
    }
}
