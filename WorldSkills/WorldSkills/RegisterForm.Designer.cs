namespace WorldSkills
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.ImeTB = new System.Windows.Forms.TextBox();
            this.PrezimeTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.LozinkaTB = new System.Windows.Forms.TextBox();
            this.UstanovaCB = new System.Windows.Forms.ComboBox();
            this.ImeLB = new System.Windows.Forms.Label();
            this.PrezimeLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.PrijavaBTN = new System.Windows.Forms.Button();
            this.PonoviLozinkuLB = new System.Windows.Forms.Label();
            this.PonoviLozinkuTB = new System.Windows.Forms.TextBox();
            this.wSCDataSet = new WorldSkills.WSCDataSet();
            this.wSCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wSCDataSet2 = new WorldSkills.WSCDataSet2();
            this.ustanovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ustanovaTableAdapter = new WorldSkills.WSCDataSet2TableAdapters.UstanovaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustanovaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ImeTB
            // 
            this.ImeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeTB.Location = new System.Drawing.Point(210, 32);
            this.ImeTB.Name = "ImeTB";
            this.ImeTB.Size = new System.Drawing.Size(281, 24);
            this.ImeTB.TabIndex = 0;
            // 
            // PrezimeTB
            // 
            this.PrezimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrezimeTB.Location = new System.Drawing.Point(210, 62);
            this.PrezimeTB.Name = "PrezimeTB";
            this.PrezimeTB.Size = new System.Drawing.Size(281, 24);
            this.PrezimeTB.TabIndex = 1;
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTB.Location = new System.Drawing.Point(210, 92);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(281, 24);
            this.EmailTB.TabIndex = 2;
            // 
            // LozinkaTB
            // 
            this.LozinkaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LozinkaTB.Location = new System.Drawing.Point(210, 154);
            this.LozinkaTB.Name = "LozinkaTB";
            this.LozinkaTB.Size = new System.Drawing.Size(281, 24);
            this.LozinkaTB.TabIndex = 4;
            // 
            // UstanovaCB
            // 
            this.UstanovaCB.DataSource = this.ustanovaBindingSource;
            this.UstanovaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UstanovaCB.FormattingEnabled = true;
            this.UstanovaCB.Location = new System.Drawing.Point(210, 122);
            this.UstanovaCB.Name = "UstanovaCB";
            this.UstanovaCB.Size = new System.Drawing.Size(281, 26);
            this.UstanovaCB.TabIndex = 5;
            this.UstanovaCB.ValueMember = "Naziv";
            // 
            // ImeLB
            // 
            this.ImeLB.AutoSize = true;
            this.ImeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeLB.Location = new System.Drawing.Point(73, 35);
            this.ImeLB.Name = "ImeLB";
            this.ImeLB.Size = new System.Drawing.Size(36, 18);
            this.ImeLB.TabIndex = 6;
            this.ImeLB.Text = "Ime:";
            // 
            // PrezimeLB
            // 
            this.PrezimeLB.AutoSize = true;
            this.PrezimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrezimeLB.Location = new System.Drawing.Point(73, 65);
            this.PrezimeLB.Name = "PrezimeLB";
            this.PrezimeLB.Size = new System.Drawing.Size(67, 18);
            this.PrezimeLB.TabIndex = 7;
            this.PrezimeLB.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(73, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(73, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odaberi ustanovu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(73, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lozinka:";
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegisterBTN.Location = new System.Drawing.Point(156, 217);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(125, 38);
            this.RegisterBTN.TabIndex = 11;
            this.RegisterBTN.Text = "Registracija";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // PrijavaBTN
            // 
            this.PrijavaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrijavaBTN.Location = new System.Drawing.Point(290, 217);
            this.PrijavaBTN.Name = "PrijavaBTN";
            this.PrijavaBTN.Size = new System.Drawing.Size(125, 38);
            this.PrijavaBTN.TabIndex = 12;
            this.PrijavaBTN.Text = "Prijava";
            this.PrijavaBTN.UseVisualStyleBackColor = true;
            this.PrijavaBTN.Click += new System.EventHandler(this.PrijavaBTN_Click);
            // 
            // PonoviLozinkuLB
            // 
            this.PonoviLozinkuLB.AutoSize = true;
            this.PonoviLozinkuLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PonoviLozinkuLB.Location = new System.Drawing.Point(73, 188);
            this.PonoviLozinkuLB.Name = "PonoviLozinkuLB";
            this.PonoviLozinkuLB.Size = new System.Drawing.Size(114, 18);
            this.PonoviLozinkuLB.TabIndex = 14;
            this.PonoviLozinkuLB.Text = "Ponovi Lozinku:";
            // 
            // PonoviLozinkuTB
            // 
            this.PonoviLozinkuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PonoviLozinkuTB.Location = new System.Drawing.Point(210, 185);
            this.PonoviLozinkuTB.Name = "PonoviLozinkuTB";
            this.PonoviLozinkuTB.Size = new System.Drawing.Size(281, 24);
            this.PonoviLozinkuTB.TabIndex = 13;
            // 
            // wSCDataSet
            // 
            this.wSCDataSet.DataSetName = "WSCDataSet";
            this.wSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wSCDataSetBindingSource
            // 
            this.wSCDataSetBindingSource.DataSource = this.wSCDataSet;
            this.wSCDataSetBindingSource.Position = 0;
            // 
            // wSCDataSet2
            // 
            this.wSCDataSet2.DataSetName = "WSCDataSet2";
            this.wSCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ustanovaBindingSource
            // 
            this.ustanovaBindingSource.DataMember = "Ustanova";
            this.ustanovaBindingSource.DataSource = this.wSCDataSet2;
            // 
            // ustanovaTableAdapter
            // 
            this.ustanovaTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 291);
            this.Controls.Add(this.PonoviLozinkuLB);
            this.Controls.Add(this.PonoviLozinkuTB);
            this.Controls.Add(this.PrijavaBTN);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrezimeLB);
            this.Controls.Add(this.ImeLB);
            this.Controls.Add(this.UstanovaCB);
            this.Controls.Add(this.LozinkaTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PrezimeTB);
            this.Controls.Add(this.ImeTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustanovaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeTB;
        private System.Windows.Forms.TextBox PrezimeTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox LozinkaTB;
        private System.Windows.Forms.ComboBox UstanovaCB;
        private System.Windows.Forms.Label ImeLB;
        private System.Windows.Forms.Label PrezimeLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Button PrijavaBTN;
        private System.Windows.Forms.Label PonoviLozinkuLB;
        private System.Windows.Forms.TextBox PonoviLozinkuTB;
        private System.Windows.Forms.BindingSource wSCDataSetBindingSource;
        private WSCDataSet wSCDataSet;
        private WSCDataSet2 wSCDataSet2;
        private System.Windows.Forms.BindingSource ustanovaBindingSource;
        private WSCDataSet2TableAdapters.UstanovaTableAdapter ustanovaTableAdapter;
    }
}