using System;

namespace MyApp 
{

    delegate void Func(string str);
    class MyClass
    {
        public void Reverse(string code)
        {
            char[] code2 = code.Reverse().ToArray();
            Console.WriteLine(code2);
        }
        public void Space(string code)
        {
            char[] s1 = code.ToCharArray();
            Console.WriteLine(string.Join("_", s1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = cls.Reverse;
            funcDell += cls.Space;
            Run run = new Run();
            run.runFunc(funcDell, str);

        }
    }
}