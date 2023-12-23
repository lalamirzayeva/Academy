using Academy.Core.Interfaces;

namespace Academy.Core.Entities;

public class Student : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public Group Group { get; set; }
    public bool IsDeleted { get; set; }
    private static int _id;
    public Student(string name, string surname, string email, Group group)
    {
        Id = _id++;
        Name = name;
        Surname = surname;
        Email = email;
        Group = group;
        IsDeleted = false;
    }

}
