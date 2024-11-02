using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ED_05_Case_Report_Assignment
{
    public partial class Phase4 : Form
    {
        Main parent;
        public Phase4(Main m)
        {
            parent = m;
            InitializeComponent();
        }
        private void Submit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pressing submit is equivalent to signing this portion of the document, which means that everything is " +
                "correct and accurate to the best of your abilities. \n\n Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                String[] data = new String[6];
                data[0] = checkBox1.Checked.ToString().Trim();
                data[1] = checkBox2.Checked.ToString().Trim();
                data[2] = explainTxt.Text.ToString().Trim();
                data[3] = commentTxt.Text.ToString().Trim();
                data[4] = chairName.Text.ToString().Trim();
                data[5] = dateTimePicker1.Text.ToString().Trim();

                StreamWriter sWriter = new StreamWriter(parent.p4_c);
                for (int i = 0; i < data.Length; i++)
                {
                    sWriter.WriteLine(data[i]);
                }

                sWriter.WriteLine("Phase4Complete");

                sWriter.Close();

                parent.Loads = 5;
                parent.Phase4Complete = true;
                parent.Complete = 4;
                parent.Main_Load(this, e);
                this.Close();
            }
        }
        private void save4_Click(object sender, EventArgs e)
        {
            String[] data = new String[6];
            data[0] = checkBox1.Checked.ToString().Trim();
            data[1] = checkBox2.Checked.ToString().Trim();
            data[2] = explainTxt.Text.ToString().Trim();
            data[3] = commentTxt.Text.ToString().Trim();
            data[4] = chairName.Text.ToString().Trim();
            data[5] = dateTimePicker1.Text.ToString().Trim();

            StreamWriter sWriter = new StreamWriter(parent.p4_s);
            for (int i = 0; i < data.Length; i++)
            {
                sWriter.WriteLine(data[i]);
            }

            sWriter.WriteLine("Phase4Saved");

            sWriter.Close();

            parent.Loads = 4;
            parent.Phase4Saved = true;
            parent.Phase4Complete = false;
            parent.Complete = 4;
            parent.Main_Load(this, e);
            this.Close();
        }
        private void Phase4_Load(object sender, EventArgs e)
        {
            if (parent.viewSaved4)
            {
                StreamReader sReader = new StreamReader(parent.p4_s);

                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();
                String explainTxtData = sReader.ReadLine().Trim();
                String commentTxtData = sReader.ReadLine().Trim();
                String chairNameData = sReader.ReadLine().Trim();
                String dateTime = sReader.ReadLine().Trim();

                sReader.Close();

                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }
                explainTxt.Text = explainTxtData;
                commentTxt.Text = commentTxtData;
                chairName.Text = chairNameData;
                dateTimePicker1.Text = dateTime;

                parent.viewSaved4 = false;

            } else if (parent.View4)
            {
                StreamReader sReader = new StreamReader(parent.p4_c);

                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();
                String explainTxtData = sReader.ReadLine().Trim();
                String commentTxtData = sReader.ReadLine().Trim();


                String chairNameData = sReader.ReadLine().Trim();
                String dateTime = sReader.ReadLine().Trim();

                sReader.Close();

                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }
                explainTxt.Text = explainTxtData;
                commentTxt.Text = commentTxtData;
                chairName.Text = chairNameData;
                dateTimePicker1.Text = dateTime;

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                explainTxt.Enabled = false;
                commentTxt.Enabled = false;
                searchBox.Enabled = false;
                searchBtn.Enabled = false;
                chairName.Enabled = false;
                dateTimePicker1.Enabled = false;

                submit4.Visible = false;
                save4.Visible = false;

                parent.View4 = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var startinfo = new ProcessStartInfo();

            startinfo.FileName = @"C:\\Users\\jesse\\AppData\\Local\\Programs\\Python\\Python312\\pythonw.exe";

            var script = @"C:\\Users\\jesse\\OneDrive\\Documents\\Archives\\LEXAR Archive Oct 2024\\Archives\\TRU Winter 2024\\Programming Methods\\ED-05 Case Report Assignment\\ED-05 Case Report Assignment\\python_script.py";

            var keywords = searchBox.Text;
            var phases = "";
            StreamReader s1 = new StreamReader(parent.p1_c);
            phases += s1.ReadToEnd();
            s1.Close();

            StreamReader s2 = new StreamReader(parent.p2_c);
            phases += s2.ReadToEnd();
            s2.Close();

            StreamReader s3 = new StreamReader(parent.p3_c);
            phases += s3.ReadToEnd();
            s3.Close();

            startinfo.Arguments = $"\"{script}\" \"{keywords}\" \"{phases}\"";

            startinfo.UseShellExecute = false;
            startinfo.CreateNoWindow = true;
            startinfo.RedirectStandardOutput = true;
            startinfo.RedirectStandardInput = true;
            startinfo.RedirectStandardError = true;

            var error = "";
            var output = "";

            using (Process process = Process.Start(startinfo))
            {
                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
            }

            Console.WriteLine("Errors: ");
            Console.WriteLine(error);
            Console.WriteLine();
            Console.WriteLine("Output: ");
            Console.WriteLine(output);

            DialogResult result = MessageBox.Show(output, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
