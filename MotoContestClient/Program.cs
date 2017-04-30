using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Motocontest;
using Grpc.Core;

namespace MotoContestClient
{
    class Program
    {
        public class MotoContestClient
        {
            readonly MotoContest.MotoContestClient _client;

            public MotoContestClient(MotoContest.MotoContestClient client)
            {
                this._client = client;
            }

            public async Task Subscribe(List<Event.Types.Name> eventsNames)
            {
                var request = new SubscribeRequest
                {
                    Event = {eventsNames}
                };

                try
                {
                    using (var call = _client.Subscribe(request))
                    {
                        var responseStream = call.ResponseStream;
                        while (await responseStream.MoveNext())
                        {
                            Event e = responseStream.Current;
                            Console.WriteLine("Received event " + e.Name);
                        }
                    }
                }
                catch (RpcException e)
                {
                    Console.WriteLine("Rpc failed " + e.Message);
                    //throw;
                }
            }

            public HelloReply SayHello(string user)
            {
                return _client.SayHello(new HelloRequest
                    {
                        Name = user
                    }
                );
            }

            public HelloReply SayHelloAgain(string user)
            {
                return _client.SayHelloAgain(new HelloRequest
                {
                    Name = user
                }
                );
            }
        }

        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new MotoContestClient(
                new MotoContest.MotoContestClient(channel)
               );
            String user = "you";

            var reply = client.SayHello(user);
            Console.WriteLine("Greeting: " + reply.Message);

            var secondReply = client.SayHelloAgain(user);

            Console.WriteLine("Greeting: " + secondReply.Message);

            var events = GetIntList(args);
            
            if (events.Count <= 0)
            {
                Console.WriteLine("No events to subscribe to");
            }
            else
            {
                Console.WriteLine("Trying to subscribe to ");
                var call = client.Subscribe(events);

                events.ForEach(name => Console.WriteLine(name + " "));

                Console.WriteLine("Started waiting for events");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }

            Console.WriteLine("Finised receiving events");
            channel.ShutdownAsync().Wait(1000);
        }

        public static List<Event.Types.Name> GetIntList(string[] args)
        {
            var result = new List<Event.Types.Name>();
            for (int i = 0; i < args.Length; i++)
            {
                int val;
                if (Int32.TryParse(args[i], out val))
                {
                    Event.Types.Name eventName;
                    if (Enum.TryParse(args[i], out eventName))
                    {
                        result.Add(eventName);
                    }
                }
            }

            return result;
        }
    }
}
