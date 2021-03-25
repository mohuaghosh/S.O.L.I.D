using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Violation
{
    public class Student
    {
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
                    ComputerStudent fullTimeStudent = new ComputerStudent();
                    List<string> fullTimeSubjects = fullTimeStudent.GetStudentSubjects();
                    break;

                case "Electronic":
                    PartTimeStudent partTimeStudent = new PartTimeStudent();
                    List<string> partTimeSubjects = partTimeStudent.GetStudentSubjects();
                    break;

            }

        }

    }
}
