using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    abstract class AbstractPerson
    {
        protected int _Id;
        protected string _Name;
        protected int _Age;
        public char _Gender;
        protected int _PhoneNumber;
        protected string _Email;
        protected string _Adress;
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }    
        public abstract int PhoneNumber { get; set; }
        public abstract string Email { get; set; }
        public abstract string Adress { get; set; }

        public abstract string Gender(char _Gender);
        public abstract void PrintInfo();

        public string showInfo()
        {
            return$"The name is: {Name}, age is: {Age}, gender is: {Gender(_Gender)}, phone is: {PhoneNumber}, email is: {Email}, adress is: {Adress} ";
        }
        //return $"{Id } - {Name} - {Age} ";
    

    }
}
