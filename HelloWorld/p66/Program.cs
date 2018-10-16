class A
{
    internal A()
    {
    }

    ~A() // finalize() 메소드
    {
        System.Console.WriteLine("A 소멸~");
    }
}

class B : A
{
    static void Main()
    {
        B a = new B(); // 소멸순서 : object -> A -> B
        System.GC.Collect();
    }
}