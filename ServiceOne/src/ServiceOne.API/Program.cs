var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Test.TestMethod());

app.Run();


static class Test
{
    public static int Counter = 0;

    public static string TestMethod()
    {
        return $"{Counter++} ServiceOne API";
    }
}
