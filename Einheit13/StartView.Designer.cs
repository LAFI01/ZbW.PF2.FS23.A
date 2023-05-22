namespace Einheit13
{
    partial class StartView
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
            BtnStaticExample = new Button();
            SuspendLayout();
            // 
            // BtnStaticExample
            // 
            BtnStaticExample.Location = new Point(37, 34);
            BtnStaticExample.Name = "BtnStaticExample";
            BtnStaticExample.Size = new Size(172, 48);
            BtnStaticExample.TabIndex = 0;
            BtnStaticExample.Text = "Static Example";
            BtnStaticExample.UseVisualStyleBackColor = true;
            BtnStaticExample.Click += OnClickBtnStaticExample;
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 262);
            Controls.Add(BtnStaticExample);
            Name = "StartView";
            Text = "StartView";
            Load += StartView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnStaticExample;
    }
}