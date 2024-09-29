using StudentManagementSystem.Models;
using StudentManagementSystem.Repository;

namespace StudentManagementSystem.Service;

public class StudentService
{
    StudentRepository studentRepository = new StudentRepository();

    public void GetAll()
    {
        List<Student> students = studentRepository.GetStudents();
        Console.WriteLine("Tüm öğrenciler listelendi: ");

        foreach (Student student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }

    public void Add(Student student)
    {
        studentRepository.AddStudent(student);
        Console.WriteLine("Yeni öğrenci eklendi: ");
        Console.WriteLine(student.ToString());
    }

    public void Remove(int id)
    {
        studentRepository.RemoveStudent(id);
        Console.WriteLine($"id'si {id} olan öğrenci silindi!");
    }

    public void Update(int id, Student updated)
    {
        studentRepository.UpdateStudent(id, updated);
        Console.WriteLine($"ID'si {id} olan öğrenci güncellendi.");
    }
}
