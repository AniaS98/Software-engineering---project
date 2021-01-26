using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class PromotorReview : StageType
    {
        private DateTime DeadlineOfCurrentStage;
        private string Evaluation;

        public PromotorReview(DateTime testingDate)
        {
            this.DeadlineOfCurrentStage = testingDate.AddDays(3.0);
        }

        public override bool DeadlineCheck(DateTime date)
        {
            int current = (DeadlineOfCurrentStage - date).Days;
            int finale = (FinaleDeadline - date).Days;

            if (finale <= 0)
            {
                Console.WriteLine("Przykro nam, czas na uzyskanie dyplomu w roku akademickim 2020/21 się skończył. Spróbuj za rok.\n");
                return false;
            }
            else if (finale < 2)
            {
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy.\nSystem oczekuje na oceny od Promotora i Recenzenta\n");
                return true;
            }
            else if (current <= 0)
            {
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni\n");
                return false;
            }
            else
            {
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
                return true;
            }
        }

        public override void Update(string evaluation)
        {
            this.Evaluation = evaluation;
        }

        public override bool Check()
        {
            if (Evaluation != "")
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPodsumowanie etapu \'Ocena Promotora i Recenzenta\'\n");
            sb.Append("Planowany termin zakończenia obecnego etapu: ");
            sb.Append(DeadlineOfCurrentStage.ToString());
            sb.Append("\nTermin zakończenia procesu dyplomowania: ");
            sb.Append(FinaleDeadline.ToString());
            return sb.ToString();
        }
    }
}
