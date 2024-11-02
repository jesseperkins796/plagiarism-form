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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ED_05_Case_Report_Assignment
{
    public partial class Phase3 : Form
    {
        Main parent;
        public Phase3(Main m)
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
                String[] data = new String[2];
                data[0] = facultyName.Text.ToString().Trim();
                data[1] = dateTimePicker1.Text.ToString().Trim();

                StreamWriter sWriter = new StreamWriter(parent.p3_c);
                for (int i = 0; i < data.Length; i++)
                {
                    sWriter.WriteLine(data[i]);
                }

                sWriter.WriteLine("Phase3Complete");

                sWriter.Close();

                parent.Loads = 4;
                parent.Phase3Complete = true;
                parent.Complete = 3;
                parent.Main_Load(this, e);
                this.Close();
            }
        }

        private void save3_Click(object sender, EventArgs e)
        {
            String[] data = new String[2];
            data[0] = facultyName.Text.ToString().Trim();
            data[1] = dateTimePicker1.Text.ToString().Trim();

            StreamWriter sWriter = new StreamWriter(parent.p3_s);
            for (int i = 0; i < data.Length; i++)
            {
                sWriter.WriteLine(data[i]);
            }

            sWriter.WriteLine("Phase3Saved");

            sWriter.Close();

            parent.Loads = 3;
            parent.Phase3Saved = true;
            parent.Phase2Complete = false;
            parent.Complete = 3;
            parent.Main_Load(this, e);
            this.Close();
        }

        private void Phase3_Load(object sender, EventArgs e)
        {
            if (parent.viewSaved3)
            {
                StreamReader sReader = new StreamReader(parent.p3_s);

                String facultyNameData = sReader.ReadLine().Trim();
                String dateTime = sReader.ReadLine().Trim();

                sReader.Close();

                facultyName.Text = facultyNameData;
                dateTimePicker1.Text = dateTime;

                parent.viewSaved3 = false;

            } else if (parent.View3)
            {
                StreamReader sReader = new StreamReader(parent.p3_c);

                String facultyNameData = sReader.ReadLine().Trim();
                String dateTime = sReader.ReadLine().Trim();

                sReader.Close();

                facultyName.Text = facultyNameData;
                dateTimePicker1.Text = dateTime;

                facultyName.Enabled = false;
                dateTimePicker1.Enabled = false;

                submit3.Visible = false;
                save3.Visible = false;

                parent.View3 = false;
            }
        }
    }
}
