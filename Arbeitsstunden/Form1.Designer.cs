﻿namespace Arbeitsstunden
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mitgliederVerwaltung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mitgliederVerwaltung
            // 
            this.btn_mitgliederVerwaltung.Location = new System.Drawing.Point(12, 12);
            this.btn_mitgliederVerwaltung.Name = "btn_mitgliederVerwaltung";
            this.btn_mitgliederVerwaltung.Size = new System.Drawing.Size(196, 23);
            this.btn_mitgliederVerwaltung.TabIndex = 0;
            this.btn_mitgliederVerwaltung.Text = "Mitglieder Verwaltung";
            this.btn_mitgliederVerwaltung.UseVisualStyleBackColor = true;
            this.btn_mitgliederVerwaltung.Click += new System.EventHandler(this.btn_mitgliederVerwaltung_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_mitgliederVerwaltung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mitgliederVerwaltung;
        private System.Windows.Forms.Button button2;
    }
}

