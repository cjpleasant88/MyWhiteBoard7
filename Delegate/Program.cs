using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayHello = new SayHello();
            var person = new Person();
            sayHello.SaidHello += person.onSayHello;
            sayHello.SaidHello += p => { Console.WriteLine("trying this out"); };

            sayHello.Hello("Hello World!");

            var question = new Question4<int>(4);
            question.Method<string>(4, "hello");
        }
    }

    public class Person
    {
        public void onSayHello(string message)
        {
            Console.WriteLine("Person said Hello Back");
        }
    }

    public class SayHello
    {
        public delegate void delegateMethod(string delMessgae);
        public event delegateMethod SaidHello;

        public void Hello(string message)
        {
            Console.WriteLine(message);
            onSayHello();
        }

        protected virtual void onSayHello()
        {
            if (SaidHello != null)
            {
                SaidHello("You said Hello");
            }
        }
    }

    public class Question4<T> : IDisposable
    {
        private T tField;

        public Question4(T value)
        {
            this.tField = value;
        }

        public void Method<K>(T tValue, K kValue)
        {
            Console.WriteLine($"T Value: {tValue} | K Value: {kValue}");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
