using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    public class NeuralNetworkEventArgs: EventArgs
    {
        public double Value { get; private set; }

        public NeuralNetworkEventArgs(double value)
        {
            Value = value;
        }
    }
}
