using EducationInstitution.Students;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitution;

public class StudentEnumerator : IEnumerator<Student>
{
    List<Student> _students;
    int _currentIndex = -1;

    public StudentEnumerator(List<Student> students)
    {
        _students = students;
    }
    
    public Student Current
    {
        get
        {
            return _students[_currentIndex];
        }
    }
    
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    
    public bool MoveNext()
    {
        _currentIndex++;
        return _currentIndex < _students.Count;
    }
    
    public void Reset()
    {
        _currentIndex = -1;
    }
    
    public void Dispose()
    {
        // Метод Dispose() в данном случае не требует реализации, так как не использует ресурсы, подлежащие освобождению
    }
}
