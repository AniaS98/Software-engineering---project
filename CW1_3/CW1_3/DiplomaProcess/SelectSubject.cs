using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class SelectSubject : StageType
    {
        public string StageName="Wybor tematu";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(5);
        }

    }
}
