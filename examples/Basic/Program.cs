using Flipt;
using Grpc.Net.Client;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:9000");
            var client = new Flipt.Flipt.FliptClient(channel);
            var result = client.ListFlags(new Flipt.ListFlagRequest());

            System.Console.WriteLine("Available Flags:");
            foreach (var flag in result.Flags)
            {
                System.Console.WriteLine(flag.Key);
            }
        }
    }
}
