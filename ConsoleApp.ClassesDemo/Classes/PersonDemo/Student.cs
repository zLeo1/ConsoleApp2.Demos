﻿using ConsoleApp.ClassesDemo.Util;
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("STU");
        }
    }
}
