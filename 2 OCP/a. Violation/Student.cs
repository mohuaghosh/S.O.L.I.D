using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Violation
{
    public class Student
    {
        public object CourseTypes { get; private set; }

        public List<string> GetPreviousSubjectDetails(int Id)
        {
            return new List<string>();
        }

        public void GetStudentSubjectDetails(int studentid, string courseType)
        {
            
            List<string> getPreviousYearSubjects = GetPreviousSubjectDetails(studentid);
            
            
            // OCP Violoation
            switch (courseType)
            {
                case "Computers":
                    ComputerStudent computerStudent = new ComputerStudent();
                    List<string> courseComputer = computerStudent.GetStudentSubjects();
                    break;

                case "Electronics":
                    ComputerStudent ElectronicsStudent = new ComputerStudent();
                    List<string> courseElectronics = electronicsStudent.GetStudentSubjects();
                    break;

            }

        }

    }
}
