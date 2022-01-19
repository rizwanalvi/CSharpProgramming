using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConceptApp.Model;
namespace ConceptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student _std = new Student();
            _std.StudentId = 100;
            _std.FeeSubmit();
            ///---------------
            Faculty.CourseId = 1001;

            Staff _stf = new Staff();
            Semesters _sm = new Semesters();
          

            Console.ReadKey();

        }
    }
}
