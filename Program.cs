var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AIML @ develop branch - 07302026");

app.Run();
