using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public abstract class StageType
    {
        public DateTime FinaleDeadline = new DateTime(2021, 9, 1, 14, 0, 0);
        public string FileName;
        public string Subject;

        public abstract bool DeadlineCheck(DateTime date);

        public abstract bool Check();

        public abstract void Update(string variable);

    }
}
