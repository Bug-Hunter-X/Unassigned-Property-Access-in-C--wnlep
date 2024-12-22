public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned can lead to unexpected behavior
        Console.WriteLine(MyProperty); // This might print 0, or an arbitrary value
        MyProperty = 5;
    }
}