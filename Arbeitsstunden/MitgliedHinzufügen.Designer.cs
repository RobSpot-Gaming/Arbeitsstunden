namespace Arbeitsstunden
{
    partial class MitgliedHinzufügen
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
            this.txt_nummer = new System.Windows.Forms.TextBox();
            this.txt_vorname = new System.Windows.Forms.TextBox();
            this.txt_nachname = new System.Windows.Forms.TextBox();
            this.txt_arbeitsstunden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addNext = new System.Windows.Forms.Button();
            this.btn_addClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nummer
            // 
            this.txt_nummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nummer.Location = new System.Drawing.Point(201, 12);
            this.txt_nummer.Name = "txt_nummer";
            this.txt_nummer.Size = new System.Drawing.Size(175, 29);
            this.txt_nummer.TabIndex = 0;
            // 
            // txt_vorname
            // 
            this.txt_vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vorname.Location = new System.Drawing.Point(201, 47);
            this.txt_vorname.Name = "txt_vorname";
            this.txt_vorname.Size = new System.Drawing.Size(175, 29);
            this.txt_vorname.TabIndex = 1;
            // 
            // txt_nachname
            // 
            this.txt_nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nachname.Location = new System.Drawing.Point(201, 82);
            this.txt_nachname.Name = "txt_nachname";
            this.txt_nachname.Size = new System.Drawing.Size(175, 29);
            this.txt_nachname.TabIndex = 2;
            // 
            // txt_arbeitsstunden
            // 
            this.txt_arbeitsstunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arbeitsstunden.Location = new System.Drawing.Point(201, 117);
            this.txt_arbeitsstunden.Name = "txt_arbeitsstunden";
            this.txt_arbeitsstunden.Size = new System.Drawing.Size(175, 29);
            this.txt_arbeitsstunden.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mitgliedsnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nachname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arbeitsstunden";
            // 
            // btn_addNext
            // 
            this.btn_addNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNext.Location = new System.Drawing.Point(12, 165);
            this.btn_addNext.Name = "btn_addNext";
            this.btn_addNext.Size = new System.Drawing.Size(170, 36);
            this.btn_addNext.TabIndex = 8;
            this.btn_addNext.Text = "Weiteres Mitglied";
            this.btn_addNext.UseVisualStyleBackColor = true;
            this.btn_addNext.Click += new System.EventHandler(this.btn_addNext_Click);
            // 
            // btn_addClose
            // 
            this.btn_addClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClose.Location = new System.Drawing.Point(201, 165);
            this.btn_addClose.Name = "btn_addClose";
            this.btn_addClose.Size = new System.Drawing.Size(170, 36);
            this.btn_addClose.TabIndex = 9;
            this.btn_addClose.Text = "Hinzufügen";
            this.btn_addClose.UseVisualStyleBackColor = true;
            this.btn_addClose.Click += new System.EventHandler(this.btn_addClose_Click);
            // 
            // MitgliedHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 213);
            this.Controls.Add(this.btn_addClose);
            this.Controls.Add(this.btn_addNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_arbeitsstunden);
            this.Controls.Add(this.txt_nachname);
            this.Controls.Add(this.txt_vorname);
            this.Controls.Add(this.txt_nummer);
            this.Name = "MitgliedHinzufügen";
            this.Text = "Mitglied-Hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nummer;
        private System.Windows.Forms.TextBox txt_vorname;
        private System.Windows.Forms.TextBox txt_nachname;
        private System.Windows.Forms.TextBox txt_arbeitsstunden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addNext;
        private System.Windows.Forms.Button btn_addClose;
    }
}