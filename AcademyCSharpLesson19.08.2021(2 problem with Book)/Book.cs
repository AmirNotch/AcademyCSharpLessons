using System;

namespace AcademyCSharpLesson19._08._2021_2_problem_with_Book_
{
    class Book
    {
        static void Main()
        {
            Console.Write("Введите Название книги: ");
            var titleText = Console.ReadLine();
            Console.Write('\n');

            Console.Write("Введите Имя Автора книги: ");
            var authorText = Console.ReadLine();
            Console.Write('\n');

            Console.Write("Введите контент книги: ");
            var contentText = Console.ReadLine();
            Console.Write('\n');

            var title = new Title(titleText);
            var author = new Author(authorText);
            var content = new Content(contentText);

            Console.WriteLine();

            Console.WriteLine($"Название книги: {title.Show()}");
            Console.ResetColor();
            Console.Write('\n');


            Console.WriteLine($"Имя Автора книги: {author.Show()}");
            Console.ResetColor();
            Console.Write('\n');

            Console.WriteLine($"Контент книги: {content.Show()}");
            Console.ResetColor();
        }
    }
    class Title
    {
        public string title;

        public Title(string title)
        {
            this.title = title;
        }

        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return title;
        }
    }
    class Author
    {
        public string author;
        public Author(string author)
        {
            this.author = author;
        }
        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return author;
        }
    }
    class Content
    {
        public string content;
        public Content(string content)
        {
            this.content = content;
        }
        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return content;
        }
    }
}
