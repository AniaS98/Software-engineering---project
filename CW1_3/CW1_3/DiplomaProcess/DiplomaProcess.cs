using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    public class DiplomaProcess
    {
        private StageType ActualStage { get; set; }
      //  private StageType NextStage { get;set }
        private DateTime StageStartDate   { get; set; }
        private DateTime StageEndDate { get; set; }

        public DiplomaProcess(DateTime StageStartDate)
        {
            this.ActualStage = new ChoosePromotor();
            this.StageStartDate = StageStartDate;//DateTime.Now;
            this.StageEndDate = this.ActualStage.CalculateEndDate(this.StageStartDate);
            WriteInfo();
        }

        public void SetNextStage()
        {
            if(this.ActualStage is ChoosePromotor)
            {
                this.ActualStage = new SelectSubject();
            }else if (this.ActualStage is SelectSubject)
            {
                this.ActualStage = new SubjectAcceptance();
            }
            else if (this.ActualStage is SubjectAcceptance)
            {
                this.ActualStage = new ThesisUpload();
            }
            else if (this.ActualStage is ThesisUpload)
            {
                this.ActualStage = new JSAcontrol();
            }
            else if (this.ActualStage is JSAcontrol)
            {
                this.ActualStage = new PromotorReview();
            }
            else if (this.ActualStage is PromotorReview)
            {
                this.ActualStage = new ThesisDefence();
            }
            else
            {
                return;
            }

            SetDates();
            WriteInfo();
        }

        private void SetDates()
        {
            this.StageStartDate = this.StageEndDate;
            this.StageEndDate = this.ActualStage.CalculateEndDate(this.StageStartDate);
        }

        private void WriteInfo()
        {
            Console.WriteLine(this.ActualStage.StageName);
            Console.WriteLine(this.StageStartDate);
            Console.WriteLine(this.StageEndDate);
        }


    }


}
