using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class SubjectAcceptance : StageType
    {
        public string StageName="Zatwierdzenie tematu pracy";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(2);
        }



    }
}
