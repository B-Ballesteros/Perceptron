using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bballesteros.PNN.Forms
{
    public partial class NewNetworkForm : Form
    {
        public NewNetworkForm()
        {
            InitializeComponent();
        }

        public int[] GetNetworkDimensions()
        {
            var structure = new List<int>();
            structure.Add(Convert.ToInt32(inputUpDown.Value));
            for(var i = 0; i < hiddenUpDown.Value; i++)
            {
                structure.Add(Convert.ToInt32(numberUpDown.Value));
            }
            structure.Add(Convert.ToInt32(outputUpDown.Value));
            return structure.ToArray();
        }

        private void hiddenUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(hiddenUpDown.Value == 0)
            {
                numberUpDown.Enabled = false;
                numberUpDown.Value = numberUpDown.Minimum;
            } else
            {
                numberUpDown.Enabled = true;
            }
        }
    }
}
