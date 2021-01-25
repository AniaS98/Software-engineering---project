using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public class DiplomaProcess
    {
        public StageType ActualStage { get; set; }

        public DiplomaProcess(DateTime testingDate)
        {
            this.ActualStage = new ChoosePromotor(testingDate);
            Console.WriteLine(ActualStage.ToString());
        }

        public void SetNextStage(DateTime testingDate)
        {
            if(this.ActualStage is ChoosePromotor)
            {
                if (this.ActualStage.Check() == true)
                    this.ActualStage = new SelectSubject(testingDate,ActualStage.Promotor);
                else
                    Console.WriteLine("Nie wybrano promotora");
            }else if (this.ActualStage is SelectSubject)
            {
                if (this.ActualStage.Check() == true)
                    this.ActualStage = new SubjectAcceptance(testingDate,ActualStage.Promotor, ActualStage.Subject);
                else
                    Console.WriteLine("Nie wybrano tematu pracy");
            }
            else if (this.ActualStage is SubjectAcceptance)
            {
                if(this.ActualStage.Subject == "")
                {
                    Console.WriteLine("Temat Pracy nie został zatwierdzony przez Promotora. Prosimy o wprowadzenie poprawek i ponowne przesłanie tematu pracy");
                    this.ActualStage = new ThesisUpload(testingDate,ActualStage.Promotor, ActualStage.Subject);
                }
                else if (this.ActualStage.Check() == true)
                    this.ActualStage = new ThesisUpload(testingDate,ActualStage.Promotor, ActualStage.Subject);
                else
                    Console.WriteLine("Nie zatwierdzono tematu pracy");
            }
            else if (this.ActualStage is ThesisUpload)
            {
                if (this.ActualStage.Check() == true)
                    this.ActualStage = new JSAcontrol(testingDate,this.ActualStage.Promotor, ActualStage.Subject, ActualStage.FileName);
                else
                    Console.WriteLine("Praca nie została jeszcze przesłana");
            }
            else if (this.ActualStage is JSAcontrol)
            {
                if(this.ActualStage.FileName == "")
                {
                    Console.WriteLine("Praca uzyskała negatywny wynik analizy JSA. Prosimy o wprowadzenie poprawek i ponowne przesłanie pracy");
                    this.ActualStage = new ThesisUpload(testingDate,ActualStage.Promotor, ActualStage.Subject);
                }
                else if(this.ActualStage.Check() == true)
                    this.ActualStage = new PromotorReview(testingDate,this.ActualStage.Promotor, ActualStage.Subject, ActualStage.FileName);
                else
                    Console.WriteLine("Praca nie została jeszcze sprawdzona przez JSA");
            }
            else if (this.ActualStage is PromotorReview)
            {
                this.ActualStage = new ThesisDefence(testingDate, this.ActualStage.Promotor, ActualStage.Subject, ActualStage.FileName, ActualStage.Evaluation);
            }
            else
            {
                return;
            }

            Console.WriteLine(ActualStage.ToString());
        }

    }


}
