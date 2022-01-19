using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp.Model
{
    class Semesters : Semester
    {
        public override int SemesteId { get; set ; }
        public override string SemesterName { get ; set; }

        public override void RegisterCourse()
        {
            throw new NotImplementedException();
        }
    }
}
