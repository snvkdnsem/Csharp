using System;
namespace ConsoleApplication1
{
    class Dog
    {
        public string name; // 개의 이름을 나타내는 필드
        public string gender; // 개의 성별을 나타내는 필드
        public string ownernames; // 개의 주인 이름을 나타내는 필드

        public void Bark() // 짖는 행동
        {
            Console.WriteLine("{0} : 멍멍!", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "칸";
            dog.gender = "남";
            dog.ownernames = "철수";

            dog.Bark();

            Console.WriteLine("개의 이름: {0}, 개의 성별: {1}, 개의 주인이름: {2}", dog.name, dog.gender, dog.ownernames);
        }
    }
}
