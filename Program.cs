var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AIML Deployment in develop");

app.Run();
