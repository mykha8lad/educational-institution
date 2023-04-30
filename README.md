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
