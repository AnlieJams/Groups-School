using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int StudentID { get; set; }

    public Student(string name, int studentID)
    {
        Name = name;
        StudentID = studentID;
    }
}

class StudentGroup
{
    public string GroupName { get; set; }
    public List<Student> Students { get; }

    public StudentGroup(string groupName)
    {
        GroupName = groupName;
        Students = new List<Student>();
    }

    
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    
    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
    }
}

class Program
{
    static void Main()
    {
        
        StudentGroup group = new StudentGroup("Группа A");
        group.AddStudent(new Student("Микрочелик", 1));
        group.AddStudent(new Student("Кровавая Мэри", 2));
        group.AddStudent(new Student("Я", 3));

        
        Console.WriteLine("Студенты в группе " + group.GroupName + ":");
        foreach (var student in group.Students)
        {
            Console.WriteLine("Имя: " + student.Name + ", № студента: " + student.StudentID);
        }
    }
}
