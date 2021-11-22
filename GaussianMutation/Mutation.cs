using System;
using System.Collections.Generic;
using System.Text;

namespace GaussianMutation
{
    class Mutation
    {
        double mutationRate;

        public Mutation() { }

        public Mutation(double mutationRate)
        {
            this.mutationRate = mutationRate;
        }

        public void mutate(Population population)
        {
            this.mutate(population, this.mutationRate);
        }

        private void mutate(Population population, double mutationRate)
        {
            Random rand = new Random();
            double popMinValue = population.getMinValue();
            double popMaxValue = population.getMaxValue();
            List<double> individuals = population.getIndividuals();
            for (int characterIndex = 0; characterIndex < individuals.Count; characterIndex++)
            {
                double n = Math.Round(rand.NextDouble(), 2);
                if (n <= mutationRate)
                {
                    while ((popMinValue <= individuals[characterIndex] + n) && (individuals[characterIndex] + n <= popMaxValue))
                    {
                        n = getRandNormal(0, 1);
                    }
                    individuals[characterIndex] = individuals[characterIndex] + n;
                 }
            }
            population.setIndividuals(individuals);
        }

        private static double getRandNormal(double mean, double stdDev)
        {
            Random rand = new Random();
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return Math.Round(mean + stdDev * randStdNormal, 2); //random normal(mean,stdDev^2)
        }
    }
}
