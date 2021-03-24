using System;
using System.Collections.Generic;
using System.Text;
using xp.solid._1_Single_Responsibility.Violation;

namespace xp.solid._1_Single_Responsibility.Violation
{
    public class EnrollmentService
    {
        public Student Students { get; set; }

        public void Onboard()
        {
            // Do Student Enrollment     
            
        }

        public void Deboard()
        {
            // Do Student Offboard
        }

        //Violation of SRP
        public void VehicleParkingAllotment(Student student)
        {
            //

        }

    }
}
