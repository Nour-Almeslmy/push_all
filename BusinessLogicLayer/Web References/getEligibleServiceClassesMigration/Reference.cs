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

namespace BusinessLogicLayer.getEligibleServiceClassesMigration {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MEAI_OnlineServices_2015_webServices_SelfServices_getEligibleServiceClassesMigrat" +
        "ion_WSDL_Binder", Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class getEligibleServiceClassesMigration_WSDL : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getEligibleServiceClassesMigrationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public getEligibleServiceClassesMigration_WSDL() {
            this.Url = global::BusinessLogicLayer.Properties.Settings.Default.BusinessLogicLayer_getEligibleServiceClassesMigration_getEligibleServiceClassesMigration_WSDL;
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
        public event getEligibleServiceClassesMigrationCompletedEventHandler getEligibleServiceClassesMigrationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MEAI_OnlineServices_2015_webServices_SelfServices_getEligibleServiceClassesMigrat" +
            "ion_WSDL_Binder_getEligibleServiceClassesMigration", RequestNamespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
            "igibleServiceClassesMigration_WSDL", ResponseNamespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
            "igibleServiceClassesMigration_WSDL", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getEligibleServiceClassesMigration_Output", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public getEligibleServiceClassesMigration_Output getEligibleServiceClassesMigration([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] getEligibleServiceClassesMigration_Input getEligibleServiceClassesMigration_Input) {
            object[] results = this.Invoke("getEligibleServiceClassesMigration", new object[] {
                        getEligibleServiceClassesMigration_Input});
            return ((getEligibleServiceClassesMigration_Output)(results[0]));
        }
        
        /// <remarks/>
        public void getEligibleServiceClassesMigrationAsync(getEligibleServiceClassesMigration_Input getEligibleServiceClassesMigration_Input) {
            this.getEligibleServiceClassesMigrationAsync(getEligibleServiceClassesMigration_Input, null);
        }
        
        /// <remarks/>
        public void getEligibleServiceClassesMigrationAsync(getEligibleServiceClassesMigration_Input getEligibleServiceClassesMigration_Input, object userState) {
            if ((this.getEligibleServiceClassesMigrationOperationCompleted == null)) {
                this.getEligibleServiceClassesMigrationOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEligibleServiceClassesMigrationOperationCompleted);
            }
            this.InvokeAsync("getEligibleServiceClassesMigration", new object[] {
                        getEligibleServiceClassesMigration_Input}, this.getEligibleServiceClassesMigrationOperationCompleted, userState);
        }
        
        private void OngetEligibleServiceClassesMigrationOperationCompleted(object arg) {
            if ((this.getEligibleServiceClassesMigrationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEligibleServiceClassesMigrationCompleted(this, new getEligibleServiceClassesMigrationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class getEligibleServiceClassesMigration_Input {
        
        private string dialField;
        
        private string sourceIdField;
        
        private string languageField;
        
        private string familyFlagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string dial {
            get {
                return this.dialField;
            }
            set {
                this.dialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string sourceId {
            get {
                return this.sourceIdField;
            }
            set {
                this.sourceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string familyFlag {
            get {
                return this.familyFlagField;
            }
            set {
                this.familyFlagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class errorDoc {
        
        private string statusField;
        
        private string errorCodeField;
        
        private string errorDescField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string errorDesc {
            get {
                return this.errorDescField;
            }
            set {
                this.errorDescField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class serviceClassParameters {
        
        private string serviceClassIdField;
        
        private string serviceClassNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string serviceClassId {
            get {
                return this.serviceClassIdField;
            }
            set {
                this.serviceClassIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string serviceClassName {
            get {
                return this.serviceClassNameField;
            }
            set {
                this.serviceClassNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class familyId {
        
        private string familyId1Field;
        
        private string familyNameField;
        
        private serviceClassParameters[] serviceClassParametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("familyId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string familyId1 {
            get {
                return this.familyId1Field;
            }
            set {
                this.familyId1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string familyName {
            get {
                return this.familyNameField;
            }
            set {
                this.familyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceClassParameters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public serviceClassParameters[] serviceClassParameters {
            get {
                return this.serviceClassParametersField;
            }
            set {
                this.serviceClassParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://eaidev.mobinil.com/MEAI_OnlineServices_2015/webServices/SelfServices/getEl" +
        "igibleServiceClassesMigration_WSDL")]
    public partial class getEligibleServiceClassesMigration_Output {
        
        private familyId[] familyIdField;
        
        private errorDoc errorDocField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("familyId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public familyId[] familyId {
            get {
                return this.familyIdField;
            }
            set {
                this.familyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public errorDoc errorDoc {
            get {
                return this.errorDocField;
            }
            set {
                this.errorDocField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void getEligibleServiceClassesMigrationCompletedEventHandler(object sender, getEligibleServiceClassesMigrationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEligibleServiceClassesMigrationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEligibleServiceClassesMigrationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public getEligibleServiceClassesMigration_Output Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((getEligibleServiceClassesMigration_Output)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591