using Academy.Business.Interfaces;
using Academy.Business.Utilities.Exceptions;
using Academy.Core.Entities;
using Academy.DataAccess.Contexts;

namespace Academy.Business.Services;

public class StudentService : IStudentServices
{
    private IGroupServices groupServices { get; }
    public StudentService()
    {
        groupServices = new GroupService();
    }
    public void ChangeGroup(int studentId, string newGroupName)
    {
       
    }

    public void Create(string name, string surname, string email, string groupName)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Group? group = groupServices.GetByName(groupName);
        if (group is null) throw new NotFoundException($"{groupName} does not exist.");
        if (group.MaxStudentCount == group.CurrentStudentCount)
            throw new GroupIsFullException($"{group.Name} is already full.");
        Student student = new(name, surname, email, group);
        AcademyDbContext.Students.Add(student);
        group.CurrentStudentCount++;
    }

    public void Delete(string id)
    {
        throw new NotImplementedException();
    }
}
