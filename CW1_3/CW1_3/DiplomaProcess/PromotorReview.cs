using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class PromotorReview : StageType
    {
        public string StageName = "Ocena promotora i recenzenta";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(10);
        }
    }
}
