using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class BashSoftProgram
    {
        static void Main()
        {
            IOManager.TraverseDirectory(@"C:\Projects\BashSoft\BashSoft");
            StudentsRepository.InitializeData();
            StudentsRepository.GetAllStudentsFromCourse("Unity");
            StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
