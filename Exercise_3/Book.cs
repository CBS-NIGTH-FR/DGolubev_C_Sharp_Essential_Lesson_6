using System;
using System.IO;


namespace Exercise_3
{
    class Book
    {
        public StreamReader Text { get; private set; }
        public Book(string path)
        {
            using (StreamReader text_read = File.OpenText(path))
            {
                Text = text_read;
            }

        }
        public class Note
        {
            string memo = "Голубев Денис";
            public void CreateMemo(string find_text)
            {
                Console.WriteLine("Введите где ищем: ");
                string path_file = Console.ReadLine();
                string[] text = File.ReadAllLines(path_file);
                
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains(find_text))
                    {
                        string new_memo = " //  " + memo;
                        text[i] += new_memo;
                    }
                }
                using (StreamWriter book = new StreamWriter(path_file))
                {
                    string file_note = null;
                    foreach (string item in text)
                    {
                         file_note+= item + "\n";
                        
                    }
                    book.WriteLine(file_note);
                    
                }
                    Console.ReadKey();
            }
        }
    }
}
