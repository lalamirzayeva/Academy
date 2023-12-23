using Academy.Core.Interfaces;

namespace Academy.Core.Entities;

public class Group : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MaxStudentCount { get; set; }
    public int CurrentStudentCount { get; set; }
    public bool IsActivate { get; set; }
    public Category Category { get; set; }
    private static int _id;
    public Group(string name, int maxStudentCount, Category category)
    {
        Id = _id++;
        Name = name;
        MaxStudentCount = maxStudentCount;
        Category = category;
    }
}
