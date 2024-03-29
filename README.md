# Flipt gRPC .NET

[![Nuget](https://img.shields.io/nuget/v/flipt.grpc)](https://www.nuget.org/packages/Flipt.gRPC/)
![hardening](https://img.shields.io/badge/status-hardening-orange)

The official .NET [gRPC](https://grpc.io/) client for [Flipt](https://github.com/flipt-io/flipt).

## Installation

```shell
dotnet add package Flipt.gRPC --version 0.x.x
```

## Usage Example

```csharp
using Grpc.Net.Client;
using Flipt;

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
```

## Running

1. Run flipt server

   `$ docker run --rm -p 8080:8080 -p 9000:9000 flipt/flipt:latest`
2. Open the UI at localhost:8080 and create some flags
3. `cd examples/Basic`
4. `dotnet run`

## Contributing

Bug reports and pull requests are welcome on GitHub at [https://github.com/flipt-io/flipt-grpc-dotnet](https://github.com/flipt-io/flipt-grpc-dotnet).

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).
