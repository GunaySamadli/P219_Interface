using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Services
{
    interface IGroupManager
    {
        void AddStudent(Student telebe);
        Student[] GetStudents();
        void SearchStudents(string a);
        void EditStudent(string a);
        void RemoveStudent(string a);
    }
}
