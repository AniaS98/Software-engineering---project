
using System;

namespace Dyplomowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            DiplomaProcess diplomaProcess = new DiplomaProcess(new DateTime(2021, 01, 25, 12, 0, 0));
            diplomaProcess.ActualStage.Update("Jan Kowalski");//Wybór promotora
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 01, 27, 12, 0, 0));
            Console.ReadKey();

            diplomaProcess.SetNextStage(new DateTime(2021, 01, 27, 12, 0, 0));
            diplomaProcess.ActualStage.Update("Praca Dyplomowa");//Wybór tematu pracy
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 01, 28, 12, 0, 0));
            Console.ReadKey();



            diplomaProcess.SetNextStage(new DateTime(2021, 01, 28, 12, 0, 0));
            diplomaProcess.ActualStage.Update("Praca Dyplomowa");//Zatwierdzenie tematu pracy
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 01, 28, 12, 0, 0));
            Console.ReadKey();

            diplomaProcess.SetNextStage(new DateTime(2021, 03, 25, 12, 0, 0));
            diplomaProcess.ActualStage.Update("Praca Dyplomowa plik");//Wysłanie pracy
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 03, 25, 12, 0, 0));
            Console.ReadKey();

            diplomaProcess.SetNextStage(new DateTime(2021, 01, 29, 12, 0, 0));
            diplomaProcess.ActualStage.Update("Praca Dyplomowa plik");//Sprawdzanie pracy w JSA
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 03, 29, 13, 0, 0));
            Console.ReadKey();

            diplomaProcess.SetNextStage(new DateTime(2021, 01, 29, 12, 0, 0));
            diplomaProcess.ActualStage.Update("ocena");//Sprawdzanie pracy przez promotora i recenzenta
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 03, 29, 13, 0, 0));
            Console.ReadKey();

            diplomaProcess.SetNextStage(new DateTime(2021, 01, 29, 12, 0, 0));
            diplomaProcess.ActualStage.Update("2021/06/06");//Sprawdzanie pracy przez promotora i recenzenta
            diplomaProcess.ActualStage.DeadlineCheck(new DateTime(2021, 03, 29, 13, 0, 0));
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
