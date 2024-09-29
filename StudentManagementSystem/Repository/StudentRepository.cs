using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repository;

public class StudentRepository : Entity
{
    private List<Student> students = new List<Student>()
    {
        new Student(1, "Emre", "Tanrıkulu", 25, "Halkalı"),
        new Student(2, "İlayda", "Kudun", 22, "Halkalı"),
        new Student(3, "Recep", "Uluğ", 25, "İkitelli"),
        new Student(4, "Fatma", "Kılıçsaymaz", 22, "Halkalı"),
        new Student(5, "Ali", "Çalışkan", 24, "Bakırköy"),
        new Student(6, "Şakir", "Tekin", 25, "Sefaköy"),
    };

    public List<Student> GetStudents()
    {
        return students;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void RemoveStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student is null)
        {
            students.Remove(student);

        }
    }

    public void UpdateStudent(int id, Student updated)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student is null)
        {
            student.Id = id;
            student.Name = updated.Name;
            student.Surname = updated.Surname;
            student.Age = updated.Age;
            student.Location = updated.Location;
        }
    }
}