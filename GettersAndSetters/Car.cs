using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GettersAndSetters
{
    internal class Car
    {
        //Member Variables
        private string _name;
        private int _hp;
        private string _color;

        //setter:-instead of changing the Member Variables directly, we can change it by setter method
        public void SetName(string name) 
        {
            if(name == "")
            {
                _name = "DefaultName";
            }
            else
            {
                _name = name;
            }
            
        }

        //Getter
        //:-getter needs a return type
        public string GetName()
        {
            return _name + " Car";
        }

        public int GetHp() 
        {
            //return _hp;
            return _hp * _hp;
        }


        //Constructor
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "Red";
        }

        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = "Red";
        }

        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = color;
        }

        //Member Method
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} has stopped");
        }

        public void Details()
        {
            Console.WriteLine($"My Car is {_name} of {_color} color with {_hp} horse power");
        }
    }
}
