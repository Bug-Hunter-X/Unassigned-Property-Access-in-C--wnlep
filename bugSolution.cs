public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Or any desired initial value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now the output will be 0 (or the initial value set in constructor)
        MyProperty = 5;
    }
}