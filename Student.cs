using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    internal class Student:AbstractPerson
    {
        public override int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public override string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public override int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
       
        
        public override int PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public override string   Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public override string Adress {
            get { return _Adress; }
            set { _Adress = value; }
        }

        public Student(int id, string name, int age,char _gender, int phoneNumber, string email, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this._Gender = _gender;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Adress = adress;
        }

        public Student() { }
        public override string Gender(char _Gender)
        {
            if (_Gender == 'M')
                return "Male";
            else
                return "Female";
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"The name is: {Name}, age {Age}, gender is {Gender(_Gender)}, phone is {PhoneNumber}, email is {Email}, adress is {Adress} ");
        }
    }
}
