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

        public void GetStudentSubjectDetails(int studentid, string studentType)
        {
            
            List<string> getPreviousYearSubjects = GetPreviousSubjectDetails(studentid);
            
            
            // OCP Violoation
            switch (studentType)
            {
                case "Full-Time":
                    FullTimeStudent fullTimeStudent = new FullTimeStudent();
                    List<string> fullTimeSubjects = fullTimeStudent.GetStudentSubjects();
                    break;

                case "Part-Time":
                    PartTimeStudent partTimeStudent = new PartTimeStudent();
                    List<string> partTimeSubjects = partTimeStudent.GetStudentSubjects();
                    break;

            }

        }

    }
}
