using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class JSAcontrol : StageType, IThesisUpload
    {
        private DateTime DeadlineOfCurrentStage;
        private bool CheckVar;

        public JSAcontrol()
        {
            this.CheckVar = false;
        }

        public JSAcontrol(DateTime testingDate)
        {
            this.DeadlineOfCurrentStage = testingDate.AddDays(1.0);
            this.CheckVar = false;
        }

        public void NegativeReview()
        {
            this.CheckVar = false;
            this.FileName = "";
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
            else if (finale < 2)
            {
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy.");
                return true;
            }
            else if (current <= 0)
            {
                Console.WriteLine("Planowany czas na zakończenie tego etapu zakończył się. Trwa analiza przesłanej pracy. Do ostatecznego terminu obrony pozostało " + finale + " dni.");
                return false;
            }
            else
            {
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
                return true;
            }

        }

        public override void Update(string fileName)
        {
            this.CheckVar = true;
            this.FileName = fileName;
            //tu powinien być zapis do bazy
        }

        public override bool Check()
        {
            return CheckVar;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPodsumowanie etapu \'Analiza Pracy przez Jednolity System Antyplagiatowy\'\n");
            sb.Append("Planowany termin zakończenia obecnego etapu: ");
            sb.Append(DeadlineOfCurrentStage.ToString());
            sb.Append("\nTermin zakończenia procesu dyplomowania: ");
            sb.Append(FinaleDeadline.ToString());
            return sb.ToString();
        }
    }
}
