using Common;
using Elastic.Apm.NetCoreAll;
using GrpcvsRest;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

LoggingExtension.ConfigureLogging();

builder.Host.UseSerilog();

var app = builder.Build();

app.UseAllElasticApm(builder.Configuration);

app.MapGrpcService<MessageService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();

