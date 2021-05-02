using System;


namespace Exercise_2
{
    static class FindAndReplaceManager
    {
        public static string Text { get; set; }
        public static string Path { get; set; }
        public static Book MyBook { get; set; }
        public static int Counter { get; set; }
        
        static FindAndReplaceManager()
        {
            Console.WriteLine("Введите путь к файлу");
            Path = Console.ReadLine();
            MyBook = new Book(Path);
        }

        static public void FindNext(string text)
        {
            while ((Text = MyBook.Text.ReadLine()) != null)
            {
                int counter = 0;
                if (!Text.Contains(text))
                {
                    counter++;
                    Counter += counter;
                }
                else
                {
                    
                    counter++;
                    Counter += counter;
                    Text = text;
                    Console.WriteLine($"Найдено вхождение: {Text} на {Counter} строке");
                    
                }
             }
            Console.ReadKey();
        }

    }
}
