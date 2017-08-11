using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Simulator2;

namespace Tongfang.WcfClient
{
    class Program
    {
        /// <summary>
        /// 获得FinanceService客户端
        /// </summary>
        protected static SmsServiceClient CreateSmsClient()
        {
            string url = "net.tcp://localhost:49236/TongfangSimulator/SmsService";
            EndpointAddress endpointAddress = new EndpointAddress(url);
            Binding binding = new NetTcpBinding(SecurityMode.None);
            ChannelFactory<ISmsService> channelFactory = new ChannelFactory<ISmsService>(binding, endpointAddress);
            return new SmsServiceClient(binding, endpointAddress);
        }

        static void Main(string[] args)
        {
            SmsServiceClient client = null;
            try
            {
                client = CreateSmsClient();
                client.SendSmsAsync("123456", "测试短信内容。").Wait();
            }
            catch (Exception ex)
            {
                client?.Abort();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client?.Abort();
            }

            Console.WriteLine("Hello World!");
        }
    }
}