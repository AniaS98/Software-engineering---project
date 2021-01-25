using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class ThesisDefence : StageType
    {
        public string StageName = "Wybor terminu obrony";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(5);
        }
    }
}
