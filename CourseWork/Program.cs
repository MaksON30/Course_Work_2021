using System;
using System.Threading.Tasks;
using CourseWork.Core;
using CourseWork.Core.Core;
using CourseWork.Models;

namespace CourseWork
{
    class Program
    {
        static async Task Main(string[] args)
        {

            GameFieldManager gameFieldManager = new GameFieldManager(20, 20, new RabbitManager(),new WolvesManager(), new SheWolvesManager());
          //  GameFieldManager gameFieldManager2 = new GameFieldManager(20, 20, new WolvesManager());
           // GameFieldManager gameFieldManager3 = new GameFieldManager(20, 20, new SheWolvesManager());
            await gameFieldManager.StartSimulation();

            //var t = WolvesManager.GetDataForScan(new GameCell[6, 5], new Coordinate(5,4));
            //Console.Write(t.First.I + " ");
            //Console.WriteLine(t.First.J);

            //Console.Write(t.Second.I + " ");
            //Console.WriteLine(t.Second.J);
            //Console.WriteLine(gameField);

        }
    }
}
