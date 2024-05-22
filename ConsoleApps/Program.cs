using ConsoleApps.AppFigures;
using ConsoleApps.AppPow;
using ConsoleApps.AppCalculator;
using Snake;

namespace ConsoleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menuOpt = Menu.ChooseMenu();

                switch (menuOpt)
                {
                    case 1:
                        CalculatorApp.CalcMain();
                        break;

                    case 2:
                        FiguresApp.FiguresMain();
                        break;

                    case 3:                        
                        PowApp.PowMain();
                        break;

                    case 4:                        
                        SnakeApp.SnakeMain();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Something went wrong.");
                        break;
                }
            }
        }
    }
}
