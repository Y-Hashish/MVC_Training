using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MVC_Training.Models
{
    public class Employee
    {
        public int id { get; set; }
        [DisplayName("Emp Name")]
        [Required]
        [UniqeName]
        //custom error =====> بس الفرق بينو و بين اي ايرور تاني انو بيتاكد من حاجة اللي انت عايزها و بيرد ف نفس الوقت 
        // على عكس باقي السيرفر سايد ايرورز التانية **** بمعنى انو بيبق زيو زي اي حاجة تانية فوق مش كاستم
        // الرسالة اللي انت عايزها تظهر             اسم الكلاس              الاكشن                  0
        [Remote(action:"checkName" ,controller:"employee" ,ErrorMessage ="must contain 'slave' word in it"),]
        // if u want to send an additional feild we can add this ===> , AdditionalFeild= "adress"<====== u can pass any
        //prop u want to add or compare with like (salary, imageUrl ,etc) 
        public string name { get; set; }
        [Range(maximum:200000 , minimum:6000)]
        public int salary { get; set; }
        public string adress { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int deptId { get; set; }
        [ForeignKey("deptId")]

        public Department? department { get; set; }
    }
}
