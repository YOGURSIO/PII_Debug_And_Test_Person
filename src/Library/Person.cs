using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        private string name;

        private string id;

        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 1900)
                {
                    this.age = value;
                }
            }
        }       
       
        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}, ademas naci en el año {this.age}");
        }
    }
}
