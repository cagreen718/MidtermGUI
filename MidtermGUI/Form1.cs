using System.Security.Cryptography;

namespace MidtermGUI
{
    public partial class Form1 : Form
    {  //source: https://stackoverflow.com/questions/1236402/how-to-set-a-constant-decimal-value 

        
        decimal convertMeter = 0.0254m;
        decimal convertInch = 39.96m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { //clear
            textBox2.Clear();
            textTotal.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {//source:  https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0
            // Input Validation
            if (!decimal.TryParse(textBox2.Text, out decimal decMeasure))
            {
                MessageBox.Show("Invalid input. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return;
                
            }
            else
            {
                if (radioButton1.Checked)
                {
                    decimal metersToinches = convertMeter * decMeasure;
                    textTotal.Text = metersToinches.ToString();
                    return;
                }
                if (radioButton2.Checked)
                {
                    decimal inchesTometers = convertInch * decMeasure;
                    textTotal.Text = inchesTometers.ToString();
                    return;
                }
            }
          
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
