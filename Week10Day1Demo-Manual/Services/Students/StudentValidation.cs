using System;
using Week10Day1Demo.Models;

namespace Week10Day1Demo.Services.Students
{
    public class StudentValidation
    {
        public bool CheckAgePercentageLimit(Student student)
        {
            return student.DateOfBirth >= DateTime.Now.AddYears(-20) || student.Percentage > 0.50;
        }
    }
}
