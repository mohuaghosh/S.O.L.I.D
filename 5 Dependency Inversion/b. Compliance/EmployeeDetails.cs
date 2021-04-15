﻿using System;
using System.Collections.Generic;
using System.Text;


namespace xp.solid._5_dependency_inversion.b._compliance
{
    public class EmployeeDetails
    {
        public interface ISalaryCalculator
        {
            float CalculateSalary(int hoursWorked, float hourlyRate);
        }

        public class SalaryCalculatorModified : ISalaryCalculator
        {
            public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
        }

        public class EmployeeDetailsModified
        {
            private readonly ISalaryCalculator _salaryCalculator;
            public int HoursWorked { get; set; }
            public int HourlyRate { get; set; }
            public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
            {
                _salaryCalculator = salaryCalculator;
            }
            public float GetSalary()
            {
                return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
            }
        }
    }
}
