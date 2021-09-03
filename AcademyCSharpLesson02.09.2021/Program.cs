using System;

namespace AcademyCSharpLesson02._09._2021
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
            
            Console.Write("Введите дату Публикации: ");
            var publishedText = Console.ReadLine();
            Console.Write('\n');

            var title = new Title(titleText);
            var author = new Author(authorText);
            var content = new Content(contentText);
            var published = new Published(publishedText);

            Console.WriteLine();

            Console.WriteLine($"Название книги: {title.Show()}");
            Console.ResetColor();
            Console.Write('\n');


            Console.WriteLine($"Имя Автора книги: {author.Show()}");
            Console.ResetColor();
            Console.Write('\n');

            Console.WriteLine($"Контент книги: {content.Show()}");
            Console.ResetColor();
            Console.Write('\n');
            
            Console.WriteLine($"Дата публикации книги: {published.Show()}");
            Console.ResetColor();
            Console.Write('\n');


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
    class Published
    {
        public string published;
        public Published(string published)
        {
            this.published = published;
        }
        public string Show()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return published;
        }
    }
}
