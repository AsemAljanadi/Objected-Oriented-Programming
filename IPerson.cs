using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public interface IPerson
    {
        
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        int PhoneNumber { get; set; }
        string Email { get; set; }
        string Adress { get; set; }

        char Gender { get; set; }

        string GenderShow(char _Gender);
        void PrintInfo();

        public string ShowInfo()
        {
            return $"{Id} - {Name} - {Age} - {PhoneNumber}";
        }
    }
}
