namespace Einheit12.Allgemein
{
    partial class Unterricht
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
            CmdVergleiche = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // CmdVergleiche
            // 
            CmdVergleiche.Location = new Point(12, 204);
            CmdVergleiche.Name = "CmdVergleiche";
            CmdVergleiche.Size = new Size(170, 48);
            CmdVergleiche.TabIndex = 0;
            CmdVergleiche.Text = "Vergleiche";
            CmdVergleiche.UseVisualStyleBackColor = true;
            CmdVergleiche.Click += CmdVergleiche_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(12, 12);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(493, 165);
            TxtOutput.TabIndex = 1;
            // 
            // Unterricht
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 432);
            Controls.Add(TxtOutput);
            Controls.Add(CmdVergleiche);
            Name = "Unterricht";
            Text = "Unterricht";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdVergleiche;
        private TextBox TxtOutput;
    }
}