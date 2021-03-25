using System.Collections.Generic;

namespace xp.solid._2_OCP.Compliance
{
    public class ComputerStudent : IStudent
    {
        public string StudentType()
        {
            return "Computers";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            Logger.Logger.LogMessage("PartTimeStudent");            
            
            return new List<string> { "C Programming", "System Softwares" };
        }

    }


}


