using EducationInstitution.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitution.WaysComparer;

public class AverageMarkComparer : IComparer<Student>
{
    public int Compare(Student? first, Student? second)
    {
        if (first.GetAverageMark() > second.GetAverageMark()) return 1;
        if (first.GetAverageMark() < second.GetAverageMark()) return -1;
        return 0;
    }
}
