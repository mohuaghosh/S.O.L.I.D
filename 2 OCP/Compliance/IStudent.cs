using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Compliance
{
    public interface IStudent
    {
        string StudentType();

        List<string> GetStudentSubjects();
    }
}
