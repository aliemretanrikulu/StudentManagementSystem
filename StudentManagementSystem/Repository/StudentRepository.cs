using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repository;

public class StudentRepository : Entity
{
    List<Student> students = new List<Student>()
    {
        new Student(1, "Emre", "Tanrıkulu", 25, "Halkalı"),
        new Student(2, "İlayda", "Kudun", 22, "Halkalı"),
        new Student(3, "Recep", "Uluğ", 25, "İkitelli"),
        new Student(4, "Fatma", "Kılıçsaymaz", 22, "Halkalı"),
        new Student(5, "Ali", "Çalışkan", 24, "Bakırköy"),
        new Student(6, "Şakir", "Tekin", 25, "Sefaköy"),
    };

}
