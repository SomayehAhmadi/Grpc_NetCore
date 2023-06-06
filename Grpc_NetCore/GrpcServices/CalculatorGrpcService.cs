using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Core;
using static DNZ.Calculator.GrpcServer.Protos.CalculatorService;

namespace Grpc_NetCore.GrpcServices
{
    public class CalculatorGrpcService : CalculatorServiceBase
    {
        public override Task<SumResponse> Sum(SumRequest request, ServerCallContext context)
        {
            long result = request.FirstNumber + request.SecondNumber;
            var model = new SumResponse
            {
                Result = result,
            };
            return Task.FromResult(model);
            //return base.Sum(request, context);
        }
    }
}
