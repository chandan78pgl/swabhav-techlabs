using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    interface SalariedEmployee
    {
        Double Salary { get; }
        String GiveSalaryLogic();
    }
}
