using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblia
{
   
    class Program
    {
        

        static void Main(string[] args)
        {
            int button;
            Console.WriteLine("Выберите 1 из вариантов:");
            Console.WriteLine("1-Показать задолжников библиотеки.");
            Console.WriteLine("2-Показать пользователей библиотеки.");
            button = Convert.ToInt32(Console.ReadLine());
            Person p1 = new Person { Name = " Мишель Обама ", Age = 0, Book = "Книга", Zad = "Задолжность = 22 дня.", Dolg = 22 };
            Person p2 = (Person)p1.Clone();
            {
                p2.Name = "Рено Логан";
                p2.Age = 122;             
                p2.Book = "Книга. Нигга+";
                p2.Zad = "Задолжность = 12 дней.";
                p2.Dolg = 0;
            }
            Person p3 = (Person)p1.Clone();
            {
                p3.Name = "Саня Крайчик";
                p3.Age = 13;
                p3.Book = "Как куколдить за 365 дней. 16+";
                p3.Zad = "Нет задолжности";
                p3.Dolg = 0;
            }
            Person p4 = (Person)p1.Clone();
            {
                p4.Name = "Нгуен Леонид";
                p4.Age = 45;
                p4.Book = "Вьетнамки 18+";
                p4.Zad = "Нет задолжности";
                p4.Dolg = 14;
            }
            if (button == 1)
            {
                Console.WriteLine("Задолжники");
                Console.WriteLine("№1:");
                Console.WriteLine("Имя: " + p1.Name);
                Console.WriteLine("Возраст: " + p1.Age);
                Console.WriteLine("Книгги: " + p1.Book);
                Console.WriteLine("Задолжность: " + p1.Zad);
                Console.WriteLine("№2:");
                Console.WriteLine("Имя: " + p2.Name);
                Console.WriteLine("Возраст: " + p2.Age);
                Console.WriteLine("Книгги: " + p2.Book);
                Console.WriteLine("Задолжность: " + p2.Zad);
            }
            else if (button == 2)
            {
                Console.WriteLine("Homie");
                Console.WriteLine("№1:");
                Console.WriteLine("Имя: " + p1.Name);
                Console.WriteLine("Возраст: " + p1.Age);
                Console.WriteLine("Книгги: " + p1.Book);
                Console.WriteLine("№2:");
                Console.WriteLine("Имя: " + p2.Name);
                Console.WriteLine("Возраст: " + p2.Age);
                Console.WriteLine("Книгги: " + p2.Book);
                Console.WriteLine("№3:");
                Console.WriteLine("Имя: " + p3.Name);
                Console.WriteLine("Возраст: " + p3.Age);
                Console.WriteLine("Книгги: " + p3.Book);
                Console.WriteLine("№4:");
                Console.WriteLine("Имя: " + p4.Name);
                Console.WriteLine("Возраст: " + p4.Age);
                Console.WriteLine("Книгги: " + p4.Book);
            }
            Console.ReadKey();
        }
    }
}
