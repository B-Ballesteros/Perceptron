using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace bballesteros.PNN
{
    class Neuron
    {
        private double output = double.MinValue;
        public double Output {
            get
            {
                if (output != double.MinValue)
                {
                    return output;
                }else
                {
                    return SigmodiFunction();
                }
            }
            set { output = value; }
        }
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
        {
            Error = 0;
            Input = 0;
            foreach (var weight in Weights)
            {
                Input += weight.Value * weight.LinkedNeuron.Output;
            }
        }

        public void AccumulateError()
        { }

        public void AdjustWeights()
        { }


        private double SigmodiFunction()
        {
            return 1 / (1 + Exp(-Gradient * (Input + Bias)));
        }
    }
}