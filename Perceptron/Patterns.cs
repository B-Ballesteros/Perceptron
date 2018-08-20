using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bballesteros.PNN
{
    public class Patterns: List<Pattern>
    {
        public Patterns(string file, int inputCount, int outputCount) : base()
        {
            LoadPatterns(file, inputCount, outputCount);
        }

        private void LoadPatterns(string file, int inputCount, int outputCount)
        {
            var reader = File.OpenText(file);
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var pattern = new Pattern(line, inputCount, outputCount);
                Add(pattern);
            }
        }
    }
}
