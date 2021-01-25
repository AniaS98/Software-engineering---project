using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class JSAcontrol : StageType
    {
        public string StageName = "Przeslanie pracy do JSA";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(2);
        }
    }
}
