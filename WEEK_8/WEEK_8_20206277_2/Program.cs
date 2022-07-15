// Nguyễn Quang Dũng - 20206277

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WEEK_8_20206277_8_2
{
    class Request
    {
        public string name { get; set; }
        public string ip_address { get; set; }
        public string request_infor { get; set; }
        public string execution_time { get; set; }
    }
    class RequestProcessingSystem
    {
        Queue<Request> queue;
        public RequestProcessingSystem()
        {
            queue = new Queue<Request>();
        }

        public void AddToQueue(Request request)
        {
            queue.Enqueue(request);
            Thread.Sleep(1000);
            Console.WriteLine("Added to queue: " + request.name);
        }

        public void ProcessingRequest()
        {
            if (queue.Any())
            {
                var request = queue.Dequeue();
                Thread.Sleep(1000);
                Console.WriteLine("Processed request for: " + request.name);
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\tCurrent queue");
            Console.WriteLine("\t-------------");
            foreach (var request in queue)
            {
                Thread.Sleep(500);
                Console.WriteLine("\n\tName: " + request.name);
                Console.WriteLine("\n\tIP Address: " + request.ip_address);
                Console.WriteLine("\n\tRequest Information: " + request.request_infor);
                Console.WriteLine("\n\tExecution time: " + request.execution_time);
                Console.Write("\n");
                Console.WriteLine("\t-------------");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RequestProcessingSystem processingSystem = new RequestProcessingSystem();
            processingSystem.AddToQueue(new Request { name = "Request 1", ip_address = "101.15.12.11", request_infor = "Infor 1", execution_time = "5s" });
            processingSystem.AddToQueue(new Request { name = "Request 2", ip_address = "190.21.42.65", request_infor = "Infor 2", execution_time = "2s" });
            processingSystem.AddToQueue(new Request { name = "Request 3", ip_address = "291.76.56.12", request_infor = "Infor 3", execution_time = "1s" });

            Console.ReadKey();
            processingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nProcessing request started...");
            processingSystem.ProcessingRequest();
            processingSystem.ProcessingRequest();

            Console.ReadKey();
            processingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("Adding more requests to the queue");
            processingSystem.AddToQueue(new Request { name = "Request 4", ip_address = "231.82.95.12", request_infor = "Infor 4", execution_time = "4s" });
            processingSystem.AddToQueue(new Request { name = "Request 5", ip_address = "834.21.25.76", request_infor = "Infor 5", execution_time = "3s" });

            Console.ReadKey();
            processingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nProcessing request started...");
            processingSystem.ProcessingRequest();
            processingSystem.ProcessingRequest();

            Console.ReadKey();
            processingSystem.ShowQueue();

            Console.ReadKey();
        }
    }
}
