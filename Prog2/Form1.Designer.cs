namespace Prog2
{
    partial class Form1
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
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.freshmanRadio = new System.Windows.Forms.RadioButton();
            this.sophomoreRadio = new System.Windows.Forms.RadioButton();
            this.juniorRadio = new System.Windows.Forms.RadioButton();
            this.seniorRadio = new System.Windows.Forms.RadioButton();
            this.checkRegistrationBtn = new System.Windows.Forms.Button();
            this.gradeLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.gradeLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(13, 13);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(163, 13);
            this.lastNameLbl.TabIndex = 0;
            this.lastNameLbl.Text = "Enter First Letter of LAST NAME:";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(182, 10);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(21, 20);
            this.lastNameTxtBox.TabIndex = 1;
            // 
            // freshmanRadio
            // 
            this.freshmanRadio.AutoSize = true;
            this.freshmanRadio.Location = new System.Drawing.Point(6, 21);
            this.freshmanRadio.Name = "freshmanRadio";
            this.freshmanRadio.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadio.TabIndex = 0;
            this.freshmanRadio.TabStop = true;
            this.freshmanRadio.Text = "Freshman";
            this.freshmanRadio.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadio
            // 
            this.sophomoreRadio.AutoSize = true;
            this.sophomoreRadio.Location = new System.Drawing.Point(6, 44);
            this.sophomoreRadio.Name = "sophomoreRadio";
            this.sophomoreRadio.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadio.TabIndex = 1;
            this.sophomoreRadio.TabStop = true;
            this.sophomoreRadio.Text = "Sophomore";
            this.sophomoreRadio.UseVisualStyleBackColor = true;
            // 
            // juniorRadio
            // 
            this.juniorRadio.AutoSize = true;
            this.juniorRadio.Location = new System.Drawing.Point(6, 67);
            this.juniorRadio.Name = "juniorRadio";
            this.juniorRadio.Size = new System.Drawing.Size(53, 17);
            this.juniorRadio.TabIndex = 2;
            this.juniorRadio.TabStop = true;
            this.juniorRadio.Text = "Junior";
            this.juniorRadio.UseVisualStyleBackColor = true;
            // 
            // seniorRadio
            // 
            this.seniorRadio.AutoSize = true;
            this.seniorRadio.Location = new System.Drawing.Point(7, 91);
            this.seniorRadio.Name = "seniorRadio";
            this.seniorRadio.Size = new System.Drawing.Size(55, 17);
            this.seniorRadio.TabIndex = 3;
            this.seniorRadio.TabStop = true;
            this.seniorRadio.Text = "Senior";
            this.seniorRadio.UseVisualStyleBackColor = true;
            // 
            // checkRegistrationBtn
            // 
            this.checkRegistrationBtn.Location = new System.Drawing.Point(57, 159);
            this.checkRegistrationBtn.Name = "checkRegistrationBtn";
            this.checkRegistrationBtn.Size = new System.Drawing.Size(101, 44);
            this.checkRegistrationBtn.TabIndex = 3;
            this.checkRegistrationBtn.Text = "Check Registration Date";
            this.checkRegistrationBtn.UseVisualStyleBackColor = true;
            this.checkRegistrationBtn.Click += new System.EventHandler(this.checkRegistrationBtn_Click);
            // 
            // gradeLevelGroupBox
            // 
            this.gradeLevelGroupBox.Controls.Add(this.sophomoreRadio);
            this.gradeLevelGroupBox.Controls.Add(this.seniorRadio);
            this.gradeLevelGroupBox.Controls.Add(this.freshmanRadio);
            this.gradeLevelGroupBox.Controls.Add(this.juniorRadio);
            this.gradeLevelGroupBox.Location = new System.Drawing.Point(16, 36);
            this.gradeLevelGroupBox.Name = "gradeLevelGroupBox";
            this.gradeLevelGroupBox.Size = new System.Drawing.Size(198, 114);
            this.gradeLevelGroupBox.TabIndex = 2;
            this.gradeLevelGroupBox.TabStop = false;
            this.gradeLevelGroupBox.Text = "Select Your CURRENT Grade Level";
            // 
            // Form1
            // 
            this.AcceptButton = this.checkRegistrationBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 213);
            this.Controls.Add(this.checkRegistrationBtn);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.gradeLevelGroupBox);
            this.Name = "Form1";
            this.Text = "Prog 2";
            this.gradeLevelGroupBox.ResumeLayout(false);
            this.gradeLevelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.RadioButton freshmanRadio;
        private System.Windows.Forms.RadioButton sophomoreRadio;
        private System.Windows.Forms.RadioButton juniorRadio;
        private System.Windows.Forms.RadioButton seniorRadio;
        private System.Windows.Forms.Button checkRegistrationBtn;
        private System.Windows.Forms.GroupBox gradeLevelGroupBox;
    }
}

