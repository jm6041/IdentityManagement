using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using Tongfang.WcfClient.Simulator;

namespace Tongfang.WcfClient
{
    /// <summary>
    /// 客服端工厂
    /// </summary>
    public class ClientFactory
    {
        /// <summary>
        /// 创建<see cref="EmailServiceClient"/>客户端
        /// </summary>
        public static EmailServiceClient CreateEmailServiceClient()
        {
            string url = "net.tcp://localhost:49236/TongfangSimulator/EmailService";
            EndpointAddress endpointAddress = new EndpointAddress(url);
            Binding binding = new NetTcpBinding(SecurityMode.None);
            return new EmailServiceClient(binding, endpointAddress);
        }

        /// <summary>
        /// 创建<see cref="SmsServiceClient"/>客户端
        /// </summary>
        public static SmsServiceClient CreateSmsServiceClient()
        {
            string url = "net.tcp://localhost:49236/TongfangSimulator/SmsService";
            EndpointAddress endpointAddress = new EndpointAddress(url);
            Binding binding = new NetTcpBinding(SecurityMode.None);
            return new SmsServiceClient(binding, endpointAddress);
        }
    }
}
