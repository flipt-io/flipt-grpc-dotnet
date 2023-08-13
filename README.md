# flipt-grpc-dotnet

The official .NET [gRPC](https://grpc.io/) client for [Flipt](https://github.com/flipt-io/flipt).

## Installation

TODO

## Usage Example

```csharp
using Grpc.Net.Client;
using Flipt;

var channel = GrpcChannel.ForAddress("http://localhost:9000");
var client = new Flipt.Flipt.FliptClient(channel);
var result = client.ListFlags(new Flipt.ListFlagRequest());

System.Console.WriteLine("Available Flags:");
foreach (var flag in result.Flags)
{
    System.Console.WriteLine(flag.Key);
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
