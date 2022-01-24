using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ConCustomList.Model;
namespace ConCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            int _Choice = 0;
            int _StdId = 0;
            bool _flag = true;
            String _StdName = "";
            List<Student> _StdList = new List<Student>();
            _StdList.Add(new Student {StudentId=100,StudentName="AHMED KHAN" });
            _StdList.Add(new Student { StudentId = 101, StudentName = "BASHIR ULLAH KHAN" });
            _StdList.Add(new Student { StudentId = 102, StudentName = "MUZAMMIL" });
            _StdList.Add(new Student { StudentId = 103, StudentName = "MUHAMMAD BILAL" });
            _StdList.Add(new Student { StudentId = 104, StudentName = "UMER KHAN" });

            foreach (var item in _StdList)
            {
                Console.WriteLine("{0}\t{1}",item.StudentId,item.StudentName);
            }
            while (_flag) {
                Console.WriteLine("1 - Add Student");
                Console.WriteLine("2 - Show Student");
                Console.WriteLine("3 - Exit");
                Console.Write("Select Your Choice : ");
                _Choice = int.Parse(Console.ReadLine());
                switch (_Choice)
                {
                    case 1:
                        Console.Write("Enter Student Id : ");
                        _StdId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name : ");
                        _StdName = Console.ReadLine();
                        _StdList.Add(new Student { StudentId = _StdId, StudentName = _StdName });
                        break;
                    case 2:
                        foreach (var item in _StdList)
                        {
                            Console.WriteLine("{0}\t{1}", item.StudentId, item.StudentName);
                        }
                        break;
                    case 3:
                        _flag = false;
                        break;

                    default:
                        break;
                }

            }
           






            //List<String> _fruitList = new List<string>();
            //_fruitList.Add("Mango");
            //_fruitList.Add("Orange");
            //_fruitList.Add("Apple");
            //_fruitList.Add("PineApple");
            //_fruitList.Add("Avcardo");
            //_fruitList.Add("Barries");
            //foreach (var item in _fruitList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------");
            //_fruitList.Sort();
            //foreach (var item in _fruitList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Total Number of Items {0}",_fruitList.Count);
            //_fruitList.Insert(4,"Strawberry");
            //Console.WriteLine("Total Number of Items {0}", _fruitList.Count);





            Console.ReadKey();

        }
    }
}
