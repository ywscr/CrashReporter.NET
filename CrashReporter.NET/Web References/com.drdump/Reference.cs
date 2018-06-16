﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CrashReporterDotNET.com.drdump {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HttpCrashReporterReportUploader", Namespace="https://www.drdump.com/services")]
    public partial class HttpCrashReporterReportUploader : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendAnonymousReportOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendAdditionalDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public HttpCrashReporterReportUploader() {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = "http://drdump.com/Service/CrashReporterReportUploader.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendAnonymousReportCompletedEventHandler SendAnonymousReportCompleted;
        
        /// <remarks/>
        public event SendAdditionalDataCompletedEventHandler SendAdditionalDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.drdump.com/services/IdolSoftware.DoctorDump.CrashReporterGate.CrashRe" +
            "porterReportUploader/SendAnonymousReport", RequestNamespace="https://www.drdump.com/services", ResponseNamespace="https://www.drdump.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Response SendAnonymousReport([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ClientLib clientLib, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Application app, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ExceptionDescription exception) {
            object[] results = this.Invoke("SendAnonymousReport", new object[] {
                        clientLib,
                        app,
                        exception});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendAnonymousReportAsync(ClientLib clientLib, Application app, ExceptionDescription exception) {
            this.SendAnonymousReportAsync(clientLib, app, exception, null);
        }
        
        /// <remarks/>
        public void SendAnonymousReportAsync(ClientLib clientLib, Application app, ExceptionDescription exception, object userState) {
            if ((this.SendAnonymousReportOperationCompleted == null)) {
                this.SendAnonymousReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAnonymousReportOperationCompleted);
            }
            this.InvokeAsync("SendAnonymousReport", new object[] {
                        clientLib,
                        app,
                        exception}, this.SendAnonymousReportOperationCompleted, userState);
        }
        
        private void OnSendAnonymousReportOperationCompleted(object arg) {
            if ((this.SendAnonymousReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAnonymousReportCompleted(this, new SendAnonymousReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.drdump.com/services/IdolSoftware.DoctorDump.CrashReporterGate.CrashRe" +
            "porterReportUploader/SendAdditionalData", RequestNamespace="https://www.drdump.com/services", ResponseNamespace="https://www.drdump.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Response SendAdditionalData([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)] byte[] context, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DetailedExceptionDescription addInfo) {
            object[] results = this.Invoke("SendAdditionalData", new object[] {
                        context,
                        addInfo});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendAdditionalDataAsync(byte[] context, DetailedExceptionDescription addInfo) {
            this.SendAdditionalDataAsync(context, addInfo, null);
        }
        
        /// <remarks/>
        public void SendAdditionalDataAsync(byte[] context, DetailedExceptionDescription addInfo, object userState) {
            if ((this.SendAdditionalDataOperationCompleted == null)) {
                this.SendAdditionalDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAdditionalDataOperationCompleted);
            }
            this.InvokeAsync("SendAdditionalData", new object[] {
                        context,
                        addInfo}, this.SendAdditionalDataOperationCompleted, userState);
        }
        
        private void OnSendAdditionalDataOperationCompleted(object arg) {
            if ((this.SendAdditionalDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAdditionalDataCompleted(this, new SendAdditionalDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HttpsCrashReporterReportUploader", Namespace="https://www.drdump.com/services")]
    public partial class HttpsCrashReporterReportUploader : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendAnonymousReportOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendAdditionalDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public HttpsCrashReporterReportUploader() {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = "https://drdump.com/Service/CrashReporterReportUploader.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendAnonymousReportCompletedEventHandler SendAnonymousReportCompleted;
        
        /// <remarks/>
        public event SendAdditionalDataCompletedEventHandler SendAdditionalDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.drdump.com/services/IdolSoftware.DoctorDump.CrashReporterGate.CrashRe" +
            "porterReportUploader/SendAnonymousReport", RequestNamespace="https://www.drdump.com/services", ResponseNamespace="https://www.drdump.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Response SendAnonymousReport([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ClientLib clientLib, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Application app, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ExceptionDescription exception) {
            object[] results = this.Invoke("SendAnonymousReport", new object[] {
                        clientLib,
                        app,
                        exception});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendAnonymousReportAsync(ClientLib clientLib, Application app, ExceptionDescription exception) {
            this.SendAnonymousReportAsync(clientLib, app, exception, null);
        }
        
        /// <remarks/>
        public void SendAnonymousReportAsync(ClientLib clientLib, Application app, ExceptionDescription exception, object userState) {
            if ((this.SendAnonymousReportOperationCompleted == null)) {
                this.SendAnonymousReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAnonymousReportOperationCompleted);
            }
            this.InvokeAsync("SendAnonymousReport", new object[] {
                        clientLib,
                        app,
                        exception}, this.SendAnonymousReportOperationCompleted, userState);
        }
        
        private void OnSendAnonymousReportOperationCompleted(object arg) {
            if ((this.SendAnonymousReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAnonymousReportCompleted(this, new SendAnonymousReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.drdump.com/services/IdolSoftware.DoctorDump.CrashReporterGate.CrashRe" +
            "porterReportUploader/SendAdditionalData", RequestNamespace="https://www.drdump.com/services", ResponseNamespace="https://www.drdump.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Response SendAdditionalData([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)] byte[] context, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DetailedExceptionDescription addInfo) {
            object[] results = this.Invoke("SendAdditionalData", new object[] {
                        context,
                        addInfo});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendAdditionalDataAsync(byte[] context, DetailedExceptionDescription addInfo) {
            this.SendAdditionalDataAsync(context, addInfo, null);
        }
        
        /// <remarks/>
        public void SendAdditionalDataAsync(byte[] context, DetailedExceptionDescription addInfo, object userState) {
            if ((this.SendAdditionalDataOperationCompleted == null)) {
                this.SendAdditionalDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAdditionalDataOperationCompleted);
            }
            this.InvokeAsync("SendAdditionalData", new object[] {
                        context,
                        addInfo}, this.SendAdditionalDataOperationCompleted, userState);
        }
        
        private void OnSendAdditionalDataOperationCompleted(object arg) {
            if ((this.SendAdditionalDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAdditionalDataCompleted(this, new SendAdditionalDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class ClientLib {
        
        private ushort v1Field;
        
        private ushort v2Field;
        
        private ushort v3Field;
        
        private ushort v4Field;
        
        /// <remarks/>
        public ushort V1 {
            get {
                return this.v1Field;
            }
            set {
                this.v1Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V2 {
            get {
                return this.v2Field;
            }
            set {
                this.v2Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V3 {
            get {
                return this.v3Field;
            }
            set {
                this.v3Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V4 {
            get {
                return this.v4Field;
            }
            set {
                this.v4Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class DetailedExceptionDescription {
        
        private string developerMessageField;
        
        private ExceptionDescription exceptionField;
        
        private byte[] pngScreenShotField;
        
        private string userDescriptionField;
        
        private string userEmailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DeveloperMessage {
            get {
                return this.developerMessageField;
            }
            set {
                this.developerMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExceptionDescription Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] PngScreenShot {
            get {
                return this.pngScreenShotField;
            }
            set {
                this.pngScreenShotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserDescription {
            get {
                return this.userDescriptionField;
            }
            set {
                this.userDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserEmail {
            get {
                return this.userEmailField;
            }
            set {
                this.userEmailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class ExceptionDescription {
        
        private string clrVersionField;
        
        private System.DateTime crashDateField;
        
        private ExceptionInfo exceptionField;
        
        private string exceptionStringField;
        
        private string osField;
        
        private int pCIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ClrVersion {
            get {
                return this.clrVersionField;
            }
            set {
                this.clrVersionField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CrashDate {
            get {
                return this.crashDateField;
            }
            set {
                this.crashDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExceptionInfo Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ExceptionString {
            get {
                return this.exceptionStringField;
            }
            set {
                this.exceptionStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string OS {
            get {
                return this.osField;
            }
            set {
                this.osField = value;
            }
        }
        
        /// <remarks/>
        public int PCID {
            get {
                return this.pCIDField;
            }
            set {
                this.pCIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class ExceptionInfo {
        
        private int hResultField;
        
        private ExceptionInfo innerExceptionField;
        
        private string messageField;
        
        private string sourceField;
        
        private string stackTraceField;
        
        private string typeField;
        
        /// <remarks/>
        public int HResult {
            get {
                return this.hResultField;
            }
            set {
                this.hResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExceptionInfo InnerException {
            get {
                return this.innerExceptionField;
            }
            set {
                this.innerExceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StackTrace {
            get {
                return this.stackTraceField;
            }
            set {
                this.stackTraceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NeedReportResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class Response {
        
        private string clientIDField;
        
        private byte[] contextField;
        
        private int dumpGroupIDField;
        
        private bool dumpGroupIDFieldSpecified;
        
        private int dumpIDField;
        
        private bool dumpIDFieldSpecified;
        
        private byte[] garbageField;
        
        private int problemIDField;
        
        private bool problemIDFieldSpecified;
        
        private string urlToProblemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ClientID {
            get {
                return this.clientIDField;
            }
            set {
                this.clientIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
            }
        }
        
        /// <remarks/>
        public int DumpGroupID {
            get {
                return this.dumpGroupIDField;
            }
            set {
                this.dumpGroupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DumpGroupIDSpecified {
            get {
                return this.dumpGroupIDFieldSpecified;
            }
            set {
                this.dumpGroupIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int DumpID {
            get {
                return this.dumpIDField;
            }
            set {
                this.dumpIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DumpIDSpecified {
            get {
                return this.dumpIDFieldSpecified;
            }
            set {
                this.dumpIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] Garbage {
            get {
                return this.garbageField;
            }
            set {
                this.garbageField = value;
            }
        }
        
        /// <remarks/>
        public int ProblemID {
            get {
                return this.problemIDField;
            }
            set {
                this.problemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProblemIDSpecified {
            get {
                return this.problemIDFieldSpecified;
            }
            set {
                this.problemIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UrlToProblem {
            get {
                return this.urlToProblemField;
            }
            set {
                this.urlToProblemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class StopResponse : Response {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class NeedReportResponse : Response {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class ErrorResponse : Response {
        
        private string errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.drdump.com/services")]
    public partial class Application {
        
        private string appNameField;
        
        private string applicationGUIDField;
        
        private string companyNameField;
        
        private string emailField;
        
        private string mainModuleField;
        
        private ushort v1Field;
        
        private ushort v2Field;
        
        private ushort v3Field;
        
        private ushort v4Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string AppName {
            get {
                return this.appNameField;
            }
            set {
                this.appNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ApplicationGUID {
            get {
                return this.applicationGUIDField;
            }
            set {
                this.applicationGUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MainModule {
            get {
                return this.mainModuleField;
            }
            set {
                this.mainModuleField = value;
            }
        }
        
        /// <remarks/>
        public ushort V1 {
            get {
                return this.v1Field;
            }
            set {
                this.v1Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V2 {
            get {
                return this.v2Field;
            }
            set {
                this.v2Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V3 {
            get {
                return this.v3Field;
            }
            set {
                this.v3Field = value;
            }
        }
        
        /// <remarks/>
        public ushort V4 {
            get {
                return this.v4Field;
            }
            set {
                this.v4Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SendAnonymousReportCompletedEventHandler(object sender, SendAnonymousReportCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendAnonymousReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendAnonymousReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SendAdditionalDataCompletedEventHandler(object sender, SendAdditionalDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendAdditionalDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendAdditionalDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591