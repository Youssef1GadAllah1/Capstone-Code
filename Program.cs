using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    internal class Program
    {
        static LinkedList<Video> videos = new LinkedList<Video>();
        static LinkedList<Exam> exams = new LinkedList<Exam>();
        static LinkedList<Head> admins = new LinkedList<Head>();
        static LinkedList<Manager> Managers = new LinkedList<Manager>();
        static LinkedList<Trainee> Trainees = new LinkedList<Trainee>();
        static LinkedList<string> Departments = new LinkedList<string>();
        static void Heads()
        {
            Console.WriteLine("1:For Create Account");
            Console.WriteLine("2:For Login");
            Console.WriteLine("Enter 1 or 2 ");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.Write("User Name:");
                    string UserName = Console.ReadLine();
                    Console.Write("Full Name:");
                    string FullName = Console.ReadLine();
                    Console.Write("Phone Number");
                    int PhoneNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Gmail");
                    string Gmail = Console.ReadLine();
                    
                    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    bool isValid = Regex.IsMatch(Gmail, pattern);
                    
                    if (isValid)
                    {

                        Console.WriteLine("Valid email address.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid email address.");
                        break;
                    }
                    Console.Write("Enter city: ");
                    string City = Console.ReadLine();
                    Console.Write("Password:");
                         string Password = Console.ReadLine();
                    if (Password.Length >= 6)
                    {
                        Console.WriteLine("Password is valid.");

                    }
                    else
                    {
                        Console.WriteLine("Password should be 6 characters or more.");
                        break;
                    }
                        Console.WriteLine("Account created successfully!");
                    Head admin = new Head();
                    admin.Register(UserName,Password,ID,FullName,Gmail, PhoneNumber);
                    admins.AddLast(admin);
                    break;
                case 2:
                    Console.Write("User Name:");
                    string UserName1 = Console.ReadLine();
                    Console.Write("ID:");
                    int ID1 = int.Parse(Console.ReadLine());
                    Console.Write("Gmail");
                    string Gmail1 = Console.ReadLine();
                    string pattern1 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                    bool isValid1 = Regex.IsMatch(Gmail1, pattern1);


                    if (isValid1)
                    {
                        Console.WriteLine("Valid email address.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid email address.");
                        break;
                    }

                    Console.Write("Password:");
                    string Password1 = Console.ReadLine();
                    if (Password1.Length >= 6)
                    {
                        Console.WriteLine("Password is valid.");

                    }
                    else
                    {
                        Console.WriteLine("Password should be 6 characters or more.");
                    }
                    bool ISFound = false;
                    foreach (Head Heads in admins)
                    {
                        if (Heads.GetName() == UserName1 && Heads.GetPassword() == Password1&&Heads.GetEmail()==Gmail1&&Heads.GetID()==ID1)
                        {
                            ISFound = true;
                        }

                    }
                    if (ISFound == true)
                    {
                        Console.WriteLine("1:For Add Video ");
                        Console.WriteLine("2:For Remove Video");
                        Console.WriteLine("3:For Add Exam");
                        Console.WriteLine("4:For Remove Exam");
                        Console.WriteLine("5:For Add Trainee ");
                        Console.WriteLine("6:For Remove Trainee");
                        int Chooses = int.Parse(Console.ReadLine());
                        switch (Chooses)
                        {
                            case 1:
                                Console.Write("Enter Name video:");
                                string NameVideo = Console.ReadLine();
                                Console.Write("Enter Time video:");
                                int TimeVideo = int.Parse(Console.ReadLine());
                                foreach(string Depart in Departments)
                                {
                                    Console.WriteLine($"Name:{Depart}");
                                }
                                Console.Write("Enter Department");
                                string Department = Console.ReadLine();
                                Video NewVideo = new Video();
                                NewVideo.UploadVideo(NameVideo, TimeVideo,Department);
                                videos.AddLast(NewVideo);
                                break;
                            case 2:
                                foreach (Video video in videos)
                                {
                                    Console.WriteLine($"The Name Video:{video.GetNameVideo()}, Time Video:{video.GetTimeVideo()}, Time is Upload Video:{video.GetNowVideo()}, Department:{video.GetDepartmentVideo()}.");
                                }

                                Console.WriteLine("Enter Name video");
                                string NameVideo1 = Console.ReadLine();
                                Console.WriteLine("Enter Time video");
                                int TimeVideo1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Department");
                                string Department1 = Console.ReadLine();
                                Video NewVideo1 = new Video();
                                bool IsFound = false;
                                foreach (Video video in videos)
                                {
                                    if (NameVideo1 == video.GetNameVideo()&&Department1 ==video.GetDepartmentVideo())
                                    {
                                        IsFound = true;
                                        NewVideo1 = video;
                                    }

                                }
                                if (IsFound == true)
                                {
                                    videos.Remove(NewVideo1);
                                }
                                break;

                            case 3:
                                Console.WriteLine("Enter Name Exam");
                                string NameExam = Console.ReadLine();
                                Console.WriteLine("Enter Time Exam");
                                int TimeExam = int.Parse(Console.ReadLine());
                                foreach(string depart in Departments)
                                {
                                    Console.WriteLine(depart);
                                }
                                Console.Write("Enter department: ");
                                string department = Console.ReadLine();
                                Exam exam = new Exam();
                                exam.UploadExam(NameExam, TimeExam,department);
                                exams.AddLast(exam);
                                break;
                            case 4:
                                Console.WriteLine("Enter Name Exam");
                                string NameExam1 = Console.ReadLine();
                                Console.WriteLine("Enter Time Exam");
                                int TimeExam1 = int.Parse(Console.ReadLine());
                                foreach (Exam exams2 in exams)
                                {
                                    Console.WriteLine($"The Name Exam:{exams2.GetNameExam()}, Time Video:{exams2.GetTimeExam()}, Time is Upload Video:{exams2.GetTimeExam()}, Department:{exams2.GetDepartmentExam()}.");

                                }

                                Exam exam1 = new Exam();
                                bool IsFound2 = false;
                                foreach (Exam Exams in exams)
                                {
                                    if (NameExam1 == Exams.GetNameExam() && TimeExam1 == Exams.GetTimeExam())
                                    {
                                        IsFound2 = true;
                                        exam = Exams;
                                    }

                                }
                                if (IsFound2 == true)
                                {
                                    exams.Remove(exam1);
                                }
                                break;
                            case 5:
                                Trainee trainee = new Trainee();
                                Console.Write("User Name:");
                                string UserName4 = Console.ReadLine();
                                Console.Write("Full Name:");
                                string FullName4 = Console.ReadLine();
                                foreach (string depart in Departments)
                                {
                                    Console.WriteLine(depart);
                                }
                                Console.Write("Enter department: ");
                                string department1 = Console.ReadLine();
                                Console.Write("Phone Number");
                                int PhoneNumber1 = int.Parse(Console.ReadLine());
                                
                                Console.Write("ID");
                                int ID4 = int.Parse(Console.ReadLine());
                                Console.Write("Gmail");
                                string Gmail4 = Console.ReadLine();
                                Console.Write("Enter city: ");
                                string City1 = Console.ReadLine();
                                string pattern4 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                                bool isValid4 = Regex.IsMatch(Gmail4, pattern4);

                                if (isValid1)
                                {
                                    Console.WriteLine("Valid email address.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid email address.");
                                    break;
                                }

                                Console.Write("Password:");
                                string Password4 = Console.ReadLine();
                                if (Password4.Length >= 6)
                                {
                                    Console.WriteLine("Password is valid.");

                                }
                                else
                                {
                                    Console.WriteLine("Password should be 6 characters or more.");
                                    break;
                                }
                                Console.WriteLine("Account created successfully!");
                                trainee.Register(UserName4, Password4, ID4,FullName4,Gmail4,PhoneNumber1);
                                
                                
                                Console.WriteLine("Enter You Score");
                                int Score = int.Parse(Console.ReadLine());
                                trainee.SetScore(Score);
                                Trainees.AddLast(trainee);
                                break;
                            case 6:
                                Trainee trainee2 = new Trainee();
                                Console.Write("Full Name:");
                                string FullName2 = Console.ReadLine();
                                Console.Write("Enter department: ");
                                string department2 = Console.ReadLine();
                                Console.WriteLine("Enter Your ID");
                                int Id4 = int.Parse(Console.ReadLine());
                                bool IsFound3 = false;
                                foreach (Trainee trainee3 in Trainees)
                                {
                                    if (trainee3.GetID() == Id4 && trainee3.GetFullName() == FullName2 && trainee3.GetDepartment() == department2)
                                    {
                                        IsFound3 = true;
                                        trainee2 = trainee3;
                                    }
                                }
                                if (IsFound3 == true)
                                {
                                    Trainees.Remove(trainee2);

                                }
                                break;
                        }

                    }

                    break;
            }
        }
        static void Manager()
        {
            Console.WriteLine("1:For Create Account");
            Console.WriteLine("2:For Login");
            Console.WriteLine("Enter 1 or 2 ");
            int i1 = int.Parse(Console.ReadLine());

            switch (i1)
            {
                case 1:
                    Console.Write("User Name:");
                    string UserName = Console.ReadLine();
                    Console.Write("Full Name:");
                    string FullName = Console.ReadLine();
                    Console.Write("Phone Number");
                    int PhoneNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Id: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Gmail");
                    string Gmail = Console.ReadLine();
                    Console.Write("Enter department: ");
                    string department = Console.ReadLine();
                    Console.Write("Enter city: ");
                    string City = Console.ReadLine();
                    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    bool isValid = Regex.IsMatch(Gmail, pattern);

                    if (isValid)
                    {

                        Console.WriteLine("Valid email address.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid email address.");
                        break;
                    }

                    Console.Write("Password:");
                    string Password; Password = Console.ReadLine();
                    if (Password.Length >= 6)
                    {
                        Console.WriteLine("Password is valid.");

                    }
                    else
                    {
                        Console.WriteLine("Password should be 6 characters or more.");
                        break;
                    }
                    Console.WriteLine("Account created successfully!");
                    Manager manager = new Manager();
                    manager.SetDepartment(department);
                    manager.Register(UserName, Password, ID, FullName, Gmail, PhoneNumber);
                    Managers.AddLast(manager);
                    break;

                case 2:
                    Console.WriteLine("Enter Your Name");
                    string Name3 = Console.ReadLine();
                    Console.WriteLine("Enter Your ID");
                    int Id3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your Password");
                    string password3 = Console.ReadLine();
                    bool ISFound = false;
                    foreach (Manager manager1 in Managers)
                    {
                        if (manager1.GetName() == Name3 && manager1.GetID() == Id3 && manager1.GetPassword() == password3)
                        {
                            ISFound = true;
                        }

                        if (ISFound == true)
                        {
                            Console.WriteLine("1:For View Details Of Trainee ");
                            Console.WriteLine("2:For Add Score");

                            int Choose1 = int.Parse(Console.ReadLine());
                            switch (Choose1)
                            {
                                case 1:
                                    foreach (Trainee NewTrainee in Trainees)
                                    {
                                        Console.WriteLine($"Name:{NewTrainee.GetName()} ID:{NewTrainee.GetID()} Number Of Trainee:{Trainees.Count}");
                                    }
                                    break;
                                case 2:
                                    foreach (Trainee NewTrainee in Trainees)
                                    {
                                        Console.WriteLine($"Name:{NewTrainee.GetName()} ID:{NewTrainee.GetID()},Password:{NewTrainee.GetPassword()} Number Of Trainee:{Trainees.Count}");
                                    }
                                    Console.WriteLine("Enter Your Name");
                                    string Name1 = Console.ReadLine();
                                    Console.WriteLine("Enter Your ID");
                                    int Id1 = int.Parse(Console.ReadLine());
                                    bool IsFound1 = false;
                                    Trainee trainee = new Trainee();
                                    foreach (Trainee NewTrainee in Trainees)
                                    {
                                        if (NewTrainee.GetName() == Name1 && NewTrainee.GetID() == Id1)
                                        {
                                            IsFound1 = true;
                                            trainee = NewTrainee;
                                        }
                                    }
                                    if (IsFound1 == true) {
                                        Console.WriteLine("Enter Score");
                                        
                                        int score = int.Parse(Console.ReadLine());
                                        trainee.SetScore(score);
                                    }
                                    
                                    break;
                            }
                        }
                    }
                    break;
            }
        }
        static void Trainee()
        {

            Console.WriteLine("Enter Your Name");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Enter Your ID");
            int Id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Password");
            string password1 = Console.ReadLine();
            bool IsFound1 = false;
            foreach (Trainee NTrainee in Trainees)
            {
                if (NTrainee.GetName() == Name1 && NTrainee.GetID() == Id1 && NTrainee.GetPassword() == password1)
                {
                    IsFound1 = true;
                }
            }
            if (IsFound1 == true)
            {
                Console.WriteLine("1:For View Video");
                Console.WriteLine("2:For Solve Exam");
                Console.WriteLine("Enter Number 1 or 2");
                int Choose2 = int.Parse(Console.ReadLine());
                switch (Choose2)
                {
                    case 1:
                        foreach (Video video in videos)
                        {
                            Console.WriteLine($"Name:{video.GetNameVideo()} Time:{video.GetNameVideo()},Department:{video.GetDepartmentVideo()},Time Uploud:{video.GetNowVideo()}.");
                        }
                        Console.WriteLine("Enter Name Video");
                        string NameV = Console.ReadLine();
                        bool IsFound2 = false;
                        foreach (Video video in videos)
                        {
                            if (video.GetNameVideo() == NameV)
                            {
                                IsFound2 = true;
                            }
                        }
                        if (IsFound2 == true)
                        {
                            Console.WriteLine("Watched");
                        }
                        break;
                    case 2:
                        foreach (Exam Exam in exams)
                        {
                            Console.WriteLine($"Name:{Exam.GetTimeExam()} Time:{Exam.GetTimeExam()}");
                        }
                        Console.WriteLine("Enter Name Video");
                        string NameE = Console.ReadLine();
                        bool IsFoundE = false;
                        foreach (Exam Exam in exams)
                        {
                            if (Exam.GetNameExam() == NameE)
                            {
                                IsFoundE = true;
                            }
                        }
                        if (IsFoundE == true)
                        {
                            Console.WriteLine("Solved");
                        }

                        break;
                }

            }
        }

        static void AddDepartment()
        {
            Departments.AddLast("1:Digital Transformation");
            Departments.AddLast("2:Research & Development");
            Departments.AddLast("3:People Operations");
            Departments.AddLast("4:Treasury,Investment & Legal");
            Departments.AddLast("5:Developed Markets Commerical");
            Departments.AddLast("6:GCC Algeria Cluster");
            Departments.AddLast("7:Near Fast Cluster ");
            Departments.AddLast("8:Egypt Cluster");
            Departments.AddLast("9:Financial");
            Departments.AddLast("10:Regional Regulatory Affairs");
            Departments.AddLast("11:Health & Safety Compliance");


        }
        static void Login()
        {
            Console.Write("User Name:");
            string UserName = Console.ReadLine();
            Console.Write("ID:");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Gmail");
            string Gmail = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            
            bool isValid = Regex.IsMatch(Gmail, pattern);


            if (isValid)
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            Console.Write("Password:");
            string Password = Console.ReadLine();
            if (Password.Length >= 6)
            {
                Console.WriteLine("Password is valid.");

            }
            else
            {
                Console.WriteLine("Password should be 6 characters or more.");
            }
        }
        static void Create_Account()
        {
            Console.Write("User Name:");
            string UserName = Console.ReadLine();
            Console.Write("Full Name:");
            string FullName = Console.ReadLine();
            Console.Write("Enter department: ");
            string department = Console.ReadLine();
            Console.Write("Gmail");
            string Gmail = Console.ReadLine();
            Console.Write("Enter city: ");
            string City = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(Gmail, pattern);

            if (isValid)
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            Console.Write("Password:");
            string Password = Console.ReadLine();
            if (Password.Length >= 6)
            {
                Console.WriteLine("Password is valid.");

            }
            else
            {
                Console.WriteLine("Password should be 6 characters or more.");
            }
            Console.WriteLine("Account created successfully!");
        }
        static void Choose()
        {
            Console.WriteLine("1:For Head");
            Console.WriteLine("2:For Manager");
            Console.WriteLine("3:For Trainee");
            Console.WriteLine("4:For Exit");
            Console.Write("Enter 1,2,3 or 4:");
            int Choose = int.Parse(Console.ReadLine());
            switch (Choose)
            {
                case 1:
                    Heads();
                    break;
                case 2:
                    Manager();
                    break;
                case 3:
                    Trainee();
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    Environment.Exit(10);
                    break;
            }



        }
        static void Main(string[] args)
        {
            AddDepartment();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (true)
            {
                Console.WriteLine("Welcome to Trainings Warehouse!");
                Console.WriteLine("Here you can learn accurately and develop yourself in your department!");
                Choose();
              

               

            }
        }
    }
}