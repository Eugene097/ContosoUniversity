using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Идентификатор курса")]
        public int CourseID { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Название курса")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Кредиты")]
        public int Credits { get; set; }
        

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}