﻿using Academy.Core.Entities;

namespace Academy.Business.Interfaces;

public interface IGroupServices
{
    void Create(string name, int maxStudentCount, string categoryName);
    Group? GetById(int id);
    Group? GetByName(string name);
    void Active(string name,  bool activated);
    void Delete(string name);
    void ShowAllStudents(string name);
    void ShowAll();
}
