using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drone;
using Drone.Commands;

namespace DroneTestHarness
{
    public partial class TestHarness : Form
    {
        delegate void SetSenderEventArgsCallback(object sender, Drone.StateEventArgs e);
        private Drone.State _droneState;

        private void AddCommand(string instruction) => this.listBoxCommands.Items.Add(instruction);
        public TestHarness() { InitializeComponent(); }

        private void buttonClearList_Click(object sender, EventArgs e) => this.listBoxCommands.Items.Clear();

        private void buttonAlert_Click(object sender, EventArgs e)
        {
            AlertCommand ac = new AlertCommand();
            if (ac.ShowDialog(this) == DialogResult.OK) { AddCommand($"A{ac.Seconds.ToString()}"); }
        }

        private void buttonToggleLights_Click(object sender, EventArgs e) => AddCommand("T");

        private void buttonHome_Click(object sender, EventArgs e) => AddCommand("H");

        private void buttonShutdown_Click(object sender, EventArgs e) => AddCommand("D");

        private void buttonRestart_Click(object sender, EventArgs e) => AddCommand("R");

        private void buttonStart_Click(object sender, EventArgs e) => AddCommand("S");

        private void buttonBoundary_Click(object sender, EventArgs e)
        {
            xyCommands xy = new xyCommands();
            xy.Title = "Boundary Command";
            xy.PromptX = "Enter value for X";
            xy.PromptY = "Enter value for Y";

            if (xy.ShowDialog(this) == DialogResult.OK) { AddCommand($"B{xy.X.ToString()},{xy.Y.ToString()}"); }
        }

        private void buttonInitialPosition_Click(object sender, EventArgs e)
        {
            xyCommands xy = new xyCommands();
            xy.Title = "Initial Position Command";
            xy.PromptX = "Enter value for X";
            xy.PromptY = "Enter value for Y";

            if (xy.ShowDialog(this) == DialogResult.OK) { AddCommand($"P{xy.X.ToString()},{xy.Y.ToString()}"); }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            xyCommands xy = new xyCommands();
            xy.Title = "Move Command";
            xy.PromptX = "Enter time (seconds)";
            xy.PromptY = "Enter direction (degrees)";

            if (xy.ShowDialog(this) == DialogResult.OK) { AddCommand($"M{xy.X.ToString()},{xy.Y.ToString()}"); }
        }

        private void TestHarness_Load(object sender, EventArgs e)
        {
            _droneState = new Drone.State();
            _droneState.StateChange += StateChange;
            _droneState.StateError += StateError;
        }

        private void StateError(object sender, StateEventArgs e)
        {
            if (this.InvokeRequired)
            {
                SetSenderEventArgsCallback d = new SetSenderEventArgsCallback(StateError);
                try { this.Invoke(d, new object[] { sender, e }); }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show(this,
                    $"{e.Message}\n\nCommand was {e.Command.Instruction} for the {e.Command.GetType().Name} command",
                    "Error in drone state");
            }
        }

        private void StateChange(object sender, StateEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonClearText_Click(object sender, EventArgs e) => this.textBoxCommandList.Text = string.Empty;

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<string> commandTextList;
                string commandText = this.textBoxCommandList.SelectionLength > 0
                    ? this.textBoxCommandList.SelectedText
                    : this.textBoxCommandList.Text;

                commandTextList = commandText.Split(new char[] {'\n', '\t', ' '},
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string instruction in commandTextList)
                {
                    _droneState.AddCommand(instruction.Replace("\r",string.Empty));
                }
            }
            catch (InvalidStateException ex)
            {
                MessageBox.Show(this, ex.Message,"Invalid State for command");
            }
            catch (InvalidCommandException ex)
            {
                MessageBox.Show(this,ex.Message, "Invalid Command");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message , "Some other type of exception happened.");
            }
        }
    }
}
