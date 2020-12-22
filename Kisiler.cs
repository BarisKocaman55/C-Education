using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kisiler
    {
        private string name;
        private string surname;
        private int age;
        private char gender;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSuname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        public char getGender()
        {
            return this.gender;
        }

        public void toString()
        {
            Console.WriteLine(this.name + " " + this.surname + " " + this.age + " " + this.gender);
        }
    }
}
