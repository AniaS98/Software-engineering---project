using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3.DiplomaProcess
{
    class Execute
    {
        static void Main(string[] args)
        {
            DiplomaProcess diplomaProcess = new DiplomaProcess(DateTime.Now);
            diplomaProcess.SetNextStage();
            diplomaProcess.SetNextStage(); 
            diplomaProcess.SetNextStage();
            diplomaProcess.SetNextStage();
            diplomaProcess.SetNextStage();
            diplomaProcess.SetNextStage();
            diplomaProcess.SetNextStage(); 
            Console.ReadKey();
        }
    }
}
