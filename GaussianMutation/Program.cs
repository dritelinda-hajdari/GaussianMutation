using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussianMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Gaussian Mutation--------------");
            List<Population> populationList = new List<Population>();
            for (int i = 0; i < 100; i++) 
            {
                Population population = new Population(-5, 5, 10);
                populationList.Add(population);
            }

            print(populationList[0].getIndividuals());
            
            Mutation gaussianMutation = new Mutation(0.4);
            gaussianMutation.mutate(populationList[0]);
            print(populationList[0].getIndividuals());

            Console.ReadKey();
        }

        public static void print(List<double> items)
        {
            Console.WriteLine();
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write(Math.Round(items[i], 2) + ", ");
            }
            Console.WriteLine();
        }
     }
}
