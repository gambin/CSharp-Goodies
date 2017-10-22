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

namespace GetWSData.SampleWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SampleWebServiceSoap", Namespace="http://smartbear.com")]
    public partial class SampleWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCurrentTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSampleObjectOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetSampleObjectOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetXmlDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SampleWebService() {
            this.Url = global::GetWSData.Properties.Settings.Default.GetWSData_SampleWS_SampleWebService;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event GetArrayCompletedEventHandler GetArrayCompleted;
        
        /// <remarks/>
        public event GetCurrentTimeCompletedEventHandler GetCurrentTimeCompleted;
        
        /// <remarks/>
        public event GetSampleObjectCompletedEventHandler GetSampleObjectCompleted;
        
        /// <remarks/>
        public event SetSampleObjectCompletedEventHandler SetSampleObjectCompleted;
        
        /// <remarks/>
        public event GetXmlDataCompletedEventHandler GetXmlDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/HelloWorld", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/GetArray", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int[] GetArray() {
            object[] results = this.Invoke("GetArray", new object[0]);
            return ((int[])(results[0]));
        }
        
        /// <remarks/>
        public void GetArrayAsync() {
            this.GetArrayAsync(null);
        }
        
        /// <remarks/>
        public void GetArrayAsync(object userState) {
            if ((this.GetArrayOperationCompleted == null)) {
                this.GetArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetArrayOperationCompleted);
            }
            this.InvokeAsync("GetArray", new object[0], this.GetArrayOperationCompleted, userState);
        }
        
        private void OnGetArrayOperationCompleted(object arg) {
            if ((this.GetArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetArrayCompleted(this, new GetArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/GetCurrentTime", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.DateTime GetCurrentTime() {
            object[] results = this.Invoke("GetCurrentTime", new object[0]);
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentTimeAsync() {
            this.GetCurrentTimeAsync(null);
        }
        
        /// <remarks/>
        public void GetCurrentTimeAsync(object userState) {
            if ((this.GetCurrentTimeOperationCompleted == null)) {
                this.GetCurrentTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentTimeOperationCompleted);
            }
            this.InvokeAsync("GetCurrentTime", new object[0], this.GetCurrentTimeOperationCompleted, userState);
        }
        
        private void OnGetCurrentTimeOperationCompleted(object arg) {
            if ((this.GetCurrentTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentTimeCompleted(this, new GetCurrentTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/GetSampleObject", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SampleTestClass GetSampleObject(int no) {
            object[] results = this.Invoke("GetSampleObject", new object[] {
                        no});
            return ((SampleTestClass)(results[0]));
        }
        
        /// <remarks/>
        public void GetSampleObjectAsync(int no) {
            this.GetSampleObjectAsync(no, null);
        }
        
        /// <remarks/>
        public void GetSampleObjectAsync(int no, object userState) {
            if ((this.GetSampleObjectOperationCompleted == null)) {
                this.GetSampleObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSampleObjectOperationCompleted);
            }
            this.InvokeAsync("GetSampleObject", new object[] {
                        no}, this.GetSampleObjectOperationCompleted, userState);
        }
        
        private void OnGetSampleObjectOperationCompleted(object arg) {
            if ((this.GetSampleObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSampleObjectCompleted(this, new GetSampleObjectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/SetSampleObject", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SetSampleObject(SampleTestClass obj) {
            object[] results = this.Invoke("SetSampleObject", new object[] {
                        obj});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SetSampleObjectAsync(SampleTestClass obj) {
            this.SetSampleObjectAsync(obj, null);
        }
        
        /// <remarks/>
        public void SetSampleObjectAsync(SampleTestClass obj, object userState) {
            if ((this.SetSampleObjectOperationCompleted == null)) {
                this.SetSampleObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSampleObjectOperationCompleted);
            }
            this.InvokeAsync("SetSampleObject", new object[] {
                        obj}, this.SetSampleObjectOperationCompleted, userState);
        }
        
        private void OnSetSampleObjectOperationCompleted(object arg) {
            if ((this.SetSampleObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSampleObjectCompleted(this, new SetSampleObjectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smartbear.com/GetXmlData", RequestNamespace="http://smartbear.com", ResponseNamespace="http://smartbear.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode GetXmlData() {
            object[] results = this.Invoke("GetXmlData", new object[0]);
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void GetXmlDataAsync() {
            this.GetXmlDataAsync(null);
        }
        
        /// <remarks/>
        public void GetXmlDataAsync(object userState) {
            if ((this.GetXmlDataOperationCompleted == null)) {
                this.GetXmlDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetXmlDataOperationCompleted);
            }
            this.InvokeAsync("GetXmlData", new object[0], this.GetXmlDataOperationCompleted, userState);
        }
        
        private void OnGetXmlDataOperationCompleted(object arg) {
            if ((this.GetXmlDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetXmlDataCompleted(this, new GetXmlDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smartbear.com")]
    public partial class SampleTestClass {
        
        private double xField;
        
        private double yField;
        
        private string nameField;
        
        private int[] intArrayField;
        
        /// <remarks/>
        public double X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public double Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int[] IntArray {
            get {
                return this.intArrayField;
            }
            set {
                this.intArrayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetArrayCompletedEventHandler(object sender, GetArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetCurrentTimeCompletedEventHandler(object sender, GetCurrentTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.DateTime Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetSampleObjectCompletedEventHandler(object sender, GetSampleObjectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSampleObjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSampleObjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SampleTestClass Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SampleTestClass)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SetSampleObjectCompletedEventHandler(object sender, SetSampleObjectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetSampleObjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetSampleObjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetXmlDataCompletedEventHandler(object sender, GetXmlDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetXmlDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetXmlDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591