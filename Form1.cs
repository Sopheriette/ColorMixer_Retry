namespace ColorMixer_Retry
{
    public partial class Form1 : Form
    {

        int redMixerValue = 0;
        int greenMixerValue = 0;
        int blueMixerValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void boxRed_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericRed.Value;
            int greenValue = 0;
            int blueValue = 0;

            redMixerValue = redValue;

            boxRed.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);
        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = (int)numericGreen.Value;
            int blueValue = 0;

            greenMixerValue = greenValue;

            boxGreen.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);
        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = 0;
            int blueValue = (int)numericGreen.Value;

            blueMixerValue = blueValue;

            boxBlue.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}