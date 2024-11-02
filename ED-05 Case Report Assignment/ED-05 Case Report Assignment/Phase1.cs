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
using System.Windows.Forms.VisualStyles;

namespace ED_05_Case_Report_Assignment
{
    public partial class Phase1 : Form
    {
        Main parent;
        public Phase1(Main m)
        {
            parent = m;
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pressing submit is equivalent to signing this portion of the document, which means that everything is " +
                "correct and accurate to the best of your abilities. \n\n Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                String[] data = new String[12];
                data[0] = studentName.Text.ToString().Trim();
                data[1] = studentNumber.Text.ToString().Trim();
                data[2] = studentEmail.Text.ToString().Trim();
                data[3] = facultyMemberName.Text.ToString().Trim();
                data[4] = dateTimePicker1.Text.ToString().Trim();
                data[5] = courseName.Text.ToString().Trim();
                data[6] = assignmentNumber.Text.ToString().Trim();
                data[7] = departmentNumber.Text.ToString().Trim();
                data[8] = term.Text.ToString().Trim();
                data[9] = descriptionText.Text.ToString().Trim();
                data[10] = checkBox1.Checked.ToString().Trim();
                data[11] = checkBox2.Checked.ToString().Trim();
                
                StreamWriter sWriter = new StreamWriter(parent.p1_c);
                for (int i = 0; i < data.Length; i++)
                {
                    sWriter.WriteLine(data[i]);
                }

                sWriter.WriteLine("Phase1Complete");

                sWriter.Close();

                parent.Loads = 2;
                parent.Phase1Complete = true;
                parent.Complete = 1;
                parent.Main_Load(sender, e);
                this.Close();
            }
        }
        private void save1_Click(object sender, EventArgs e)
        {
            String[] data = new String[12];
            data[0] = studentName.Text.ToString().Trim();
            data[1] = studentNumber.Text.ToString().Trim();
            data[2] = studentEmail.Text.ToString().Trim();
            data[3] = facultyMemberName.Text.ToString().Trim();
            data[4] = dateTimePicker1.Text.ToString().Trim();
            data[5] = courseName.Text.ToString().Trim();
            data[6] = assignmentNumber.Text.ToString().Trim();
            data[7] = departmentNumber.Text.ToString().Trim();
            data[8] = term.Text.ToString().Trim();
            data[9] = descriptionText.Text.ToString().Trim();
            data[10] = checkBox1.Checked.ToString().Trim();
            data[11] = checkBox2.Checked.ToString().Trim();

            StreamWriter sWriter = new StreamWriter(parent.p1_s);
            for (int i = 0; i < data.Length; i++)
            {
                sWriter.WriteLine(data[i]);
            }

            sWriter.WriteLine("Phase1Saved");

            sWriter.Close();

            parent.Loads = 1;
            parent.Phase1Saved = true;
            parent.Phase1Complete = false;
            parent.Complete = 1;
            parent.Main_Load(sender, e);
            this.Close();
        }
        private void Phase1_Load(object sender, EventArgs e)
        {
            if (parent.viewSaved1)
            {
                StreamReader sReader = new StreamReader(parent.p1_s);

                String studentNameData = sReader.ReadLine().Trim();
                String studentNumberData = sReader.ReadLine().Trim();
                String studentEmailData = sReader.ReadLine().Trim();
                String facultyMemberNameData = sReader.ReadLine().Trim();
                String dateData = sReader.ReadLine().Trim();
                String courseNameData = sReader.ReadLine().Trim();
                String assignmentNumberData = sReader.ReadLine().Trim();
                String departmentNumberData = sReader.ReadLine().Trim();
                String termData = sReader.ReadLine().Trim();
                String descriptionData = sReader.ReadLine().Trim();
                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();

                sReader.Close();

                studentName.Text = studentNameData;
                studentNumber.Text = studentNumberData;
                studentEmail.Text = studentEmailData;
                facultyMemberName.Text = facultyMemberNameData;
                dateTimePicker1.Text = dateData;
                courseName.Text = courseNameData;
                assignmentNumber.Text = assignmentNumberData;
                departmentNumber.Text = departmentNumberData;
                term.Text = termData;
                descriptionText.Text = descriptionData;
                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }

                parent.viewSaved1 = false;

                
            } else if (parent.View1)
            {
                StreamReader sReader = new StreamReader(parent.p1_c);

                String studentNameData = sReader.ReadLine().Trim();
                String studentNumberData = sReader.ReadLine().Trim();
                String studentEmailData = sReader.ReadLine().Trim();
                String facultyMemberNameData = sReader.ReadLine().Trim();
                String dateData = sReader.ReadLine().Trim();
                String courseNameData = sReader.ReadLine().Trim();
                String assignmentNumberData = sReader.ReadLine().Trim();
                String departmentNumberData = sReader.ReadLine().Trim();
                String termData = sReader.ReadLine().Trim();
                String descriptionData = sReader.ReadLine().Trim();
                String checkbox1Data = sReader.ReadLine().Trim();
                String checkbox2Data = sReader.ReadLine().Trim();

                sReader.Close();

                studentName.Text = studentNameData;
                studentNumber.Text = studentNumberData;
                studentEmail.Text = studentEmailData;
                facultyMemberName.Text = facultyMemberNameData;
                dateTimePicker1.Text = dateData;
                courseName.Text = courseNameData;
                assignmentNumber.Text = assignmentNumberData;
                departmentNumber.Text = departmentNumberData;
                term.Text = termData;
                descriptionText.Text = descriptionData;
                if (checkbox1Data == "True")
                {
                    checkBox1.Checked = true;
                }
                if (checkbox2Data == "True")
                {
                    checkBox2.Checked = true;
                }

                studentName.Enabled = false;
                studentNumber.Enabled = false;
                studentEmail.Enabled = false;
                facultyMemberName.Enabled = false;
                dateTimePicker1.Enabled = false;
                courseName.Enabled = false;
                assignmentNumber.Enabled = false;
                departmentNumber.Enabled = false;
                term.Enabled = false;
                descriptionText.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;

                submitButton.Visible = false;
                save1.Visible = false;

                parent.View1 = false;
            }
        }
    }
}
