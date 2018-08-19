using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace bballesteros.PNN
{
    class NeuralNetwork: List<NeuralLayer>
    {
        public NeuralLayer Inputs { get { return this[0]; } }
        public NeuralLayer Outputs { get { return this[Count - 1]; } }

        public NeuralNetwork() { }
        public NeuralNetwork(int[] structure)
        {
            Add(new NeuralLayer(structure[0]));
            for(var i = 1; i < structure.Length; i++)
            {
                Add(new NeuralLayer(structure[i], this[i - 1]));
            }
        }


        public void Train() { }

        private void AdjustWeights()
        {
            for(var i = Count -1; i > 0; i--) //Backward Propagation
            {
                foreach(var neuron in this[i])
                {
                    neuron.AdjustWeights();
                }
            }
        }

        private void Activate(Pattern pattern)
        {
            if(pattern.Inputs.Length != Inputs.Count)
            {
                throw new ArgumentException(
                    "Configuration mismatch.\n The number of pattern inputs must be equal to the number of the input neurons in the network");
            }
            for(var i = 0; i < Inputs.Count; i++)
            {
                Inputs[i].Output = pattern.Inputs[i];
            }
            foreach(var layer in this)
            {
                foreach(var neuron in layer)
                {
                    neuron.Activate();
                }
            }
        }

        public void Train(List<Pattern> patterns)
        {
            double totalError = 0;
            do
            {
                totalError = 0;
                foreach(var pattern in patterns)
                {
                    Activate(pattern); //Forward Propagation
                    for (var i = 0; i < Outputs.Count; i++)
                    {
                        var delta = -(pattern.Outputs[i] - Outputs[i].Output);
                        Outputs[i].AccumulateError(delta);
                        totalError += 0.5 * Pow(delta, 2);
                    }
                    AdjustWeights();
                }
            } while (totalError > 0.01);
        }

    }
}
