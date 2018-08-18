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
        { }

        public NeuralLayer(int size, NeuralLayer inputLayer)
        { }
    }
}
