using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class Teacher : IPerson
    {

        public int Id { get; set; }
        public string Name { get; set ; }
        public int Age { get; set; }
        public int PhoneNumber { get ; set ; }
        public string Email { get ; set ; }
        public string Adress { get ; set; }
        public char Gender { get ; set ; }

        public Teacher(int id , string name , int age , int phoneNumber, string email, string adress, char gender)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Adress = adress;
            this.Gender = gender;
        }

        public string GenderShow(char _Gender)
        {
            if (_Gender == 'M')
                return "Male";
            else
                return "female";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The name is: {Name}, age {Age}, gender is {GenderShow(Gender)}, phone is {PhoneNumber}, email is {Email}, adress is {Adress} ");
        }
    }
}
