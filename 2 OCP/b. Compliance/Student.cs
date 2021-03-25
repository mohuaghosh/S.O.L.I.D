using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Compliance
{
    public class Student
    {
        public List<string> GetPreviousSubjectDetails(int Id)
        {
            return new List<string>();
        }

        public void GetStudentSubjectDetails(int studentid, IStudent student)
        {

            List<string> getPreviousYearSubjects = GetPreviousSubjectDetails(studentid);

            List<string> Subjects = student.GetStudentSubjects();

        }

    }
}
