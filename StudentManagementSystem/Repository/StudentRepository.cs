using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repository;

public class StudentRepository : Entity
{
    private List<Student> students = new List<Student>()
    {
        new Student { Id = 1, Name = "Emre", Surname = "Tanrıkulu", Age = 25, Location = "Halkalı" },
        new Student { Id = 2, Name = "İlayda", Surname = "Kudun", Age = 22, Location = "Halkalı" },
        new Student { Id = 3, Name = "Recep", Surname = "Uluğ", Age = 25, Location = "İkitelli" },
        new Student { Id = 4, Name = "Fatma", Surname = "Kılıçsaymaz", Age = 22, Location = "Halkalı" },
        new Student { Id = 5, Name = "Ali", Surname = "Çalışkan", Age = 24, Location = "Bakırköy" },
        new Student { Id = 6, Name = "Şakir", Surname = "Tekin", Age = 25, Location = "Sefaköy" }
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
        if (student is not null)
        {
            students.Remove(student);

        }
    }

    public void UpdateStudent(int id, Student updated)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student is not null)
        {
            student.Id = id;
            student.Name = updated.Name;
            student.Surname = updated.Surname;
            student.Age = updated.Age;
            student.Location = updated.Location;
        }
    }
}