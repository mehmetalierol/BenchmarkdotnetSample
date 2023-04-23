using Common;
using Elastic.Apm.NetCoreAll;
using RestSample.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

LoggingExtension.ConfigureLogging();

builder.Host.UseSerilog();

var app = builder.Build();

app.UseAllElasticApm(builder.Configuration);

app.UseHttpsRedirection();

app.MapPost("/sendMessage", (MessageContent content) =>
{
    return new MessageResponse { Response = content.Body };
});

app.MapPost("/sendBigMessage", (MessageBigContent content) =>
{
    return new MessageBigResponse { 
        Response1 = content.Prop1,
        Response2 = content.Prop2,
        Response3 = content.Prop3,
        Response4 = content.Prop4,
        Response5 = content.Prop5,
        Response6 = content.Prop6,
        Response7 = content.Prop7,
        Response8 = content.Prop8,
        Response9 = content.Prop9,
        Response10 = content.Prop10,
        Response11 = content.Prop11,
        Response12 = content.Prop12,
        Response13 = content.Prop13,
        Response14 = content.Prop14,
        Response15 = content.Prop15,
        Response16 = content.Prop16,
        Response17 = content.Prop17,
        Response18 = content.Prop18,
        Response19 = content.Prop19,
        Response20 = content.Prop20
    };
});

app.Run();
