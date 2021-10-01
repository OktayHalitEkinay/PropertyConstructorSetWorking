using ClassLibrary.Business;
using ClassLibrary.Results;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = new EntityManager();
            Result result = entityManager.Add();
            Console.WriteLine(result.Message+","+result.Success) ;
            Console.ReadLine();
        }
    }
}
