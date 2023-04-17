using EducationInstitution.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitution.WaysComparer;

public class LastNameComparer : IComparer<Student>
{    
    public int Compare(Student? first, Student? second)
    {    
        return string.Compare(first.Lastname, second.Lastname); 
    }
}