using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    class Neuron
    {
        public double Output { get; set; }
        public double Delta { get; set; }
        public double Bias { get; set; }
        public double Error { get; set; }
        public double Input { get; set; }
        public double Gradient { get; set; }
        public List<Weight> Weights { get; set; }

        public Neuron() { }

        public Neuron(NeuralLayer inputLayer)
        { }

        public void Activate()
        { }

        public void AccumulateError()
        { }

        public void AdjustWeights()
        { }
    }
}