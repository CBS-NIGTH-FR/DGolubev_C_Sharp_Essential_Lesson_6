using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Note note = new Book.Note();
            Console.WriteLine("Введите что ищем: ");
            string find_text = Console.ReadLine();
            note.CreateMemo(find_text);
            Console.ReadKey();
        }
    }
}
