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
    public partial class xyCommands : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public string PromptX;
        public string PromptY;
        public string Title;

        public xyCommands()
        {
            InitializeComponent();
        }

        private void xyCommands_Load(object sender, EventArgs e)
        {
            Text = Title;
            labelX.Text = PromptX;
            labelY.Text = PromptY;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool failed = false;
            if (int.TryParse(maskedTextBoxX.Text, out int x))
            {
                X = x;
            }
            else
            {
                failed = true;
            }

            if (int.TryParse(maskedTextBoxY.Text, out int y))
            {
                Y = y;
            }
            else
            {
                failed = true;
            }

            if (!failed)
            {
                this.Close();
            }
        }
    }
}
