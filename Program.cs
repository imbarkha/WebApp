var builder = WebApplication.CreateBuilder(args);
var startup = new Startup();
startup.ConfigureServices(builder.Services);

var app = builder.Build();
var env = app.Environment;
startup.Configure(app, env);

app.Run();
