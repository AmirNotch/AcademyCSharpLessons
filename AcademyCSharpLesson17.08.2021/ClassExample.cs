using System;

namespace AcademyCSharpLesson17._08._2021
{
    class Company
    {
        public string name;
        public bool size;
        public bool inovation;
        public int workers;
        public string description;

        public Company(string name, bool size, bool inovation, int workers, string description)
        {
            this.name = name;
            this.size = size;
            this.inovation = inovation;
            this.workers = workers;
            this.description = description;
        }

        public void GetInfo()
        {
            if (size == true && inovation == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name: {name}, BigCompany: {size}, InovationProduct: {inovation}, Workers count: {workers}, Meaning For World: {description}");
            }
            else if (size == true || inovation == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Name: {name}, BigCompany: {size}, InovationProduct: {inovation}, Workers count: {workers}, Meaning For World: {description}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Name: {name}, BigCompany: {size}, InovationProduct: {inovation}, Workers count: {workers}, Meaning For World: {description}");
            }
            Console.ResetColor();
        }
    }
    class ClassExamples
    {
        static void Main()
        {
            Company microsoft = new Company("Microsoft", true, true, 200000, "Corporation");
            Company yandex = new Company("Yandex", false, true, 30000, "Company");
            Company lacoste = new Company("Lacoste", false, false, 50000, "BrandClothes");

            microsoft.GetInfo();
            Console.Write('\n');
            yandex.GetInfo();
            Console.Write('\n');
            lacoste.GetInfo();
        }
    }
}
