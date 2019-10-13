using System.IO;
using Aliyun.Serverless.Core;
using Microsoft.Extensions.Logging;

namespace AliyunServerless
{
    /// <summary>
    /// 打印执行日志
    /// </summary>
    public class LogHandler
    {
        public void Handle(Stream input, IFcContext context)
        {
            ILogger logger = context.Logger;
            logger.LogInformation($"Handle request: {context.RequestId}");
        }
    }
}