using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WasteOnLIfe
{
    public partial class WastedOnLife : Form
    {
        public WastedOnLife()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Input input = new Input(InputTextBox.Text);
            DaysLived.Text = input.DaysLived.ToString();
            HoursLived.Text = input.HoursLived.ToString();
            DaysLeft.Text = input.DaysLeft.ToString();
            DaysToCentury.Text = input.DaysToCentury.ToString();
            NextBitrthday.Text = input.NextBirthday.ToString(); 
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                submitButton.PerformClick();
            }
        }

        private void InputLabel_Click(object sender, EventArgs e)
        {

        }

        private void WastedOnLife_Load(object sender, EventArgs e)
        {

        }
    }
}
