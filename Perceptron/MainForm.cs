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
    public partial class MainForm : Form
    {
        NeuralNetwork network;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateNetwork()
        {
            UpdateStatus("Creating network", true);
            var createForm = new NewNetworkForm();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                var structure = createForm.GetNetworkDimensions();
                network = new NeuralNetwork(structure);
                var message = $"Created network with {structure[0]} inputs, {structure.Length - 2} " +
                    $"hidden layers and {structure[structure.Length - 1]} outputs";
                UpdateStatus(message, false);
            } else
            {
                UpdateStatus("Operation Canceled", false);
            }
        }

        private void UpdateStatus(string message, bool animate)
        {
            statusProgressBar.Style = !animate ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
            statusLabel.Text = message;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            
            CreateNetwork();
        }
    }
}
