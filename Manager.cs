using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Manager : Person
    {
        public override int GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public override string GetName()
        {
            return UserName;
        }
        public override string GetPassword()
        {
            return Password;
        }
        public override string GetDepartment()
        {
            return Department;
        }
        public override string GetEmail()
        {
            return Email;
        }
        public override string GetFullName()
        {
            return FullName;
        }
        public override int GetID()
        {
            return ID;
        }
        public override void SetDepartment(string department)
        {
            Department = department;
        }
        public override void Register(string Username, string Password, int ID, string fullName, string email, int phoneNubmer)
        {
            Email = email;
            FullName = fullName;
            UserName = Username;
            this.ID = ID;
            this.Password = Password;
            this.PhoneNumber = phoneNubmer;
        }
        /*public void View_Details()
        {
            Console.WriteLine("Trainee Name:");
            Console.WriteLine("Trainee Code:");
            Console.WriteLine("Trainee Score:");
        }*/
    }
}
