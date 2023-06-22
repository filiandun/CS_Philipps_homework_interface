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
        void Do(IPart part);
    }

    class TeamLeader : IWorker
    {
        public void Do(IPart part)
        {
            Console.WriteLine("Бригадир составил отчёт.");
        }
    }

    class Worker : IWorker
    {
        public void Do(IPart part)
        {
            part.Build();
        }
    }

    class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            Console.WriteLine("СТРОИТЕЛЬСТВО НАЧАТО:\n");

            foreach (var part in house.parts)
            {
                foreach (var worker in workers)
                {
                    worker.Do(part);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДОМ ПОСТРОЕН!");
        }
    }



    interface IPart
    {
        void Build();
    }

    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Постройка фундамента.");
        }
    }

    class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Постройка стены.");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Постройка окна.");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Постройка двери.");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Постройка крыши.");
        }
    }


    class House
    {
        public List<IPart> parts;

        public House()
        {
            this.parts = new List<IPart>();
            this.parts.Add(new Basement());

            for (int i = 0; i < 4; i++)
            {
                this.parts.Add(new Wall());
                this.parts.Add(new Window());
            }

            this.parts.Add(new Door());
            this.parts.Add(new Roof());
        }
    }


    internal class Program
    {
        static void Main()
        {
            Worker worker = new Worker();
            TeamLeader teamLeader = new TeamLeader();

            Team team = new Team();
            team.AddWorker(worker);
            team.AddWorker(teamLeader);

            House house = new House();
            team.BuildHouse(house);
        }
    }
}