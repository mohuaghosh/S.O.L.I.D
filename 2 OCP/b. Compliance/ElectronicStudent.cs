using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Compliance
{
    public class ElectronicStudent : IStudent
    {
        public string StudentType()
        {
            return "Electronic";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            Logger.Logger.LogMessage("FullTimeStudent");

            return new List<string> { "Micro Processor 8085", "Micro Processor 8086" };
        }

       
    }

}


