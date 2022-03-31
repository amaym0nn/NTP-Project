
namespace NTP_Project
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
            this.note1_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.students_combobox = new System.Windows.Forms.ComboBox();
            this.checking_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.ntb_ogrencilerDataSet1 = new NTP_Project.ntb_ogrencilerDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.note2_listbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.note3_listbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.added_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_ogrencilerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // note1_listbox
            // 
            this.note1_listbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1_listbox.FormattingEnabled = true;
            this.note1_listbox.ItemHeight = 19;
            this.note1_listbox.Location = new System.Drawing.Point(86, 411);
            this.note1_listbox.Name = "note1_listbox";
            this.note1_listbox.Size = new System.Drawing.Size(111, 61);
            this.note1_listbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ NOT PANELİ";
            // 
            // students_combobox
            // 
            this.students_combobox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students_combobox.FormattingEnabled = true;
            this.students_combobox.Location = new System.Drawing.Point(172, 194);
            this.students_combobox.Name = "students_combobox";
            this.students_combobox.Size = new System.Drawing.Size(260, 24);
            this.students_combobox.TabIndex = 2;
            // 
            // checking_button
            // 
            this.checking_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checking_button.Location = new System.Drawing.Point(220, 243);
            this.checking_button.Name = "checking_button";
            this.checking_button.Size = new System.Drawing.Size(103, 51);
            this.checking_button.TabIndex = 3;
            this.checking_button.Text = "Kontrol";
            this.checking_button.UseVisualStyleBackColor = true;
            this.checking_button.Click += new System.EventHandler(this.checking_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenciler:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(138, 330);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 22);
            this.name_label.TabIndex = 5;
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // ntb_ogrencilerDataSet1
            // 
            this.ntb_ogrencilerDataSet1.DataSetName = "ntb_ogrencilerDataSet";
            this.ntb_ogrencilerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Not 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Not 2";
            // 
            // note2_listbox
            // 
            this.note2_listbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note2_listbox.FormattingEnabled = true;
            this.note2_listbox.ItemHeight = 19;
            this.note2_listbox.Location = new System.Drawing.Point(220, 411);
            this.note2_listbox.Name = "note2_listbox";
            this.note2_listbox.Size = new System.Drawing.Size(111, 61);
            this.note2_listbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Not 3";
            // 
            // note3_listbox
            // 
            this.note3_listbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note3_listbox.FormattingEnabled = true;
            this.note3_listbox.ItemHeight = 19;
            this.note3_listbox.Location = new System.Drawing.Point(354, 411);
            this.note3_listbox.Name = "note3_listbox";
            this.note3_listbox.Size = new System.Drawing.Size(111, 61);
            this.note3_listbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Not eklemek için tıklayınız:";
            // 
            // added_button
            // 
            this.added_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.added_button.Location = new System.Drawing.Point(308, 105);
            this.added_button.Name = "added_button";
            this.added_button.Size = new System.Drawing.Size(107, 33);
            this.added_button.TabIndex = 12;
            this.added_button.Text = "Not Ekleme";
            this.added_button.UseVisualStyleBackColor = true;
            this.added_button.Click += new System.EventHandler(this.added_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 490);
            this.Controls.Add(this.added_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.note3_listbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.note2_listbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checking_button);
            this.Controls.Add(this.students_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note1_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntb_ogrencilerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox note1_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox students_combobox;
        private System.Windows.Forms.Button checking_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private ntb_ogrencilerDataSet ntb_ogrencilerDataSet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox note3_listbox;
        private System.Windows.Forms.ListBox note2_listbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button added_button;
    }
}

