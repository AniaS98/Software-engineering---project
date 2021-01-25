﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class ThesisDefence : StageType
    {
        private DateTime DeadlineOfCurrentStage;
        

        public ThesisDefence(DateTime testingDate, string promotor, string subject, string filename, string evaluation)
        {
            this.Promotor = promotor;
            this.Subject = subject;
            this.FileName = filename;
            this.Evaluation = evaluation;

            this.DeadlineOfCurrentStage = testingDate.AddDays(1.0);
            this.DateOfGraduate = new DateTime();
        }

        public override void DeadlineCheck(DateTime date)
        {
            int current = (DeadlineOfCurrentStage - date).Days;
            int finale = (FinaleDeadline - date).Days;

            if (finale <= 0)
                Console.WriteLine("Przykro nam, czas na uzyskanie dyplomu w roku akademickim 2020/21 się skończył. Spróbuj za rok.\n");
            else if (finale < 2)
                Console.WriteLine("Czas na uzyskanie Dyplomu się kończy.\nSystem oczekuje na wprowadzenie terminu obrony\n");
            else if (current <= 0)
                Console.WriteLine("Planowany czas na zakończenie tego etapu zakończył się.\nDo ostatecznego terminu pozostało Ci " + finale + " dni.\n");
            else
                Console.WriteLine("Zostało jeszcze " + current + " dni do planowanego zakończenia tego etapu.\nDo ostatecznego terminu dyplomowania zostało Ci " + finale + " dni\n");
        }

        public override void Update(string date)
        {
            this.DateOfGraduate = DateTime.Parse(date);
        }

        public override bool Check()
        {
            if (DateOfGraduate != new DateTime())
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPodsumowanie etapu \'Wybór Terminu Obrony\'\n");
            sb.Append("Planowany termin zakończenia obecnego etapu: ");
            sb.Append(DeadlineOfCurrentStage.ToString());
            sb.Append("\nTermin zakończenia procesu dyplomowania: ");
            sb.Append(FinaleDeadline.ToString());
            sb.Append("\nPowodzenia!");
            return sb.ToString();
        }
    }
}
