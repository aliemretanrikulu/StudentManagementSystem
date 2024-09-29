namespace StudentManagementSystem.Models;

public sealed class Student : Entity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }

    public override string ToString()
    {
        return $"Öğrenci adı: {Name}, Soyadı: {Surname}, Yaş: {Age} Location: {Location}";
    }

}
