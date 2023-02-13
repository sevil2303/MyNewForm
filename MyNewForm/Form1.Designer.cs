namespace MyNewForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.birthdatetime = new System.Windows.Forms.DateTimePicker();
            this.numberTxb = new System.Windows.Forms.MaskedTextBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.surnameTxb = new System.Windows.Forms.TextBox();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.humanslistBox = new System.Windows.Forms.ListBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.filenameTxb = new System.Windows.Forms.TextBox();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.changeBtn);
            this.groupBox1.Controls.Add(this.birthdatetime);
            this.groupBox1.Controls.Add(this.numberTxb);
            this.groupBox1.Controls.Add(this.emailTxb);
            this.groupBox1.Controls.Add(this.surnameTxb);
            this.groupBox1.Controls.Add(this.nameTxb);
            this.groupBox1.Controls.Add(this.birthdateLbl);
            this.groupBox1.Controls.Add(this.numberLbl);
            this.groupBox1.Controls.Add(this.surnameLbl);
            this.groupBox1.Controls.Add(this.emailLbl);
            this.groupBox1.Controls.Add(this.nameLbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(309, 324);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 35);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.changeBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBtn.Location = new System.Drawing.Point(309, 375);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 35);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // birthdatetime
            // 
            this.birthdatetime.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.birthdatetime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthdatetime.Location = new System.Drawing.Point(138, 281);
            this.birthdatetime.Name = "birthdatetime";
            this.birthdatetime.Size = new System.Drawing.Size(216, 23);
            this.birthdatetime.TabIndex = 4;
            // 
            // numberTxb
            // 
            this.numberTxb.Location = new System.Drawing.Point(138, 215);
            this.numberTxb.Mask = "+(994) 00-000-00-00";
            this.numberTxb.Name = "numberTxb";
            this.numberTxb.Size = new System.Drawing.Size(216, 26);
            this.numberTxb.TabIndex = 3;
            this.numberTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(138, 161);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(216, 26);
            this.emailTxb.TabIndex = 2;
            // 
            // surnameTxb
            // 
            this.surnameTxb.Location = new System.Drawing.Point(138, 107);
            this.surnameTxb.Name = "surnameTxb";
            this.surnameTxb.Size = new System.Drawing.Size(216, 26);
            this.surnameTxb.TabIndex = 1;
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(138, 55);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(216, 26);
            this.nameTxb.TabIndex = 0;
            this.nameTxb.TextChanged += new System.EventHandler(this.nameTxb_TextChanged);
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Location = new System.Drawing.Point(6, 281);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(78, 19);
            this.birthdateLbl.TabIndex = 0;
            this.birthdateLbl.Text = "Birth date";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(6, 218);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(115, 19);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "Mobile number";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(6, 107);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(71, 19);
            this.surnameLbl.TabIndex = 0;
            this.surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(6, 161);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(52, 19);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "E-mail";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 62);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 19);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // humanslistBox
            // 
            this.humanslistBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humanslistBox.FormattingEnabled = true;
            this.humanslistBox.ItemHeight = 19;
            this.humanslistBox.Location = new System.Drawing.Point(479, 60);
            this.humanslistBox.Name = "humanslistBox";
            this.humanslistBox.Size = new System.Drawing.Size(293, 270);
            this.humanslistBox.TabIndex = 1;
            this.humanslistBox.SelectedIndexChanged += new System.EventHandler(this.humanslistBox_SelectedIndexChanged);
            this.humanslistBox.DoubleClick += new System.EventHandler(this.humanslistBox_DoubleClick);
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLbl.Location = new System.Drawing.Point(479, 22);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(293, 35);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "List of Humans";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filenameTxb
            // 
            this.filenameTxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filenameTxb.Location = new System.Drawing.Point(591, 350);
            this.filenameTxb.Name = "filenameTxb";
            this.filenameTxb.Size = new System.Drawing.Size(181, 26);
            this.filenameTxb.TabIndex = 7;
            // 
            // filenameLbl
            // 
            this.filenameLbl.AutoSize = true;
            this.filenameLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filenameLbl.Location = new System.Drawing.Point(475, 353);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(96, 19);
            this.filenameLbl.TabIndex = 4;
            this.filenameLbl.Text = "Name of File";
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loadBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(479, 403);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(92, 35);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(591, 403);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 35);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(697, 403);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(92, 35);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.filenameTxb);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.humanslistBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.MaskedTextBox numberTxb;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox surnameTxb;
        private System.Windows.Forms.DateTimePicker birthdatetime;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.ListBox humanslistBox;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.TextBox filenameTxb;
        private System.Windows.Forms.Label filenameLbl;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

