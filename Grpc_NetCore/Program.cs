using Grpc_NetCore.GrpcServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<CalculatorGrpcService>();
});
//app.MapGet("/", () => "Hello World!");

app.Run();
