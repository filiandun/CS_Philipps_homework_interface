namespace Homework
{
    /*
    * Задание 1. Реализовать программу “Строительство дома”
    Реализовать:
    • Классы
        ■ House (Дом), Basement (Фундамент), Walls (Стены), Door (Дверь), Window (Окно), Roof (Крыша); 
        ■ Team (Бригада строителей), Worker (Строитель), TeamLeader (Бригадир).
    • Интерфейсы
        ■ IWorker, IPart.

    Все части дома должны реализовать интерфейс IPart (Часть дома), для рабочих и бригадира предоставляется базовый интерфейс IWorker (Рабочий).
    Бригада строителей (Team) строит дом (House). Дом состоит из фундамента (Basement), стен (Wall), окон (Window), дверей (Door), крыши (Part).
    Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша.
    Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента. 
    Каждый строитель не знает заранее, на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу. 
    Если в игру вступает бригадир (TeamLeader), он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена.
    В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).
    */

    interface IWorker
    {
        public string name { get; set; }
    }

    class Team
    { 
        
    }

    class TeamLeader : IWorker
    {
        public string name { get; set; }

        public void CreateReport()
        {

        }
    }

    class Worker : IWorker
    {
        public string name { get; set; }

        public void StartBuild()
        {

        }

    }

    interface IPart
    {
        public string name { get; set; }
        public void Quantity();

    }

    class Basement : IPart
    {
        public string name { get; set; }

        public void Quantity()
        {
            throw new NotImplementedException();
        }
    }

    class Wall : IPart
    {
        public string name { get; set; }

        public void Quantity()
        {
            throw new NotImplementedException();
        }
    }

    class Windows : IPart
    {
        public string name { get; set; }

        public void Quantity()
        {
            throw new NotImplementedException();
        }
    }

    class Door : IPart
    {
        public string name { get; set; }

        public void Quantity()
        {
            throw new NotImplementedException();
        }
    }

    class Part : IPart
    { 
        public string name { get; set; }

        public void Quantity()
        {
            throw new NotImplementedException();
        }
    }




    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}