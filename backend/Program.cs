var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("hellous/", HelloMethod);

app.Run();

string HelloMethod()
{
    var message = System.IO.File.ReadAllText("./hello.txt");

    return message;
}
