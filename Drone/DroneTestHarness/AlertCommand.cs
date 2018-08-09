using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneTestHarness
{
    public partial class AlertCommand : Form
    {
        public int Seconds { get; private set; }
        public AlertCommand()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBoxSeconds.Text, out int s))
            {
                Seconds = s;
                this.Close();
            }
        }
    }
}
