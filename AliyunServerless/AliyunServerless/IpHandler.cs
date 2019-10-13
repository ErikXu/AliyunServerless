using System.IO;
using System.Net;
using Aliyun.Serverless.Core;
using Microsoft.Extensions.Logging;

namespace AliyunServerless
{
    /// <summary>
    /// 打印服务器IP
    /// </summary>
    public class IpHandler
    {
        public void Handle(Stream input, IFcContext context)
        {
            ILogger logger = context.Logger;
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            logger.LogInformation($"Handle request: {context.RequestId}");

            foreach (var ipAddress in ipHostInfo.AddressList)
            {
                logger.LogInformation($"IP Address：{ipAddress}");
            }
        }
    }
}