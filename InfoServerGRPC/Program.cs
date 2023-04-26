using InfoServerGRPC;
using Grpc.AspNetCore.Server;
using Grpc.AspNetCore.Web;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8315);
    options.ListenAnyIP(2446, listenOptions =>
    {
        listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
    });
});
// Add services to the container.


builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGrpcService<InfoServerGRPCImpl>();

app.Run();
