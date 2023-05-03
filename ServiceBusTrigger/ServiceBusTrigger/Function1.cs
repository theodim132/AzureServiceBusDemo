using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusTrigger
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("create", Connection = "Endpoint=sb://my-argo.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Qrokrlyxg/QF0qLjnX3TUbhOS3UG3tE5Q+ASbGjOh54=")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
