﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PART_INFO_Local_Ws_second
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PART_INFO_Local_Ws_second.Local_Ws_secondSoap")]
    public interface Local_Ws_secondSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GET_PART_NUM_FROM_ORDER", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GET_PART_NUM_FROM_ORDERAsync(string PO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GET_DATA_FROM_BARC_INN", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PART_INFO_Local_Ws_second.GET_DATA_FROM_BARC_INNResponseGET_DATA_FROM_BARC_INNResult> GET_DATA_FROM_BARC_INNAsync(string stor_loc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RECEIVING_TOCK_2001", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PART_INFO_Local_Ws_second.RECEIVING_TOCK_2001ResponseRECEIVING_TOCK_2001Result> RECEIVING_TOCK_2001Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/check_badge_valid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> check_badge_validAsync(string badge_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cycle_count_insert_data_to_table", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> cycle_count_insert_data_to_tableAsync(PART_INFO_Local_Ws_second.cycle_count_insert_data_to_tableData_from_bin data_from_bin, PART_INFO_Local_Ws_second.cycle_count_insert_data_to_tableData_from_sap data_from_sap, string stge_bin, string STOR_LOC, string badge_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPQsubmitToSAPT32", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> MPQsubmitToSAPT32Async(string binNo, string kanbanMaterial, string location, string badgeNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MPPsubmitToSAPT32", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> MPPsubmitToSAPT32Async(string binNo, string kanbanMaterial, string location, string badgeNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GET_MATERIAL_FROM_001", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> GET_MATERIAL_FROM_001Async(string material);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class GET_DATA_FROM_BARC_INNResponseGET_DATA_FROM_BARC_INNResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class RECEIVING_TOCK_2001ResponseRECEIVING_TOCK_2001Result
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class cycle_count_insert_data_to_tableData_from_bin
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class cycle_count_insert_data_to_tableData_from_sap
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface Local_Ws_secondSoapChannel : PART_INFO_Local_Ws_second.Local_Ws_secondSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Local_Ws_secondSoapClient : System.ServiceModel.ClientBase<PART_INFO_Local_Ws_second.Local_Ws_secondSoap>, PART_INFO_Local_Ws_second.Local_Ws_secondSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Local_Ws_secondSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(Local_Ws_secondSoapClient.GetBindingForEndpoint(endpointConfiguration), Local_Ws_secondSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Local_Ws_secondSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Local_Ws_secondSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Local_Ws_secondSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Local_Ws_secondSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Local_Ws_secondSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync()
        {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Threading.Tasks.Task<string> GET_PART_NUM_FROM_ORDERAsync(string PO)
        {
            return base.Channel.GET_PART_NUM_FROM_ORDERAsync(PO);
        }
        
        public System.Threading.Tasks.Task<PART_INFO_Local_Ws_second.GET_DATA_FROM_BARC_INNResponseGET_DATA_FROM_BARC_INNResult> GET_DATA_FROM_BARC_INNAsync(string stor_loc)
        {
            return base.Channel.GET_DATA_FROM_BARC_INNAsync(stor_loc);
        }
        
        public System.Threading.Tasks.Task<PART_INFO_Local_Ws_second.RECEIVING_TOCK_2001ResponseRECEIVING_TOCK_2001Result> RECEIVING_TOCK_2001Async()
        {
            return base.Channel.RECEIVING_TOCK_2001Async();
        }
        
        public System.Threading.Tasks.Task<bool> check_badge_validAsync(string badge_no)
        {
            return base.Channel.check_badge_validAsync(badge_no);
        }
        
        public System.Threading.Tasks.Task<string> cycle_count_insert_data_to_tableAsync(PART_INFO_Local_Ws_second.cycle_count_insert_data_to_tableData_from_bin data_from_bin, PART_INFO_Local_Ws_second.cycle_count_insert_data_to_tableData_from_sap data_from_sap, string stge_bin, string STOR_LOC, string badge_num)
        {
            return base.Channel.cycle_count_insert_data_to_tableAsync(data_from_bin, data_from_sap, stge_bin, STOR_LOC, badge_num);
        }
        
        public System.Threading.Tasks.Task<string> MPQsubmitToSAPT32Async(string binNo, string kanbanMaterial, string location, string badgeNum)
        {
            return base.Channel.MPQsubmitToSAPT32Async(binNo, kanbanMaterial, location, badgeNum);
        }
        
        public System.Threading.Tasks.Task<string> MPPsubmitToSAPT32Async(string binNo, string kanbanMaterial, string location, string badgeNum)
        {
            return base.Channel.MPPsubmitToSAPT32Async(binNo, kanbanMaterial, location, badgeNum);
        }
        
        public System.Threading.Tasks.Task<bool> GET_MATERIAL_FROM_001Async(string material)
        {
            return base.Channel.GET_MATERIAL_FROM_001Async(material);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Local_Ws_secondSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.Local_Ws_secondSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Local_Ws_secondSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://172.16.206.19/PART_INFO/Local_Ws_second.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.Local_Ws_secondSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://172.16.206.19/PART_INFO/Local_Ws_second.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            Local_Ws_secondSoap,
            
            Local_Ws_secondSoap12,
        }
    }
}
