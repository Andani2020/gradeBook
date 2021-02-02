using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public abstract class BookBase : NameObject , IBook
    {
        public  BookBase(string name) : base(name)
        {
            Name = name;
        }

        public string name => throw new NotImplementedException();

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
