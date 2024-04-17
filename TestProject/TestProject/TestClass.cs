public class TestClass
{
    private int _unusedVariable;

    public void TestMethod()
    {
        int x;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (i == j)
                {
                    Console.WriteLine("Match found");
                }
            }
        }
    }

    public void AnotherTestMethod()
    {
        try
        {
            // Empty try block
        }
        catch
        {
            // Empty catch block
        }
    }
    
    // New method
    public void NewMethod()
    { 
        Console.WriteLine("This is a new method");
    }
}