using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
   public class ThesisUpload : StageType
    {
        private DateTime DeadlineOfCurrentStage;

        public ThesisUpload(DateTime testingDate, string promotor, string subject)
        {
            this.Promotor = promotor;
            this.Subject = subject;

            this.DeadlineOfCurrentStage = testingDate.AddDays(100.0);
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
                Console.WriteLine("Planowany czas na zakończenie tego etapu zakończył się. Pracuj dalej. Do ostatecznego terminu pozostało Ci "+finale+" dni.");
            else
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
        }

        public override void Update(string fileName)
        {
            this.FileName = fileName;
        }

        public override bool Check()
        {
            if (FileName != "")
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPodsumowanie etapu \'Wgrywanie do Systemu Pracy Dyplomowej i Wszystkich Potrzebnych Dokumentów\'\n");
            sb.Append("Planowany termin zakończenia obecnego etapu: ");
            sb.Append(DeadlineOfCurrentStage.ToString());
            sb.Append("\nTermin zakończenia procesu dyplomowania: ");
            sb.Append(FinaleDeadline.ToString());
            return sb.ToString();
        }
    }
}
