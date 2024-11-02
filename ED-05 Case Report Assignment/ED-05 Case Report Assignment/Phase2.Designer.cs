namespace ED_05_Case_Report_Assignment
{
    partial class Phase2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phase2));
            this.studentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.submit2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.save2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(25, 162);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(274, 20);
            this.studentName.TabIndex = 37;
            this.studentName.TextChanged += new System.EventHandler(this.Student_Signature);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "To be Completed by a Student within seven (7) days of receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "I, ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "(STUDENT NAME, TYPED or PRINTED) have been made aware of ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Academic Integrity Policy ED 5-0, as well as my alleged violation of this policy." +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 117);
            this.label3.TabIndex = 47;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "I have reviewed the information in\r\nthe form as well as the evidence:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(196, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(246, 350);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "myTRU email*:";
            // 
            // studentEmail
            // 
            this.studentEmail.Location = new System.Drawing.Point(95, 382);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(337, 20);
            this.studentEmail.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(496, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "*All official correspondence from the committee will be sent to students at their" +
    " @mytru.ca email address.";
            // 
            // submit2
            // 
            this.submit2.Location = new System.Drawing.Point(528, 441);
            this.submit2.Name = "submit2";
            this.submit2.Size = new System.Drawing.Size(75, 23);
            this.submit2.TabIndex = 57;
            this.submit2.Text = "Submit";
            this.submit2.UseVisualStyleBackColor = true;
            this.submit2.Click += new System.EventHandler(this.Submit);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(583, 124);
            this.label7.TabIndex = 58;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(609, 441);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(75, 23);
            this.save2.TabIndex = 59;
            this.save2.Text = "Save";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // Phase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 477);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Phase2";
            this.Text = "Phase 2";
            this.Load += new System.EventHandler(this.Phase2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submit2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save2;
    }
}