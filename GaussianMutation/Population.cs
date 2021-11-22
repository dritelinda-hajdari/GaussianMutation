using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussianMutation
{
    class Population
    {
        double minValue;
        double maxValue;
        int popLength;
        private List<double> individuals = new List<double>();

        public Population(double minValue, double maxValue, int popLength)
        {
            Random randNum = new Random();
            this.individuals = Enumerable.Repeat(0, popLength).Select(i => Math.Round(randNum.NextDouble() * (maxValue - minValue) + minValue, 2)).ToList();
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public void setIndividuals(List<double> individuals)
        {
            this.individuals = individuals;
        }

        public List<double> getIndividuals()
        {
            return this.individuals;
        }

        public double getMinValue()
        {
            return this.minValue;
        }

        public double getMaxValue()
        {
            return this.maxValue;
        }
    }
}
