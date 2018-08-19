using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    class NeuralLayer: List<Neuron>
    {
        public NeuralLayer() { }

        public NeuralLayer(int size)
        {
            for (var i = 0; i < size; i++)
            {
                Add(new Neuron());
            }
        }

        public NeuralLayer(int size, NeuralLayer inputLayer)
        {
            for(var i= 0; i < size; i++)
            {
                Add(new Neuron(inputLayer));
            }
        }
    }
}
