using Lab3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Group :IGroupManager
    {
        public string No { get; set; }
        public int Limit { get; set; }

        
        public Group()
        {
            Student = new Student[0];
        }
        public Student[] Student;
        public void AddStudent(Student telebe)
        {
            if(Student.Length < Limit )
            {
                Array.Resize(ref Student, Student.Length + 1);
                Student[Student.Length - 1] = telebe;


            }
            Console.WriteLine("grupda yer yoxdur");
        }

        public Student[] GetStudents()
        {
            return Student;
        }
   
        public void EditStudent(string a)
        {
            foreach (Student item in Student)
            {
                if (item.Name.Contains(a))
                {
                    Console.WriteLine("Adi deyisin");
                    item.Name = Console.ReadLine();
                    Console.WriteLine("Scoru deyisin");
                    item.Score = int.Parse(Console.ReadLine());
                    return;
                }
            }
            Console.WriteLine("tapilmadi");
        }

        public void RemoveStudent(string a)
        {
            foreach (Student item in Student)
            {
                if (item.Name.Contains(a)) 
                {
                    item.Name = null;
                }
            }
        }

        public void SearchStudents(string a)
        {
            foreach(Student item in Student)
            {
                if (item.Name.Contains(a))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
