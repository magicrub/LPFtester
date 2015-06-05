using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace filter_tester
{
    public partial class LpfCoefTester : Form
    {
        private bool booting = true; // inhibits filter from running as all UI modules update

        public LpfCoefTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceRegistry(false);
            booting = false;
            handle_general_UI_event();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServiceRegistry(true);
        }

        private void numericUpDown_coef1_ValueChanged(object sender, EventArgs e)
        {
            handle_general_UI_event();
        }
        private void numericUpDown_interval_ValueChanged(object sender, EventArgs e)
        {
            handle_general_UI_event();
        }
        private void numericUpDown_stopThresh_ValueChanged(object sender, EventArgs e)
        {
            handle_general_UI_event();
        }
        private void radioButton_stepUp_CheckedChanged(object sender, EventArgs e)
        {
            handle_general_UI_event();
        }
        private void checkBox_clipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_clipboard.Checked)
                handle_general_UI_event();
        }
        public void handle_general_UI_event()
        {
            // if booting don't execute filter because the all UI values are updating from registry
            // and we dont' want to re-run on each one
            if (booting)
                return;

            execute_filter();
        }

        private void ServiceRegistry(bool WriteSettings)
        {
            if (WriteSettings)
            {
                // write UI values to the registry
                Application.UserAppDataRegistry.SetValue("numericUpDown_interval", numericUpDown_interval.Value);
                Application.UserAppDataRegistry.SetValue("numericUpDown_coef", numericUpDown_coef.Value);                
                Application.UserAppDataRegistry.SetValue("numericUpDown_stopThresh", numericUpDown_stopThresh.Value);
                Application.UserAppDataRegistry.SetValue("radioButton_stepUp", radioButton_stepUp.Checked);
                Application.UserAppDataRegistry.SetValue("checkBox_clipboard", checkBox_clipboard.Checked);                
            }
            else
            {
                // read UI values stored in the registry and populate them
                numericUpDown_interval.Value = Convert.ToDecimal(Application.UserAppDataRegistry.GetValue("numericUpDown_interval", numericUpDown_interval.Value));
                numericUpDown_coef.Value = Convert.ToDecimal(Application.UserAppDataRegistry.GetValue("numericUpDown_coef", numericUpDown_coef.Value));
                numericUpDown_stopThresh.Value = Convert.ToDecimal(Application.UserAppDataRegistry.GetValue("numericUpDown_stopThresh", numericUpDown_stopThresh.Value));
                radioButton_stepUp.Checked = Convert.ToBoolean(Application.UserAppDataRegistry.GetValue("radioButton_stepUp", radioButton_stepUp.Checked));
                radioButton_stepDown.Checked = !radioButton_stepUp.Checked;
                checkBox_clipboard.Checked = Convert.ToBoolean(Application.UserAppDataRegistry.GetValue("checkBox_clipboard", checkBox_clipboard.Checked));
            }
        }


        private void execute_filter()
        {
            StringBuilder str = new StringBuilder();
            float lastOutput, output, input;
            float stop_thresh = Convert.ToSingle(numericUpDown_stopThresh.Value);
            int time_ms = 0, n = 0;
            int interval = Convert.ToInt32(numericUpDown_interval.Value);

            // change casting here for Double or Decimal
            float coef = Convert.ToSingle(numericUpDown_coef.Value);
            float coef_1 = Convert.ToSingle(1 - numericUpDown_coef.Value);
            
            // init with steady-state
            if (radioButton_stepUp.Checked) {
                output = lastOutput = 0;
                input = 1;
            }
            else {
                output = lastOutput = 1;
                input = 0;
            }

            // print steady-state
            str.AppendLine(n.ToString() + "\t" + time_ms.ToString() + "\t" + output.ToString("0.000"));
            
            // loop until the output steps to the input value
            while ((radioButton_stepUp.Checked == true  && (lastOutput <= stop_thresh)) ||
                   (radioButton_stepUp.Checked == false && (lastOutput >= (1-stop_thresh))) )
            {
                time_ms += interval;
                output = (lastOutput * coef_1) + (input * coef); // LPF work
                lastOutput = output;

                str.AppendLine((++n).ToString() + "\t" + time_ms.ToString() + "\t" + output.ToString("0.000"));
            }


            // report results
            label_output.Text = "X[n] = (X[n-1] * " + coef_1.ToString() + ") + (Input *" + coef.ToString() + ")";
            textBox_output.Text = str.ToString();
            label_duration.Text = "Duration = " + (time_ms / 1000.0).ToString("0.000") + " s";

            if (checkBox_clipboard.Checked && str.Length > 0)
            {
                Clipboard.SetText(str.ToString());
            }

        }


    } // class
} // namespace
