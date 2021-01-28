using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class SelectSubject : StageType, IThesisUpload
    {
        private DateTime DeadlineOfCurrentStage;

        public SelectSubject()
        {
            Subject = "";
        }

        public SelectSubject(DateTime testingDate)
        {
            Subject = "";

            this.DeadlineOfCurrentStage = testingDate.AddDays(7.0);
        }

        public override bool DeadlineCheck(DateTime date)
        {
            int current = (DeadlineOfCurrentStage - date).Days;
            int finale = (FinaleDeadline - date).Days;

            if (finale <= 0)
            {
                Console.WriteLine("Przykro nam, czas na uzyskanie dyplomu w roku akademickim 2020/21 się skończył. Spróbuj za rok.");
                return false;
            }
            else if (finale < 20)
            {
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy. Lepiej się pośpiesz.");
                return true;
            }
            else if (current <= 0)
            {
                Console.WriteLine("Czas na zakończenie tego etapu zakończył się. Prosimy o kontakt z dziekanatem.");
                return false;
            }
            else
            {
                Console.WriteLine("Zostało jeszcze " + current + " dni do zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
                return true;
            }

        }

        public override void Update(string subject)
        {
            this.Subject = subject; 
            //tu powinien być zapis do bazy
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
