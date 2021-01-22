using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
   public class ThesisUpload : StageType
    {
        public string StageName = "Wgranie pracy dyplomowej do systemu";

        public override DateTime CalculateEndDate(DateTime data)
        {
            return data.AddDays(45);
        }
    }
}
