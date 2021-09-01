using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class PolymotphismAcademy
    {
        static void Main()
        {
            Console.WriteLine("Введите номер ключа pro или exp \nЕсли Хотите воспользоваться беслатной версией просто нажмите на Enter");
            string key = Console.ReadLine();
            DocumentWorker document = null;

            switch (key)
            {
                case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                case "":
                    document = new DocumentWorker();
                    break;
                default:
                    break;
            }


            // Первый варинт вывода текста в терминал
            Console.WriteLine("Первый варинт вывода текста в терминал");
            Console.Write('\n');
            if (key == "pro")
            {
                document.EditDocument();
                document.SaveDocument();
            }
            else if (key == "exp")
            {
                document.SaveDocument();
            }
            else
            {
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }

            Console.WriteLine('\n');

            // Второй варинт вывода текста в терминал
            Console.WriteLine("Второй варинт вывода текста в терминал");
            Console.Write('\n');
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}