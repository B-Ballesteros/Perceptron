using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bballesteros.PNN.Utils;

namespace bballesteros.PNN.Forms
{
    public partial class MainForm : Form
    {
        NeuralNetwork network;
        Patterns patterns;

        private delegate void UpdateLogHandler(TextBox textBox, string message);

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
                //network.ErrorValueChanged += ErrorValueChanged;
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


        private void SelectPatternsFile()
        {
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = oFD.FileName;
                patterns = new Patterns(oFD.FileName, network?.Inputs?.Count ?? 0, network?.Outputs?.Count ?? 0);
                logTextBox.Text += $"\n{patterns.Count} Patterns loaded.";
            } else
            {
                fileTextBox.Text = string.Empty;
            }
        }

        private void UpdateLog(TextBox textBox, string message)
        {
            textBox.Text += message;
        }

        private async Task<long> TrainNetworkAsync()
        {

            var progress = new Progress<double>(error =>
            {
                errorChart.Series[0].Points.AddY(error);
                errorChart.Update();
            });
            var result = await Task.Factory.StartNew(() => network.Train(patterns, progress), TaskCreationOptions.LongRunning);
            return result.Result;
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            
            CreateNetwork();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SelectPatternsFile();
        }

        private void ErrorValueChanged(NeuralNetworkEventArgs e)
        {
            var message = $"\r\n Current Error Value: {e.Value}";
            System.Diagnostics.Debug.WriteLine(e.Value);
        }

        private async void TrainButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += "\r\nTraining.";
            var result = await TrainNetworkAsync();
            statusLabel.Text = $"Training finished after {result} iterations.";
        }
    }
}
