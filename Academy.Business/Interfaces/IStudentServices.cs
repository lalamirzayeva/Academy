namespace Academy.Business.Interfaces;

public interface IStudentServices
{
    void Create(string name, string surname, string email, string groupName);
    void Delete(string id);
    void ChangeGroup(int studentId, string newGroupName);
}