namespace Walidator
{
    partial class Walidator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Walidator));
            this.textbox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.Dane = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            resources.ApplyResources(this.textbox, "textbox");
            this.textbox.Name = "textbox";
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // button
            // 
            this.button.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button, "button");
            this.button.Name = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dane
            // 
            resources.ApplyResources(this.Dane, "Dane");
            this.Dane.ForeColor = System.Drawing.Color.Black;
            this.Dane.Name = "Dane";
            this.Dane.Click += new System.EventHandler(this.Dane_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Walidator
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textbox);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Walidator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label Dane;
        private System.Windows.Forms.TextBox textBox1;
    }
}

