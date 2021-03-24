using System.Collections.Generic;

namespace xp.solid._2_OCP.Compliance
{
    public class PartTimeStudent : IStudent
    {
        public string StudentType()
        {
            return "Part-Time";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            return new List<string>();
        }

    }


}


