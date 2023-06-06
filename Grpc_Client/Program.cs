//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Net.Client;

class Program
{
    static void Main(string[] args)
    {
        using var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001/");

        var client = new CalculatorService.CalculatorServiceClient(grpcChannel);

        SumRequest sumRequest = new()
        {
            FirstNumber = 534909,
            SecondNumber = 909800
        };

        SumResponse sumResponse = client.Sum(sumRequest);

        Console.WriteLine(sumResponse.Result);
        Console.ReadKey();
    }
}