using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class ChoosePromotor : StageType
    {
        public string StageName="wybor promotora";

        /*   public override DateTime CalculateStartDate(DateTime data)
           {
               return data;
           }*/

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(3);
        }





    }
}
