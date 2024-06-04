using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal abstract class Person
    {
        protected string FullName;
        protected int ID;
        protected string Department;
        protected string UserName;
        protected string Password;
        protected string Email;
        protected int PhoneNumber;

        public abstract void Register(string Username, string Password, int ID, string fullName, string email, int phoneNumber);

        public abstract void SetDepartment(string department);

        public virtual int GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public virtual string GetName()
        {
            return UserName;
        }
        public virtual string GetPassword()
        {
            return Password;
        }
        public virtual string GetDepartment()
        {
            return Department;
        }
        public virtual string GetEmail()
        {
            return Email;
        }
        public virtual string GetFullName()
        {
            return FullName;
        }
        public virtual int GetID()
        {
            return ID;
        }
    }
}