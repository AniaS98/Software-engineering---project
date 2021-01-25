using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public abstract class StageType
    {
        public string StageName;
        //public abstract void process(DiplomaProcess diplomaProcess);
        //public abstract DateTime CalculateStartDate(DateTime date);
        public abstract DateTime CalculateEndDate(DateTime date);


    }
}
