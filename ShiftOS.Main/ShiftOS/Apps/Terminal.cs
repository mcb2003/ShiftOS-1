﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Main.Terminal;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Terminal : UserControl
    {
        public int TerminalID = TerminalBackend.trmTopID++; // Used so that we can have multiple instances of the terminal whilst the command begin run knowing what terminal to send the text to - very complicated ;)
        public string defaulttextBefore = "user> ";
        public string defaulttextResult = "user@shiftos> "; // NOT YET IMPLEMENTED!!!
        public bool DoClear = false;
        public bool RunningCommand = false;
        public bool WaitingResponse = false;
        public string InputReturnText = "";

        // The below variables makes the terminal... a terminal!
        public string OldText = "";   
        public int TrackingPosition = 0;

        public Terminal()
        {
            InitializeComponent();

            termmain.ContextMenuStrip = new ContextMenuStrip(); // Disables the right click of a richtextbox!

            TerminalBackend.trm.Add(this); // Makes the commands run!
        }

        private void termmain_KeyDown(object sender, KeyEventArgs e)
        {
            // The below code disables the ability to paste anything other then text...

            if (e.Control && e.KeyCode == Keys.V)
            {
                //if (Clipboard.ContainsText())
                //    termmain.Paste(DataFormats.GetFormat(DataFormats.Text));
                e.Handled = true;
            } else if (e.KeyCode == Keys.Enter) {
                RunningCommand = true;
                TerminalBackend.RunCommand(termmain.Text.Substring(TrackingPosition, termmain.Text.Length - TrackingPosition), TerminalID); // The most horrific line in the entire application!
                RunningCommand = false;
                termmain.AppendText($"\n {defaulttextResult}");
                TrackingPosition = termmain.Text.Length;
                e.Handled = true;
            }
        }

        private void termmain_TextChanged(object sender, EventArgs e)
        {
            if (!RunningCommand)
            {
                if (termmain.SelectionStart < TrackingPosition)
                {
                    if (!DoClear) // If it's not clearing the terminal
                    {
                        termmain.Text = OldText;
                        termmain.Select(termmain.Text.Length, 0);
                    }
                }
                else
                {
                    OldText = termmain.Text;
                }
            }
        }

        private void termmain_SelectionChanged(object sender, EventArgs e)
        {
            if (!RunningCommand)
            {
                if (termmain.SelectionStart < TrackingPosition)
                {
                    termmain.Text = OldText;
                    termmain.Select(termmain.Text.Length, 0);
                }
            }
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            termmain.Text = $"\n {defaulttextResult}";
            TrackingPosition = termmain.Text.Length;
        }

        public void Input(string request)
        {
            InputReturnText = "";
            RunningCommand = false;

            termmain.AppendText($"\n {request} ");
            TrackingPosition = termmain.Text.Length;
        }

        public void Clear()
        {
            DoClear = true;
            termmain.Text = $"\n {defaulttextResult}";
            TrackingPosition = termmain.Text.Length;
            DoClear = false;
        }
    }
}
