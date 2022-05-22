using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism_Abstract2._0
{
    //Interfaces are contracts, meaning must implement in implemented classes
    public interface IEmployee
    {
        double ReceiveWage();
        void GiveBonus();
        void PerformWork();
        void StopWorking();
        void DisplayEmployeeDetails();

        void GiveCompliment();
    }
}
