namespace SBR_App
{
    partial class WindowsFenster
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewVerbindungen = new System.Windows.Forms.ListView();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.comboBoxWann = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 879);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxWann);
            this.tabPage1.Controls.Add(this.comboBoxNach);
            this.tabPage1.Controls.Add(this.comboBoxVon);
            this.tabPage1.Controls.Add(this.listViewVerbindungen);
            this.tabPage1.Controls.Add(this.buttonSuchen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 832);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbundung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewVerbindungen
            // 
            this.listViewVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVerbindungen.HideSelection = false;
            this.listViewVerbindungen.Location = new System.Drawing.Point(1, 172);
            this.listViewVerbindungen.Name = "listViewVerbindungen";
            this.listViewVerbindungen.Size = new System.Drawing.Size(677, 660);
            this.listViewVerbindungen.TabIndex = 26;
            this.listViewVerbindungen.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen.Location = new System.Drawing.Point(531, 21);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(100, 100);
            this.buttonSuchen.TabIndex = 25;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Wann:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Von:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 832);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anschlüsse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1, 172);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(677, 660);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(531, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 25;
            this.button3.Text = "Suchen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nach:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox5);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(678, 832);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Haltestellen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(1, 172);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(677, 660);
            this.listView3.TabIndex = 27;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(531, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 25;
            this.button4.Text = "Suchen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nach:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(520, 897);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 52);
            this.button2.TabIndex = 20;
            this.button2.Text = "Teilen per Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(86, 14);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(394, 33);
            this.comboBoxVon.TabIndex = 27;
            this.comboBoxVon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxVon_KeyPress);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(86, 56);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(394, 33);
            this.comboBoxNach.TabIndex = 28;
            this.comboBoxNach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxNach_KeyPress);
            // 
            // comboBoxWann
            // 
            this.comboBoxWann.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWann.FormattingEnabled = true;
            this.comboBoxWann.Location = new System.Drawing.Point(86, 100);
            this.comboBoxWann.Name = "comboBoxWann";
            this.comboBoxWann.Size = new System.Drawing.Size(394, 33);
            this.comboBoxWann.TabIndex = 29;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.CausesValidation = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(86, 56);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(394, 33);
            this.comboBox4.TabIndex = 29;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(86, 56);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(394, 33);
            this.comboBox5.TabIndex = 29;
            // 
            // WindowsFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 959);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "WindowsFenster";
            this.Text = "SBR App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewVerbindungen;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ComboBox comboBoxWann;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

