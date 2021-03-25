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
            Logger.Logger.LogMessage("PartTimeStudent");
            return new List<string> { "Sub 1", "Sub 2" ,"Subj 3"};
        }

    }


}


