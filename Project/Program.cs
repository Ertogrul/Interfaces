using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İmplementasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            ISalary[] salarys = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salarys)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eated");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Worked");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eated");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Worked");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Worked");
        }
    }
}