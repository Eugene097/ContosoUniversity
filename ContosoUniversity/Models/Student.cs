using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name ="Имя")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Фамилия")]
        public string FirstMidName { get; set; }
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}