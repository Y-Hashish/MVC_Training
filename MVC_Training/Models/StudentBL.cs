namespace MVC_Training.Models
{
    public class StudentBL
    {
        List<Student> student;
        public StudentBL()
        {
            student = new List<Student>();
            student.Add(new Student() { id = 1 , name ="yousef" , age =21 , image = "https://th.bing.com/th/id/OIP.FV5bK-GUu_n8p3l3Tp2wJgHaFp?rs=1&pid=ImgDetMain" });
            student.Add(new Student() { id = 2 , name ="emad" , age =53 , image = "https://th.bing.com/th/id/OIP.FV5bK-GUu_n8p3l3Tp2wJgHaFp?rs=1&pid=ImgDetMain" });
            student.Add(new Student() { id = 3 , name ="fahmy" , age =90 , image = "https://th.bing.com/th/id/OIP.FV5bK-GUu_n8p3l3Tp2wJgHaFp?rs=1&pid=ImgDetMain" });
            student.Add(new Student() { id = 4 , name ="hashish" , age =1000, image = "https://th.bing.com/th/id/OIP.FV5bK-GUu_n8p3l3Tp2wJgHaFp?rs=1&pid=ImgDetMain" });
        }
        public List<Student> GetAll()
        {
            return student;
        }
        public Student GetById(int id)
        {
            return student.FirstOrDefault(p => p.id == id);
        }
    }
}
