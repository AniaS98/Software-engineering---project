using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class JSAcontrol : StageType
    {
        private DateTime DeadlineOfCurrentStage;
        private bool CheckVar;

        public JSAcontrol(DateTime testingDate, string promotor, string subject, string filename)
        {
            this.Promotor = promotor;
            this.Subject = subject;
            this.FileName = filename;

            this.DeadlineOfCurrentStage = testingDate.AddDays(1.0);
            this.CheckVar = false;
        }

        public void NegativeReview()
        {
            this.CheckVar = false;
            this.FileName = "";
        }

        public override void DeadlineCheck(DateTime date)
        {
            int current = (DeadlineOfCurrentStage - date).Days;
            int finale = (FinaleDeadline - date).Days;

            if (finale <= 0)
                Console.WriteLine("Przykro nam, czas na uzyskanie dyplomu w roku akademickim 2020/21 się skończył. Spróbuj za rok.");
            else if (finale < 2)
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy.");
            else if (current <= 0)
                Console.WriteLine("Planowany czas na zakończenie tego etapu zakończył się. Trwa analiza przesłanej pracy. Do ostatecznego terminu obrony pozostało " + finale + " dni.");
            else
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni");
        }

        public override void Update(string fileName)
        {
            this.CheckVar = true;
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
