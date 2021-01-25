using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class SelectSubject : StageType
    {
        private DateTime DeadlineOfCurrentStage;

        public SelectSubject(DateTime testingDate, string promotor)
        {
            this.Promotor = promotor;
            Subject = "";

            this.DeadlineOfCurrentStage = testingDate.AddDays(7.0);
        }

        public override void DeadlineCheck(DateTime date)
        {
            int current = (DeadlineOfCurrentStage - date).Days;
            int finale = (FinaleDeadline - date).Days;

            if (finale <= 0)
                Console.WriteLine("Przykro nam, czas na uzyskanie dyplomu w roku akademickim 2020/21 się skończył. Spróbuj za rok.");
            else if (finale < 20)
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy. Lepiej się pośpiesz.");
            else if (current <= 0)
                Console.WriteLine("Czas na zakończenie tego etapu zakończył się. Prosimy o kontakt z dziekanatem.");
            else
                Console.WriteLine("Zostało jeszcze " + current + " dni do zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
        }

        public override void Update(string subject)
        {
            this.Subject = subject; 
        }

        public override bool Check()
        {
            if (Subject != "")
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPodsumowanie etapu \'Wybór Tematu Pracy\'\n");
            sb.Append("Termin zakończenia obecnego etapu: ");
            sb.Append(DeadlineOfCurrentStage.ToString());
            sb.Append("\nTermin zakończenia procesu dyplomowania: ");
            sb.Append(FinaleDeadline.ToString());
            return sb.ToString();
        }

    }
}
