namespace WorldSkills
{
    partial class LoginForm
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
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.LozinkaTB = new System.Windows.Forms.TextBox();
            this.EmailLB = new System.Windows.Forms.Label();
            this.LozinkaLB = new System.Windows.Forms.Label();
            this.Prijava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VoditeljRB = new System.Windows.Forms.RadioButton();
            this.SudacRB = new System.Windows.Forms.RadioButton();
            this.NatjecateljRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTB.Location = new System.Drawing.Point(109, 32);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(369, 29);
            this.EmailTB.TabIndex = 0;
            // 
            // LozinkaTB
            // 
            this.LozinkaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LozinkaTB.Location = new System.Drawing.Point(109, 67);
            this.LozinkaTB.Name = "LozinkaTB";
            this.LozinkaTB.Size = new System.Drawing.Size(369, 29);
            this.LozinkaTB.TabIndex = 1;
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLB.Location = new System.Drawing.Point(24, 35);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(62, 24);
            this.EmailLB.TabIndex = 3;
            this.EmailLB.Text = "Email:";
            // 
            // LozinkaLB
            // 
            this.LozinkaLB.AutoSize = true;
            this.LozinkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LozinkaLB.Location = new System.Drawing.Point(24, 67);
            this.LozinkaLB.Name = "LozinkaLB";
            this.LozinkaLB.Size = new System.Drawing.Size(79, 24);
            this.LozinkaLB.TabIndex = 4;
            this.LozinkaLB.Text = "Lozinka:";
            // 
            // Prijava
            // 
            this.Prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Prijava.Location = new System.Drawing.Point(214, 165);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(108, 38);
            this.Prijava.TabIndex = 5;
            this.Prijava.Text = "Prijava";
            this.Prijava.UseVisualStyleBackColor = true;
            this.Prijava.Click += new System.EventHandler(this.Prijava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VoditeljRB);
            this.groupBox1.Controls.Add(this.SudacRB);
            this.groupBox1.Controls.Add(this.NatjecateljRB);
            this.groupBox1.Location = new System.Drawing.Point(136, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 25);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // VoditeljRB
            // 
            this.VoditeljRB.AutoSize = true;
            this.VoditeljRB.Location = new System.Drawing.Point(259, 0);
            this.VoditeljRB.Name = "VoditeljRB";
            this.VoditeljRB.Size = new System.Drawing.Size(59, 17);
            this.VoditeljRB.TabIndex = 2;
            this.VoditeljRB.Text = "Voditelj";
            this.VoditeljRB.UseVisualStyleBackColor = true;
            this.VoditeljRB.CheckedChanged += new System.EventHandler(this.VoditeljRB_CheckedChanged);
            // 
            // SudacRB
            // 
            this.SudacRB.AutoSize = true;
            this.SudacRB.Location = new System.Drawing.Point(147, 0);
            this.SudacRB.Name = "SudacRB";
            this.SudacRB.Size = new System.Drawing.Size(56, 17);
            this.SudacRB.TabIndex = 1;
            this.SudacRB.Text = "Sudac";
            this.SudacRB.UseVisualStyleBackColor = true;
            this.SudacRB.CheckedChanged += new System.EventHandler(this.SudacRB_CheckedChanged);
            // 
            // NatjecateljRB
            // 
            this.NatjecateljRB.AutoSize = true;
            this.NatjecateljRB.Checked = true;
            this.NatjecateljRB.Location = new System.Drawing.Point(28, 0);
            this.NatjecateljRB.Name = "NatjecateljRB";
            this.NatjecateljRB.Size = new System.Drawing.Size(75, 17);
            this.NatjecateljRB.TabIndex = 0;
            this.NatjecateljRB.TabStop = true;
            this.NatjecateljRB.Text = "Natjecatelj";
            this.NatjecateljRB.UseVisualStyleBackColor = true;
            this.NatjecateljRB.CheckedChanged += new System.EventHandler(this.NatjecateljRB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vrsta prijave:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(385, 102);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Prikaži lozinku";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegisterBTN.Location = new System.Drawing.Point(195, 209);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(144, 34);
            this.RegisterBTN.TabIndex = 10;
            this.RegisterBTN.Text = "Registracija";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 251);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Prijava);
            this.Controls.Add(this.LozinkaLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.LozinkaTB);
            this.Controls.Add(this.EmailTB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox LozinkaTB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.Label LozinkaLB;
        private System.Windows.Forms.Button Prijava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VoditeljRB;
        private System.Windows.Forms.RadioButton SudacRB;
        private System.Windows.Forms.RadioButton NatjecateljRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button RegisterBTN;
    }
}

