namespace bballesteros.PNN.Forms
{
    partial class NewNetworkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputUpDown = new System.Windows.Forms.NumericUpDown();
            this.outputUpDown = new System.Windows.Forms.NumericUpDown();
            this.hiddenUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUpDown
            // 
            this.inputUpDown.Location = new System.Drawing.Point(189, 25);
            this.inputUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputUpDown.Name = "inputUpDown";
            this.inputUpDown.Size = new System.Drawing.Size(120, 22);
            this.inputUpDown.TabIndex = 0;
            this.inputUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // outputUpDown
            // 
            this.outputUpDown.Location = new System.Drawing.Point(189, 53);
            this.outputUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputUpDown.Name = "outputUpDown";
            this.outputUpDown.Size = new System.Drawing.Size(120, 22);
            this.outputUpDown.TabIndex = 1;
            this.outputUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hiddenUpDown
            // 
            this.hiddenUpDown.Location = new System.Drawing.Point(189, 81);
            this.hiddenUpDown.Name = "hiddenUpDown";
            this.hiddenUpDown.Size = new System.Drawing.Size(120, 22);
            this.hiddenUpDown.TabIndex = 2;
            this.hiddenUpDown.ValueChanged += new System.EventHandler(this.hiddenUpDown_ValueChanged);
            // 
            // numberUpDown
            // 
            this.numberUpDown.Enabled = false;
            this.numberUpDown.Location = new System.Drawing.Point(189, 109);
            this.numberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(120, 22);
            this.numberUpDown.TabIndex = 3;
            this.numberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Neurons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Neurons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hidden Layers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Neurons in Hidden Layer";
            // 
            // createButton
            // 
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(12, 154);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 40);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(209, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 203);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberUpDown);
            this.Controls.Add(this.hiddenUpDown);
            this.Controls.Add(this.outputUpDown);
            this.Controls.Add(this.inputUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "NewNetworkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.inputUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputUpDown;
        private System.Windows.Forms.NumericUpDown outputUpDown;
        private System.Windows.Forms.NumericUpDown hiddenUpDown;
        private System.Windows.Forms.NumericUpDown numberUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
    }
}