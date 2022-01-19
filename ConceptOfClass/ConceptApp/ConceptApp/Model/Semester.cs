using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp.Model
{
   public abstract class Semester
    {
        public abstract int SemesteId { get; set; }
        public abstract String SemesterName { get; set; }
        public abstract void RegisterCourse();



    }
}
