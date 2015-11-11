using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Mita.Cat
{
    class Program
    {
        public static void ChangeCatColor(Model.Cat cat, CatColor color)
        {
            Console.WriteLine("Задайте цвет здоровой кошки: ");
            color.HealtyColor = Console.ReadLine();
            Console.WriteLine("Задайте цвет больной кошки: ");
            color.SickColor = Console.ReadLine();
            cat.Color = color;
        }
        public static void PrintMenu(Model.Cat cat)
        {
            
            Console.WriteLine("Выберите действие и введите его номер");
            Console.WriteLine("1. Покормить кошку");
            Console.WriteLine("2. Наказать кошку");
            Console.WriteLine("3. Изменить цвет кошки");
            if (cat.Name == null)
            {
                Console.WriteLine("4. Дать кошке имя");
            }
       
        }

        public static void PrintInfo(Model.Cat cat, Model.CatColor color)
        {
            if (cat.Name != null)
            {
                Console.WriteLine("Имя кошки: ");
                Console.WriteLine(cat.Name);
            }
            Console.WriteLine("Возраст кошки: ");
            Console.WriteLine(cat.Age);
            Console.WriteLine("Текущий цвет кошки");
            Console.WriteLine(cat.CurrentColor(color));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задайте возраст кошки: ");
            string age = Console.ReadLine();
            Console.WriteLine("Цвет кошки задан по умолчанию. Здоровая кошка - белая, больная - зеленая. Здоровье кошки изменяется в зависимости от ухода.");
            Console.WriteLine("Если Вы хотите изменить цвет кошки, введите 1, иначе - введите любое другое число");
            var color = new CatColor();
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Задайте цвет здоровой кошки: ");
                color.HealtyColor = Console.ReadLine();
                Console.WriteLine("Задайте цвет больной кошки: ");
                color.SickColor = Console.ReadLine();
            }
            else
            {
                color.SickColor  = "зелёный";
                color.HealtyColor = "белый";
            }
            var cat = new Model.Cat(age, 5, color);
            while (true)
            {
                PrintInfo(cat, color);
                PrintMenu(cat);
                int menu = Convert.ToInt32(Console.ReadLine());
                    if (menu == 1)
                        cat.Feed();
                    else if (menu == 2)
                        cat.Punish();
                    else if (menu == 3)
                        ChangeCatColor(cat, color);
                    else if (menu == 4)
                    {
                       Console.WriteLine("Введите имя для кошки (имя можно задать только один раз):");
                        cat.Name = Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Введено некорректное значение! Попробуйте ещё раз");
                
            }
        }
    }
}
