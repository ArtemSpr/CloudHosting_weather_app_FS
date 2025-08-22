var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("hellous/", GetHello);
app.MapGet("admin/", () => "We both know that u are not admin");

app.Run();

string GetHello()
{
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory()); // "Empty string to use current directory"

    var file = new FileInfo("./hello.txt");

    var filePath = file.FullName;
    var helloPath = Path.Combine(helloFolder.FullName, "hello.txt");
    var helloPath2 = Path.Combine(Directory.GetCurrentDirectory(), "hello.txt");

    Console.WriteLine($"Reading file: {filePath}");

    var message = System.IO.File.ReadAllText(helloPath);
    return message;
}

//? Deploy with
//& az webapp up --name mega-best-net24s -g test1 --location westeurope --runtime "DOTNETCORE|8.0" --sku B1 --os-type linux
