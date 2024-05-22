
namespace ConsoleApps.AppCalculator
{
    internal class CalculatorApp
    {        
        internal static void CalcMain()
        {
            Helper.DisplayMessage("kalkulyator");
            Thread.Sleep(2000);
            new Computing().StartComputing();
        }
    }
}
