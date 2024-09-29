namespace StudentManagementSystem.Models;

public class Teacher
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Öğretmen adı: {Name}, Öğretmen Soyadı: {Surname}, Öğretmen yaşı: {Age}";
    }
}
