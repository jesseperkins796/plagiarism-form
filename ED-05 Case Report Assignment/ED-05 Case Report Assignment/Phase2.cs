using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_05_Case_Report_Assignment
{
    public partial class Phase2 : Form
    {
        Main parent;
        public Phase2(Main m)
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
                String[] data = new String[4];
                data[0] = studentName.Text.ToString().Trim();
                data[1] = checkBox1.Checked.ToString().Trim();
                data[2] = checkBox2.Checked.ToString().Trim();
                data[3] = studentEmail.Text.ToString().Trim();

                StreamWriter sWriter = new StreamWriter(parent.p2_c);

                for (int i = 0; i < data.Length; i++)
                {
                    sWriter.WriteLine(data[i]);
                }

                sWriter.WriteLine("Phase2Complete");

                sWriter.Close();

                parent.Loads = 3;
                parent.Phase2Complete = true;
                parent.Complete = 2;
                parent.Main_Load(this, e);
                this.Close();
            }
        }
        private void save2_Click(object sender, EventArgs e)
        {
            String[] data = new String[4];
            data[0] = studentName.Text.ToString().Trim();
            data[1] = checkBox1.Checked.ToString().Trim();
            data[2] = checkBox2.Checked.ToString().Trim();
            data[3] = studentEmail.Text.ToString().Trim();

            StreamWriter sWriter = new StreamWriter(parent.p2_s);
            for (int i = 0; i < data.Length; i++)
            {
                sWriter.WriteLine(data[i]);
            }

            sWriter.WriteLine("Phase2Saved");

            sWriter.Close();

            parent.Loads = 2;
            parent.Phase2Saved = true;
            parent.Phase2Complete = false;
            parent.Complete = 2;
            parent.Main_Load(sender, e);
            this.Close();
        }
        private void Student_Signature(object sender, EventArgs e)
        {

        }
        private void Phase2_Load(object sender, EventArgs e)
        {
            if (parent.viewSaved2)
            {
                StreamReader sReader = new StreamReader(parent.p2_s);

                String studentNameData = sReader.ReadLine().Trim();
                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();
                String studentEmailData = sReader.ReadLine().Trim();

                sReader.Close();

                studentName.Text = studentNameData;
                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }
                studentEmail.Text = studentEmailData;

                parent.viewSaved2 = false;

            } else if (parent.View2) 
            {
                StreamReader sReader = new StreamReader(parent.p2_c);

                String studentNameData = sReader.ReadLine().Trim();
                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();
                String studentEmailData = sReader.ReadLine().Trim();

                sReader.Close();

                studentName.Text = studentNameData;
                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }
                studentEmail.Text = studentEmailData; 
                
                studentName.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    studentEmail.Enabled = false;

                    submit2.Visible = false;
                    save2.Visible = false;

                    parent.View2 = false;
            }
        }
    }
}
