using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private readonly string _age;
        private int _health;

        public Cat(string age, int health, CatColor color)
        {
            _age = age;
            _health = health;
            Color = color;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Имя задается однократно!");
                }               
            }
        }

        public string Age => _age;

        public CatColor Color { get; set; }


        public string CurrentColor(CatColor color)
        {

                if (_health < 5)
                {
                    return color.SickColor;
                }
                else
                {
                    return color.HealtyColor;
                }
   
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }
    }

    public class CatColor
    {

        public string HealtyColor { get; set; }

        public string SickColor { get; set; }
    }
}
