using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Capstone
{
    internal class Exam
    {
        private string NameExam;
        private int TimeExam;
        private DateTime NowExam;
        private string Department;

        public void UploadExam(string nameExam, int timeExam,string Department)
        {
            TimeExam = timeExam;
            NameExam = nameExam;
            NowExam = DateTime.Now;
            this.Department = Department;
        }

        public string GetNameExam()
        {
            return NameExam;
        }
        public string GetDepartmentExam()
        {
            return Department;
        }
        public int GetTimeExam()
        {
            return TimeExam;
        }
        public DateTime GetNowExam()
        {
            return NowExam;
        }
    }
}
