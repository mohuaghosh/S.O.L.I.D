using System.Collections.Generic;

namespace xp.solid._2_OCP.Compliance
{
    public class ITStudent : IStudent
    {
        public string StudentType()
        {
            return "IT";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            Logger.Logger.LogMessage("PartTimeStudent");            
            return new List<string> { "AI in Programming", "Data Science" };
        }

    }


}


