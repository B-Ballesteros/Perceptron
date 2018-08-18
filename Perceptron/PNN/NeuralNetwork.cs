using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    class NeuralNetwork: List<NeuralLayer>
    {
        public NeuralLayer Inputs { get { return base[0]; } }
        public NeuralLayer Outputs { get { return base[base.Count - 1]; } }

        public NeuralNetwork() { }
        public NeuralNetwork(int[] structure) { }


        public void Train() { }

        private void AdjustWeights() { }

        private void Activate()
        {
            foreach(var layer in this)
            {
                foreach(var neuron in layer)
                {
                    neuron.Activate();
                }
            }
        }

    }
}
