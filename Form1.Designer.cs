namespace ColorMixer_Retry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            boxRed = new PictureBox();
            numericRed = new NumericUpDown();
            numericGreen = new NumericUpDown();
            boxGreen = new PictureBox();
            numericBlue = new NumericUpDown();
            boxBlue = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)boxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxBlue).BeginInit();
            SuspendLayout();
            // 
            // boxRed
            // 
            boxRed.Location = new Point(103, 12);
            boxRed.Name = "boxRed";
            boxRed.Size = new Size(200, 200);
            boxRed.TabIndex = 0;
            boxRed.TabStop = false;
            boxRed.Click += boxRed_Click;
            // 
            // numericRed
            // 
            numericRed.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericRed.Location = new Point(139, 218);
            numericRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(120, 50);
            numericRed.TabIndex = 1;
            numericRed.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericGreen.Location = new Point(345, 218);
            numericGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(120, 50);
            numericGreen.TabIndex = 3;
            numericGreen.ValueChanged += numericGreen_ValueChanged;
            // 
            // boxGreen
            // 
            boxGreen.Location = new Point(309, 12);
            boxGreen.Name = "boxGreen";
            boxGreen.Size = new Size(200, 200);
            boxGreen.TabIndex = 2;
            boxGreen.TabStop = false;
            // 
            // numericBlue
            // 
            numericBlue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericBlue.Location = new Point(551, 218);
            numericBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(120, 50);
            numericBlue.TabIndex = 5;
            numericBlue.ValueChanged += numericBlue_ValueChanged;
            // 
            // boxBlue
            // 
            boxBlue.Location = new Point(515, 12);
            boxBlue.Name = "boxBlue";
            boxBlue.Size = new Size(200, 200);
            boxBlue.TabIndex = 4;
            boxBlue.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericBlue);
            Controls.Add(boxBlue);
            Controls.Add(numericGreen);
            Controls.Add(boxGreen);
            Controls.Add(numericRed);
            Controls.Add(boxRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)boxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxBlue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox boxRed;
        private NumericUpDown numericRed;
        private NumericUpDown numericGreen;
        private PictureBox boxGreen;
        private NumericUpDown numericBlue;
        private PictureBox boxBlue;
    }
}