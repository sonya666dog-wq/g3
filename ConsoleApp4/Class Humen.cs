using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Human

    {
        public int Age = 17;
        public string Gender = "мужской";
        public string FirstName = "Никита";
        public string LastName = "Туркин";
        public string MiddleName = "Юрьевич";


        public void ShowAllInfo()
        {
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Отчество: {MiddleName}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Пол: {Gender}");
            Console.WriteLine($"ФИО: {FIO()}");
           
        }

        public string FIO()
        {
            string firstInitial = FirstName.Substring(0, 1);
            string middleInitial = MiddleName.Substring(0, 1);
            return $"{LastName} {firstInitial}.{middleInitial}.";
        }
    }
}


       

    


