var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Create an instance of TestClass
TestClass testClass = new TestClass();

// Call the methods of TestClass
testClass.TestMethod();
testClass.AnotherTestMethod();

app.Run();