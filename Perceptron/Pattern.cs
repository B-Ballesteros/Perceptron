using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    public class Pattern
    {
        public double[] Inputs { get; private set; }
        public double[] Outputs { get; private set; }

        public Pattern() { }

        public Pattern(int inputDimensions, int outputDimensions = 0)
        {
            if (inputDimensions < 0 || outputDimensions < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Value.\n The dimensions should be a positive integer.");
            }
            if (inputDimensions == 0)
            {
                throw new ArgumentException("InputDimension can't be 0. ");
            }
            Inputs = new double[inputDimensions];
            if (outputDimensions != 0)
            {
                Outputs = new double[outputDimensions];
            }
        }

        public Pattern(double[] inputs, double[] outputs = null)
        {
            Inputs = inputs ?? throw new ArgumentException("Inputs can't be null.");
            Outputs = outputs;
        }
    }
}
