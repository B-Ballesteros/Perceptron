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
        public double Steepness { get; set; } = 1;
        public double LearningRatio = 0.01;
        public List<Weight> Weights { get; set; }

        public Neuron() { }

        public Neuron(NeuralLayer inputLayer)
        {
            Weights = new List<Weight>();
            foreach(var neuron in inputLayer)
            {
                var weight = new Weight { LinkedNeuron = neuron };
                Weights.Add(weight);
            }
        }

        public void Activate()
        {
            Error = 0;
            Input = 0;
            foreach (var weight in Weights)
            {
                Input += weight.Value * weight.LinkedNeuron.Output;
            }
        }

        public void AccumulateError(double delta)
        {
            Error += delta;
            if (Weights != null) {
                foreach (var weight in Weights) //Propagates the error to the inner layers
                {
                    weight.LinkedNeuron.AccumulateError(Error * weight.Value);
                }
            }
        }

        public void AdjustWeights()
        {
            var partialDerivative = CalculatePartialDerivative();
            foreach (var weight in Weights)
            {
                weight.Value += LearningRatio * partialDerivative * weight.LinkedNeuron.Output;
            }
            Bias += partialDerivative * LearningRatio;
        }


        private double SigmodiFunction()
        {
            return 1 / (1 + Exp(-Steepness * (Input + Bias)));
        }

        private double CalculatePartialDerivative()
        {
            var outputValue = Output;
            return  Error * (outputValue * (1 - outputValue));
        }
    }
}