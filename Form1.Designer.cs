namespace _27.Proffesion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            txtName = new TextBox();
            Gender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cB = new ComboBox();
            rbOther = new RadioButton();
            label3 = new Label();
            lblResult = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(42, 43);
            lblname.Name = "lblname";
            lblname.Size = new Size(59, 25);
            lblname.TabIndex = 0;
            lblname.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 31);
            txtName.TabIndex = 1;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(42, 113);
            Gender.Name = "Gender";
            Gender.Size = new Size(69, 25);
            Gender.TabIndex = 2;
            Gender.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(151, 113);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(151, 148);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(93, 29);
            rbFemale.TabIndex = 4;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cB
            // 
            cB.FormattingEnabled = true;
            cB.Items.AddRange(new object[] { "Teacher", "Engineer", "Lecturer", "Nurse" });
            cB.Location = new Point(151, 249);
            cB.Name = "cB";
            cB.Size = new Size(221, 33);
            cB.TabIndex = 5;
            cB.Text = "Select";
            cB.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(151, 183);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(82, 29);
            rbOther.TabIndex = 6;
            rbOther.TabStop = true;
            rbOther.Text = "Other";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 252);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 7;
            label3.Text = "Proffesion";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(42, 365);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(384, 27);
            lblResult.TabIndex = 8;
            lblResult.Text = "                                                                          ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(182, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 417);
            Controls.Add(btnSubmit);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(rbOther);
            Controls.Add(cB);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(Gender);
            Controls.Add(txtName);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtName;
        private Label Gender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private ComboBox cB;
        private RadioButton rbOther;
        private Label label3;
        private Label lblResult;
        private Button btnSubmit;
    }
}