## Delegate RateCriteria and SortStudents function in main()
```cs
static void SortStudents(List<Student> students, Comparison<Student> comparison)
{
    students.Sort(comparison);
}

static int RateCriteria(Student a, Student b) => b.GetAverageMark().CompareTo(a.GetAverageMark());
```
## Events in Student class
```cs
public event EventHandler Overslept;
public event EventHandler GotMachineGun;
public event EventHandler PassedExamOn12;

public void SleepIn()
{
    Console.WriteLine("Student overslept.");
    Overslept?.Invoke(this, EventArgs.Empty);
}
public void GetWeapon()
{
    Console.WriteLine("Student got a machine gun.");
    GotMachineGun?.Invoke(this, EventArgs.Empty);
}
public void PassExam()
{
    Console.WriteLine("Student passed the exam with a score of 12.");
    PassedExamOn12?.Invoke(this, EventArgs.Empty);
}
```
## Writing student data to a .txt file
```cs
Group group = new();

using (StreamWriter writer = new StreamWriter(@"D:\c#-projects\EducationInstitution\EducationInstitution\StudentsData.txt"))
{
    foreach (Student student in group)
    {
        writer.WriteLine("{0}, {1}, {2}, {3}", student.Name, student.Birthday, student.Address, student.PhoneNumber);
    }
}

Console.WriteLine("Data written to file.");
```
[![photo-2023-05-10-15-38-36.jpg](https://i.postimg.cc/xTQd11sq/photo-2023-05-10-15-38-36.jpg)](https://postimg.cc/DmChCn3K)
