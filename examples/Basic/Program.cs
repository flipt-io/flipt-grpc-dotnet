using Flipt;
using Grpc.Net.Client;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:9000");
            var flipt= new Flipt.Evaluation.EvaluationService.EvaluationServiceClient(channel);
            var newHotFeature = new Flipt.Evaluation.EvaluationRequest {
                        NamespaceKey = "default",
                        FlagKey      = "NewHotFeature",
                        EntityId     = "entity",
            };
            newHotFeature.Context.Add("fizz", "buzz");
            
            
            if(flipt.Variant(newHotFeature).Match)
            {
              //new code
            }
            else
            {
              //old code
            }
        }
    }
}
