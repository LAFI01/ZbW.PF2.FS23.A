namespace Einheit11
{
    partial class Adressverwaltung
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
            CmdCreatePerson = new Button();
            LblShow = new Label();
            SuspendLayout();
            // 
            // CmdCreatePerson
            // 
            CmdCreatePerson.Location = new Point(163, 140);
            CmdCreatePerson.Margin = new Padding(4, 5, 4, 5);
            CmdCreatePerson.Name = "CmdCreatePerson";
            CmdCreatePerson.Size = new Size(223, 55);
            CmdCreatePerson.TabIndex = 0;
            CmdCreatePerson.Text = "Erzeuge Person";
            CmdCreatePerson.UseVisualStyleBackColor = true;
            CmdCreatePerson.Click += CmdCreatePerson_Click;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(163, 285);
            LblShow.Margin = new Padding(4, 0, 4, 0);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(241, 25);
            LblShow.TabIndex = 1;
            LblShow.Text = "Vorname: Nachname: Alter: 0";
            LblShow.Click += label1_Click;
            // 
            // Adressverwaltung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 495);
            Controls.Add(LblShow);
            Controls.Add(CmdCreatePerson);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Adressverwaltung";
            Text = "Adressverwaltung";
            Load += Adressverwaltung_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdCreatePerson;
        private Label LblShow;
    }
}