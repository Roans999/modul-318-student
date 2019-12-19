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
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewVerbindungen = new System.Windows.Forms.ListBox();
            this.listBoxAnschluesse = new System.Windows.Forms.ListBox();
            this.comboBoxVon2 = new System.Windows.Forms.ComboBox();
            this.buttonSuchen2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxHaltestellen = new System.Windows.Forms.ListBox();
            this.comboBoxVon3 = new System.Windows.Forms.ComboBox();
            this.buttonSuchen3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(1360, 1145);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewVerbindungen);
            this.tabPage1.Controls.Add(this.comboBoxNach);
            this.tabPage1.Controls.Add(this.comboBoxVon);
            this.tabPage1.Controls.Add(this.buttonSuchen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1344, 1098);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbundung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(86, 64);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(1060, 33);
            this.comboBoxNach.TabIndex = 28;
            this.comboBoxNach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxNach_KeyPress);
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(86, 22);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(1060, 33);
            this.comboBoxVon.TabIndex = 27;
            this.comboBoxVon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxVon_KeyPress);
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen.Location = new System.Drawing.Point(1189, 19);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(120, 120);
            this.buttonSuchen.TabIndex = 25;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Von:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxAnschluesse);
            this.tabPage2.Controls.Add(this.comboBoxVon2);
            this.tabPage2.Controls.Add(this.buttonSuchen2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1344, 1098);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anschlüsse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxHaltestellen);
            this.tabPage3.Controls.Add(this.comboBoxVon3);
            this.tabPage3.Controls.Add(this.buttonSuchen3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1344, 1098);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Haltestellen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1186, 1163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 52);
            this.button2.TabIndex = 20;
            this.button2.Text = "Teilen per Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listViewVerbindungen
            // 
            this.listViewVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVerbindungen.FormattingEnabled = true;
            this.listViewVerbindungen.ItemHeight = 25;
            this.listViewVerbindungen.Location = new System.Drawing.Point(4, 225);
            this.listViewVerbindungen.Name = "listViewVerbindungen";
            this.listViewVerbindungen.Size = new System.Drawing.Size(1334, 854);
            this.listViewVerbindungen.TabIndex = 30;
            // 
            // listBoxAnschluesse
            // 
            this.listBoxAnschluesse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAnschluesse.FormattingEnabled = true;
            this.listBoxAnschluesse.ItemHeight = 25;
            this.listBoxAnschluesse.Location = new System.Drawing.Point(5, 225);
            this.listBoxAnschluesse.Name = "listBoxAnschluesse";
            this.listBoxAnschluesse.Size = new System.Drawing.Size(1334, 854);
            this.listBoxAnschluesse.TabIndex = 36;
            // 
            // comboBoxVon2
            // 
            this.comboBoxVon2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVon2.FormattingEnabled = true;
            this.comboBoxVon2.Location = new System.Drawing.Point(87, 22);
            this.comboBoxVon2.Name = "comboBoxVon2";
            this.comboBoxVon2.Size = new System.Drawing.Size(1060, 33);
            this.comboBoxVon2.TabIndex = 34;
            // 
            // buttonSuchen2
            // 
            this.buttonSuchen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen2.Location = new System.Drawing.Point(1190, 19);
            this.buttonSuchen2.Name = "buttonSuchen2";
            this.buttonSuchen2.Size = new System.Drawing.Size(120, 120);
            this.buttonSuchen2.TabIndex = 33;
            this.buttonSuchen2.Text = "Suchen";
            this.buttonSuchen2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Von:";
            // 
            // listBoxHaltestellen
            // 
            this.listBoxHaltestellen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxHaltestellen.FormattingEnabled = true;
            this.listBoxHaltestellen.ItemHeight = 25;
            this.listBoxHaltestellen.Location = new System.Drawing.Point(5, 225);
            this.listBoxHaltestellen.Name = "listBoxHaltestellen";
            this.listBoxHaltestellen.Size = new System.Drawing.Size(1334, 854);
            this.listBoxHaltestellen.TabIndex = 36;
            // 
            // comboBoxVon3
            // 
            this.comboBoxVon3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVon3.FormattingEnabled = true;
            this.comboBoxVon3.Location = new System.Drawing.Point(87, 22);
            this.comboBoxVon3.Name = "comboBoxVon3";
            this.comboBoxVon3.Size = new System.Drawing.Size(1060, 33);
            this.comboBoxVon3.TabIndex = 34;
            // 
            // buttonSuchen3
            // 
            this.buttonSuchen3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen3.Location = new System.Drawing.Point(1190, 19);
            this.buttonSuchen3.Name = "buttonSuchen3";
            this.buttonSuchen3.Size = new System.Drawing.Size(120, 120);
            this.buttonSuchen3.TabIndex = 33;
            this.buttonSuchen3.Text = "Suchen";
            this.buttonSuchen3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Von:";
            // 
            // WindowsFenster
            // 
            this.AcceptButton = this.buttonSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 1225);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ListBox listViewVerbindungen;
        private System.Windows.Forms.ListBox listBoxAnschluesse;
        private System.Windows.Forms.ComboBox comboBoxVon2;
        private System.Windows.Forms.Button buttonSuchen2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxHaltestellen;
        private System.Windows.Forms.ComboBox comboBoxVon3;
        private System.Windows.Forms.Button buttonSuchen3;
        private System.Windows.Forms.Label label6;
    }
}

