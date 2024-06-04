using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Trainee : Person
    {
        public override int GetPhoneNumber()
        {
            return PhoneNumber;
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
        private int T_Score;
        public void SetScore(int score)
        {
            T_Score = score;
        }
        public int GetScore()
        {
            return T_Score;
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
        //static void View_Courses(){}
        //static void Solve_Quizes(){}
    }
}
