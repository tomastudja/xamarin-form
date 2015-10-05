// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TodoASMX.iOS.ASMXService {
    
    
    /// <remarks/>
    [System.Web.Services.WebServiceBinding(Name="TodoServiceSoap", Namespace="http://www.xamarin.com/webservices/")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TodoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTodoItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateTodoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditTodoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTodoItemOperationCompleted;
        
        public TodoService() {
            this.Url = "http://todoasmxservice.azurewebsites.net/TodoService.asmx";
        }
        
        public TodoService(string url) {
            this.Url = url;
        }
        
        public event GetTodoItemsCompletedEventHandler GetTodoItemsCompleted;
        
        public event CreateTodoItemCompletedEventHandler CreateTodoItemCompleted;
        
        public event EditTodoItemCompletedEventHandler EditTodoItemCompleted;
        
        public event DeleteTodoItemCompletedEventHandler DeleteTodoItemCompleted;
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/GetTodoItems", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public TodoItem[] GetTodoItems() {
            object[] results = this.Invoke("GetTodoItems", new object[0]);
            return ((TodoItem[])(results[0]));
        }
        
        public System.IAsyncResult BeginGetTodoItems(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetTodoItems", new object[0], callback, asyncState);
        }
        
        public TodoItem[] EndGetTodoItems(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TodoItem[])(results[0]));
        }
        
        public void GetTodoItemsAsync() {
            this.GetTodoItemsAsync(null);
        }
        
        public void GetTodoItemsAsync(object userState) {
            if ((this.GetTodoItemsOperationCompleted == null)) {
                this.GetTodoItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTodoItemsCompleted);
            }
            this.InvokeAsync("GetTodoItems", new object[0], this.GetTodoItemsOperationCompleted, userState);
        }
        
        private void OnGetTodoItemsCompleted(object arg) {
            if ((this.GetTodoItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTodoItemsCompleted(this, new GetTodoItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/CreateTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public void CreateTodoItem(TodoItem item) {
            this.Invoke("CreateTodoItem", new object[] {
                        item});
        }
        
        public System.IAsyncResult BeginCreateTodoItem(TodoItem item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateTodoItem", new object[] {
                        item}, callback, asyncState);
        }
        
        public void EndCreateTodoItem(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        public void CreateTodoItemAsync(TodoItem item) {
            this.CreateTodoItemAsync(item, null);
        }
        
        public void CreateTodoItemAsync(TodoItem item, object userState) {
            if ((this.CreateTodoItemOperationCompleted == null)) {
                this.CreateTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateTodoItemCompleted);
            }
            this.InvokeAsync("CreateTodoItem", new object[] {
                        item}, this.CreateTodoItemOperationCompleted, userState);
        }
        
        private void OnCreateTodoItemCompleted(object arg) {
            if ((this.CreateTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/EditTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public void EditTodoItem(TodoItem item) {
            this.Invoke("EditTodoItem", new object[] {
                        item});
        }
        
        public System.IAsyncResult BeginEditTodoItem(TodoItem item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("EditTodoItem", new object[] {
                        item}, callback, asyncState);
        }
        
        public void EndEditTodoItem(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        public void EditTodoItemAsync(TodoItem item) {
            this.EditTodoItemAsync(item, null);
        }
        
        public void EditTodoItemAsync(TodoItem item, object userState) {
            if ((this.EditTodoItemOperationCompleted == null)) {
                this.EditTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditTodoItemCompleted);
            }
            this.InvokeAsync("EditTodoItem", new object[] {
                        item}, this.EditTodoItemOperationCompleted, userState);
        }
        
        private void OnEditTodoItemCompleted(object arg) {
            if ((this.EditTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/DeleteTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public void DeleteTodoItem(string id) {
            this.Invoke("DeleteTodoItem", new object[] {
                        id});
        }
        
        public System.IAsyncResult BeginDeleteTodoItem(string id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteTodoItem", new object[] {
                        id}, callback, asyncState);
        }
        
        public void EndDeleteTodoItem(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        public void DeleteTodoItemAsync(string id) {
            this.DeleteTodoItemAsync(id, null);
        }
        
        public void DeleteTodoItemAsync(string id, object userState) {
            if ((this.DeleteTodoItemOperationCompleted == null)) {
                this.DeleteTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTodoItemCompleted);
            }
            this.InvokeAsync("DeleteTodoItem", new object[] {
                        id}, this.DeleteTodoItemOperationCompleted, userState);
        }
        
        private void OnDeleteTodoItemCompleted(object arg) {
            if ((this.DeleteTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xamarin.com/webservices/")]
    public partial class TodoItem {
        
        /// <remarks/>
        public string ID;
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public string Notes;
        
        /// <remarks/>
        public bool Done;
    }
    
    public partial class GetTodoItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTodoItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public TodoItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TodoItem[])(this.results[0]));
            }
        }
    }
    
    public delegate void GetTodoItemsCompletedEventHandler(object sender, GetTodoItemsCompletedEventArgs args);
    
    public delegate void CreateTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);
    
    public delegate void EditTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);
    
    public delegate void DeleteTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);
}
