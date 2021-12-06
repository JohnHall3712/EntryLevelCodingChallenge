using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class Program
    {
        const int MAX_LIST_COUNT = 35;
        static void Main(string[] args)
        {

            ConsoleRenderer.Init(Console.WindowWidth, MAX_LIST_COUNT + 5, ConsoleColor.DarkBlue, ConsoleColor.DarkMagenta);

            RendererVisitor rendererVisitor = new RendererVisitor();

            Garage garage = new Garage(MAX_LIST_COUNT);
            garage.SortGarageByType();
            garage.Render(rendererVisitor);
            

            ConsoleRenderer.WriteLine("press any key to exit", ConsoleColor.DarkGray);
            ConsoleRenderer.ShowBuffer();           
            Console.ReadKey();
        }

       
    }
}

