using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ED_05_Case_Report_Assignment
{
    public partial class Main : Form
    {
        public string currentForm = "currentForm_data.txt";
        public string previousForm = "previousForm_data.txt";

        public string p1_s = "phase1_saved.txt";
        public string p1_c = "phase1_completed.txt";

        public string p2_s = "phase2_saved.txt";
        public string p2_c = "phase2_completed.txt";

        public string p3_s = "phase3_saved.txt";
        public string p3_c = "phase3_completed.txt";

        public string p4_s = "phase4_saved.txt";
        public string p4_c = "phase4_completed.txt";

        public string p5_s = "phase5_saved.txt";
        public string p5_c = "phase5_completed.txt";

        public bool Phase1Complete = false;
        public bool Phase2Complete = false;
        public bool Phase3Complete = false;
        public bool Phase4Complete = false;
        public bool Phase5Complete = false;

        public bool Phase1Saved = false;
        public bool Phase2Saved = false;
        public bool Phase3Saved = false;
        public bool Phase4Saved = false;
        public bool Phase5Saved = false;

        public bool View1 = false;
        public bool View2 = false;
        public bool View3 = false;
        public bool View4 = false;
        public bool View5 = false;

        public bool viewSaved1 = false;
        public bool viewSaved2 = false;
        public bool viewSaved3 = false;
        public bool viewSaved4 = false;
        public bool viewSaved5 = false;

        public int Loads = 1;

        public int Complete;

        public bool formInProgress = false;
        public bool newForm = false;

        public Main()
        {
            InitializeComponent();
        }

        private void LoadForm_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(previousForm);
            String txt = sr.ReadToEnd();
            sr.Close();

            if (txt.Contains("none"))
            {
                DialogResult result1 = MessageBox.Show("The current form will be saved and a new form will be started." +
                    " \nAre you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    if (Phase1Saved || Phase1Complete)
                    {
                        if (Phase1Complete)
                        {
                            StreamReader s = new StreamReader(p1_c);
                            StreamWriter w = new StreamWriter(previousForm);
                            for (int i = 0; i <= 14; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p1_s);
                            StreamWriter w = new StreamWriter(previousForm);
                            for (int i = 0; i <= 14; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase2Saved || Phase2Complete)
                    {
                        if (Phase2Complete)
                        {
                            StreamReader s = new StreamReader(p2_c);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 6; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p2_s);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 6; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase3Saved || Phase3Complete)
                    {
                        if (Phase3Complete)
                        {
                            StreamReader s = new StreamReader(p3_c);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 4; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p3_s);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 4; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase4Saved || Phase4Complete)
                    {
                        if (Phase4Complete)
                        {
                            StreamReader s = new StreamReader(p4_c);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p4_s);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase5Saved || Phase5Complete)
                    {
                        if (Phase5Complete)
                        {
                            StreamReader s = new StreamReader(p5_c);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p5_s);
                            StreamWriter w = new StreamWriter(previousForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }

                    phase1Button.Enabled = false;
                    phase2Button.Enabled = false;
                    phase3Button.Enabled = false;
                    phase4Button.Enabled = false;
                    phase5Button.Enabled = false;

                    viewBtn1.Visible = false;
                    viewBtn2.Visible = false;
                    viewBtn3.Visible = false;
                    viewBtn4.Visible = false;
                    viewBtn5.Visible = false;

                    View1 = false;
                    View2 = false;
                    View3 = false;
                    View4 = false;
                    View5 = false;

                    StreamWriter w11 = new StreamWriter(p1_s);
                    for (int i = 0; i <= 12; i++)
                    {
                        w11.WriteLine();
                    }
                    w11.Close();

                    StreamWriter wr11 = new StreamWriter(p1_c);
                    for (int i = 0; i <= 12; i++)
                    {
                        wr11.WriteLine();
                    }
                    wr11.Close();

                    StreamWriter w22 = new StreamWriter(p2_s);
                    for (int i = 0; i <= 4; i++)
                    {
                        w22.WriteLine();
                    }
                    w22.Close();

                    StreamWriter wr22 = new StreamWriter(p2_c);
                    for (int i = 0; i <= 4; i++)
                    {
                        wr22.WriteLine();
                    }
                    wr22.Close();

                    StreamWriter w33 = new StreamWriter(p3_s);
                    for (int i = 0; i <= 2; i++)
                    {
                        w33.WriteLine();
                    }
                    w33.Close();

                    StreamWriter wr33 = new StreamWriter(p3_c);
                    for (int i = 0; i <= 2; i++)
                    {
                        wr33.WriteLine();
                    }
                    wr33.Close();

                    StreamWriter w44 = new StreamWriter(p4_s);
                    for (int i = 0; i <= 6; i++)
                    {
                        w44.WriteLine();
                    }
                    w44.Close();

                    StreamWriter wr44 = new StreamWriter(p4_c);
                    for (int i = 0; i <= 6; i++)
                    {
                        wr44.WriteLine();
                    }
                    wr44.Close();

                    StreamWriter w55 = new StreamWriter(p5_s);
                    for (int i = 0; i <= 6; i++)
                    {
                        w55.WriteLine();
                    }
                    w55.Close();

                    StreamWriter wr55 = new StreamWriter(p5_c);
                    for (int i = 0; i <= 6; i++)
                    {
                        wr55.WriteLine();
                    }
                    wr55.Close();

                    Phase1 p1 = new Phase1(this);
                    p1.Show();
                }
            } else
            {
                DialogResult result = MessageBox.Show("The current form will be saved and overwritten with the previous form's " +
                "progress. \nAre you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    if (Phase1Saved || Phase1Complete)
                    {
                        if (Phase1Complete)
                        {
                            StreamReader s = new StreamReader(p1_c);
                            StreamWriter w = new StreamWriter(currentForm);
                            for (int i = 0; i <= 14; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                        else
                        {
                            StreamReader s = new StreamReader(p1_s);
                            StreamWriter w = new StreamWriter(currentForm);
                            for (int i = 0; i <= 14; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase2Saved || Phase2Complete)
                    {
                        if (Phase2Complete)
                        {
                            StreamReader s = new StreamReader(p2_c);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 6; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p2_s);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 6; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase3Saved || Phase3Complete)
                    {
                        if (Phase3Complete)
                        {
                            StreamReader s = new StreamReader(p3_c);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 4; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p3_s);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 4; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase4Saved || Phase4Complete)
                    {
                        if (Phase4Complete)
                        {
                            StreamReader s = new StreamReader(p4_c);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p4_s);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }
                    if (Phase5Saved || Phase5Complete)
                    {
                        if (Phase5Complete)
                        {
                            StreamReader s = new StreamReader(p5_c);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();

                        }
                        else
                        {
                            StreamReader s = new StreamReader(p5_s);
                            StreamWriter w = new StreamWriter(currentForm, true);
                            for (int i = 0; i <= 8; i++)
                            {
                                w.WriteLine(s.ReadLine());
                            }
                            w.Close();
                            s.Close();
                        }
                    }

                    phase1Button.Enabled = false;
                    phase2Button.Enabled = false;
                    phase3Button.Enabled = false;
                    phase4Button.Enabled = false;
                    phase5Button.Enabled = false;

                    viewBtn1.Visible = false;
                    viewBtn2.Visible = false;
                    viewBtn3.Visible = false;
                    viewBtn4.Visible = false;
                    viewBtn5.Visible = false;

                    View1 = false;
                    View2 = false;
                    View3 = false;
                    View4 = false;
                    View5 = false;

                    String currentFormText = "";
                    String previousFormText = "";

                    StreamReader r1 = new StreamReader(currentForm);
                    currentFormText = r1.ReadToEnd();
                    r1.Close();

                    

                    StreamReader r2 = new StreamReader(previousForm);
                    while (!r2.EndOfStream)
                    {
                        String line = r2.ReadLine().Trim();

                        switch (line)
                        {
                            case "Phase1Saved":
                                {
                                    phase1Button.Enabled = true;

                                    break;
                                }
                            case "Phase1Complete":
                                {
                                    viewBtn1.Visible = true;

                                    phase2Button.Enabled = true;

                                    break;
                                }
                            case "Phase2Saved":
                                {
                                    viewBtn1.Visible = true;

                                    phase1Button.Enabled = false;
                                    phase2Button.Enabled = true;

                                    break;
                                }
                            case "Phase2Complete":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;

                                    phase1Button.Enabled = false;
                                    phase2Button.Enabled = false;
                                    phase3Button.Enabled = true;

                                    break;
                                }
                            case "Phase3Saved":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;

                                    phase3Button.Enabled = true;

                                    break;
                                }
                            case "Phase3Complete":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;
                                    viewBtn3.Visible = true;

                                    phase1Button.Enabled = false;
                                    phase2Button.Enabled = false;
                                    phase3Button.Enabled = false;
                                    phase4Button.Enabled = true;

                                    break;
                                }
                            case "Phase4Saved":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;
                                    viewBtn3.Visible = true;

                                    phase4Button.Enabled = true;

                                    break;
                                }
                            case "Phase4Complete":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;
                                    viewBtn3.Visible = true;
                                    viewBtn4.Visible = true;

                                    phase1Button.Enabled = false;
                                    phase2Button.Enabled = false;
                                    phase3Button.Enabled = false;
                                    phase4Button.Enabled = false;
                                    phase5Button.Enabled = true;

                                    break;
                                }
                            case "Phase5Saved":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;
                                    viewBtn3.Visible = true;
                                    viewBtn4.Visible = true;

                                    phase5Button.Enabled = true;

                                    break;
                                }
                            case "Phase5Complete":
                                {
                                    viewBtn1.Visible = true;
                                    viewBtn2.Visible = true;
                                    viewBtn3.Visible = true;
                                    viewBtn4.Visible = true;
                                    viewBtn5.Visible = true;

                                    phase1Button.Enabled = false;
                                    phase2Button.Enabled = false;
                                    phase3Button.Enabled = false;
                                    phase4Button.Enabled = false;
                                    phase5Button.Enabled = false;

                                    break;
                                }
                        }
                    }
                    r2.Close();

                    StreamReader r3 = new StreamReader(previousForm);
                    previousFormText = r3.ReadToEnd();
                    r3.Close();

                    StreamWriter w1 = new StreamWriter(previousForm);
                    w1.Write(currentFormText);
                    w1.Close();

                    StreamWriter w2 = new StreamWriter(currentForm);
                    w2.Write(previousFormText);
                    w2.Close();

                    StreamWriter w11 = new StreamWriter(p1_s);
                    for (int i = 0; i <= 12; i++)
                    {
                        w11.WriteLine();
                    }
                    w11.Close();

                    StreamWriter wr11 = new StreamWriter(p1_c);
                    for (int i = 0; i <= 12; i++)
                    {
                        wr11.WriteLine();
                    }
                    wr11.Close();

                    StreamWriter w22 = new StreamWriter(p2_s);
                    for (int i = 0; i <= 4; i++)
                    {
                        w22.WriteLine();
                    }
                    w22.Close();

                    StreamWriter wr22 = new StreamWriter(p2_c);
                    for (int i = 0; i <= 4; i++)
                    {
                        wr22.WriteLine();
                    }
                    wr22.Close();

                    StreamWriter w33 = new StreamWriter(p3_s);
                    for (int i = 0; i <= 2; i++)
                    {
                        w33.WriteLine();
                    }
                    w33.Close();

                    StreamWriter wr33 = new StreamWriter(p3_c);
                    for (int i = 0; i <= 2; i++)
                    {
                        wr33.WriteLine();
                    }
                    wr33.Close();

                    StreamWriter w44 = new StreamWriter(p4_s);
                    for (int i = 0; i <= 6; i++)
                    {
                        w44.WriteLine();
                    }
                    w44.Close();

                    StreamWriter wr44 = new StreamWriter(p4_c);
                    for (int i = 0; i <= 6; i++)
                    {
                        wr44.WriteLine();
                    }
                    wr44.Close();

                    StreamWriter w55 = new StreamWriter(p5_s);
                    for (int i = 0; i <= 6; i++)
                    {
                        w55.WriteLine();
                    }
                    w55.Close();

                    StreamWriter wr55 = new StreamWriter(p5_c);
                    for (int i = 0; i <= 6; i++)
                    {
                        wr55.WriteLine();
                    }
                    wr55.Close();

                    StreamReader read = new StreamReader(currentForm);
                    int lines = 0;

                    Boolean p1c = false;
                    Boolean p1s = false;
                    Boolean p2c = false;
                    Boolean p2s = false;
                    Boolean p3c = false;
                    Boolean p3s = false;
                    Boolean p4c = false;
                    Boolean p4s = false;
                    Boolean p5c = false;
                    Boolean p5s = false;

                    while (!read.EndOfStream)
                    {
                        lines++;
                        String current = read.ReadLine();
                        switch (lines)
                        {
                            case 13:
                                {
                                    if (current == "Phase1Complete")
                                    {
                                        p1c = true;
                                    } else if (current == "Phase1Saved")
                                    {
                                        p1s = true;
                                    }
                    
                                    break;
                                }

                            case 20:
                                {
                                    if (current == "Phase2Complete")
                                    {
                                        p2c = true;
                                    }
                                    else if (current == "Phase2Saved")
                                    {
                                        p2s = true;
                                    }

                                    break;
                                }

                            case 25:
                                {
                                    if (current == "Phase3Complete")
                                    {
                                        p3c = true;
                                    }
                                    else if (current == "Phase3Saved")
                                    {
                                        p3s = true;
                                    }

                                    break;
                                }

                            case 34:
                                {
                                    if (current == "Phase4Complete")
                                    {
                                        p4c = true;
                                    }
                                    else if (current == "Phase4Saved")
                                    {
                                        p4s = true;
                                    }

                                    break;
                                }

                            case 43:
                                {
                                    if (current == "Phase5Complete")
                                    {
                                        p5c = true;
                                    }
                                    else if (current == "Phase5Saved")
                                    {
                                        p5s = true;
                                    }

                                    break;
                                }
                        }
                    }
                    read.Close();

                    StreamReader read2 = new StreamReader(currentForm);
                    int count = 1;

                    String garbage = "";

                    if (count == 1)
                    {
                        if (p1c)
                        {
                            StreamWriter w = new StreamWriter(p1_c);
                            for (int i = 1; i <= 13; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 16;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                        else if (p1s)
                        {
                            StreamWriter w = new StreamWriter(p1_s);
                            for (int i = 1; i <= 13; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 16;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                    }
                    if (count == 16)
                    {
                        if (p2c)
                        {
                            StreamWriter w = new StreamWriter(p2_c);
                            for (int i = 16; i <= 20; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 23;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                        else if (p2s)
                        {
                            StreamWriter w = new StreamWriter(p2_s);
                            for (int i = 16; i <= 20; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 23;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                    }
                    if (count == 23)
                    {
                        if (p3c)
                        {
                            StreamWriter w = new StreamWriter(p3_c);
                            for (int i = 23; i <= 25; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 28;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                        else if (p3s)
                        {
                            StreamWriter w = new StreamWriter(p3_s);
                            for (int i = 23; i <= 25; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 28;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                    }
                    if (count == 28)
                    {
                        if (p4c)
                        {
                            StreamWriter w = new StreamWriter(p4_c);
                            for (int i = 28; i <= 34; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 37;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                        else if (p4s)
                        {
                            StreamWriter w = new StreamWriter(p4_s);
                            for (int i = 28; i <= 34; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            count = 37;
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                    }
                    if (count == 37)
                    {
                        if (p5c)
                        {
                            StreamWriter w = new StreamWriter(p5_c);
                            for (int i = 37; i <= 43; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                        else if (p5s)
                        {
                            StreamWriter w = new StreamWriter(p5_s);
                            for (int i = 37; i <= 43; i++)
                            {
                                w.WriteLine(read2.ReadLine());
                            }
                            w.Close();
                            garbage = read2.ReadLine();
                            garbage = read2.ReadLine();
                        }
                    }
                    read2.Close();
                } else
                {
                    this.Close();
                }
            }
        }
        private void NewForm_Click(object sender, EventArgs e)
        {
            StreamWriter previous = new StreamWriter(previousForm);
            previous.WriteLine("none");
            previous.Close();

            StreamWriter w1 = new StreamWriter(p1_s);
            for (int i = 0; i <= 12; i++)
            {
                w1.WriteLine();
            }
            w1.Close();

            StreamWriter wr1 = new StreamWriter(p1_c);
            for (int i = 0; i <= 12; i++)
            {
                wr1.WriteLine();
            }
            wr1.Close();

            StreamWriter w2 = new StreamWriter(p2_s);
            for (int i = 0; i <= 4; i++)
            {
                w2.WriteLine();
            }
            w2.Close();

            StreamWriter wr2 = new StreamWriter(p2_c);
            for (int i = 0; i <= 4; i++)
            {
                wr2.WriteLine();
            }
            wr2.Close();

            StreamWriter w3 = new StreamWriter(p3_s);
            for (int i = 0; i <= 2; i++)
            {
                w3.WriteLine();
            }
            w3.Close();

            StreamWriter wr3 = new StreamWriter(p3_c);
            for (int i = 0; i <= 2; i++)
            {
                wr3.WriteLine();
            }
            wr3.Close();

            StreamWriter w4 = new StreamWriter(p4_s);
            for (int i = 0; i <= 6; i++)
            {
                w4.WriteLine();
            }
            w4.Close();

            StreamWriter wr4 = new StreamWriter(p4_c);
            for (int i = 0; i <= 6; i++)
            {
                wr4.WriteLine();
            }
            wr4.Close();

            StreamWriter w5 = new StreamWriter(p5_s);
            for (int i = 0; i <= 6; i++)
            {
                w5.WriteLine();
            }
            w5.Close();

            StreamWriter wr5 = new StreamWriter(p5_c);
            for (int i = 0; i <= 6; i++)
            {
                wr5.WriteLine();
            }
            wr5.Close();

            if (formInProgress)
            {
                DialogResult result = MessageBox.Show("Creating a new form will delete the current one. Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Phase1 phase1 = new Phase1(this);
                    phase1.Show();
                }
            } else
            {
                formInProgress = true;
                Phase1 phase1 = new Phase1(this);
                phase1.Show();
            }
        }
        private void Phase1_Click(object sender, EventArgs e)
        {
            viewSaved1 = true;
            
            Phase1 phase1 = new Phase1(this);
            phase1.Show();
        }

        private void Phase2_Click(object sender, EventArgs e)
        {
            viewSaved2 = true;

            Phase2 phase2 = new Phase2(this);
            phase2.Show();
        }

        private void Phase3_Click(object sender, EventArgs e)
        {
            viewSaved3 = true;

            Phase3 phase3 = new Phase3(this);
            phase3.Show();
        }

        private void Phase4_Click(object sender, EventArgs e)
        {
            viewSaved4 = true;

            Phase4 phase4 = new Phase4(this);
            phase4.Show();
        }

        private void Phase5_Click(object sender, EventArgs e)
        {
            viewSaved5 = true;

            Phase5 phase5 = new Phase5(this);
            phase5.Show();
        }
        public void Main_Load(object sender, EventArgs e)
        {
            phase1Button.Enabled = false;
            phase2Button.Enabled = false;
            phase3Button.Enabled = false;
            phase4Button.Enabled = false;
            phase5Button.Enabled = false;

            viewBtn1.Visible = false;
            viewBtn2.Visible = false;
            viewBtn3.Visible = false;
            viewBtn4.Visible = false;
            viewBtn5.Visible = false;

            View1 = false;
            View2 = false;
            View3 = false;
            View4 = false;
            View5 = false;

            loadFormButton.Enabled = false;

            if (Complete != 0)
            {
                loadFormButton.Enabled = true;
            }

            switch (Complete)
            {
                case 1:
                    {
                        if (Phase1Saved || Phase1Complete)
                        {
                            if (Phase1Complete)
                            {
                                viewBtn1.Visible = true;
                                
                                phase1Button.Enabled = false;
                                phase2Button.Enabled = true;
                            }
                            else
                            {
                                phase1Button.Enabled = true;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (Phase2Saved || Phase2Complete)
                        {
                            if (Phase2Complete)
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;

                                phase2Button.Enabled = false;
                                phase3Button.Enabled = true;
                            }
                            else
                            {
                                viewBtn1.Visible = true;

                                phase2Button.Enabled = true;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (Phase3Saved || Phase3Complete)
                        {
                            if (Phase3Complete)
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;
                                viewBtn3.Visible = true;

                                phase3Button.Enabled = false;
                                phase4Button.Enabled = true;
                            }
                            else
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;

                                phase3Button.Enabled = true;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if (Phase4Saved || Phase4Complete)
                        {
                            if (Phase4Complete)
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;
                                viewBtn3.Visible = true;
                                viewBtn4.Visible = true;

                                phase4Button.Enabled = false;
                                phase5Button.Enabled = true;
                            }
                            else
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;
                                viewBtn3.Visible = true;

                                phase4Button.Enabled = true;
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        if (Phase5Saved || Phase5Complete)
                        {
                            if (Phase5Complete)
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;
                                viewBtn3.Visible = true;
                                viewBtn4.Visible = true;
                                viewBtn5.Visible = true;

                                phase5Button.Enabled = false;
                            }
                            else
                            {
                                viewBtn1.Visible = true;
                                viewBtn2.Visible = true;
                                viewBtn3.Visible = true;
                                viewBtn4.Visible = true;

                                phase5Button.Enabled = true;
                            }
                        }
                        break;
                    }
            }
        }

        private void viewBtn1_Click(object sender, EventArgs e)
        {
            View1 = true;
            
            Phase1 phase1 = new Phase1(this);
            phase1.Show();
        }

        private void viewBtn2_Click(object sender, EventArgs e)
        {
            View2 = true;

            Phase2 phase2 = new Phase2(this);
            phase2.Show();
        }

        private void viewBtn3_Click(object sender, EventArgs e)
        {
            View3 = true;

            Phase3 phase3 = new Phase3(this);
            phase3.Show();
        }

        private void viewBtn4_Click(object sender, EventArgs e)
        {
            View4 = true;

            Phase4 phase4 = new Phase4(this);
            phase4.Show();
        }

        private void viewBtn5_Click(object sender, EventArgs e)
        {
            View5 = true;

            Phase5 phase5 = new Phase5(this);
            phase5.Show();
        }
    }
}
