using System;

namespace console_programlama
{
    class Program 
    {
        public static void Main (string[] args)
        {
            System.Console.WriteLine("hello world");
            System.Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();

            System.Console.WriteLine("Merhaba" + name + " " + surname);

            return;

        }
    }
}