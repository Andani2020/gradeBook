using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public interface  IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string name
        { get; }
        event GradeAddedDelegate GradeAdded;

    }
}
