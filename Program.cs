var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AIML in main branch - 07262026");

app.Run();
