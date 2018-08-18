using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    class Weight
    {
        public double Value { get; set; } = new Random().NextDouble() * 2 - 1; 

        public Neuron LinkedNeuron { get; set; }
    }
}
