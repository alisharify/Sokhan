using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sokhan.Areas.Admin.Models
{
    public class Student
    {
        public Student()
        {

        }

        public int Id { get; set; }
        [Display(Name = "کد ملی")]
        public string NCode { get; set; }
        [Display(Name = "کد دانش آموزی")]
        public string SCode { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        [Display(Name = "نام پدر")]
        public string Father { get; set; }
        [Display(Name = "شماره تلفن")]
        public string Phone { get; set; }
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "فعال")]
        public bool isActive { get; set; }
    }
}
