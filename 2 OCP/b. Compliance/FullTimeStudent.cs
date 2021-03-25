using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Compliance
{
    public class FullTimeStudent : IStudent
    {
        public string StudentType()
        {
            return "Full-Time";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            Logger.Logger.LogMessage("FullTimeStudent");
            return new List<string> { "Sub 1", "Sub 2" };
        }

       
    }

}


