namespace WinForm_GUI
{
    partial class LoggaIn
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
            txtAnvändarnamn = new TextBox();
            txtLösenord = new TextBox();
            lblAnvändarnamn = new Label();
            lblLösenord = new Label();
            btnLoggaIn = new Button();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // txtAnvändarnamn
            // 
            txtAnvändarnamn.Location = new Point(12, 81);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(296, 31);
            txtAnvändarnamn.TabIndex = 0;
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(12, 190);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(296, 31);
            txtLösenord.TabIndex = 1;
            // 
            // lblAnvändarnamn
            // 
            lblAnvändarnamn.AutoSize = true;
            lblAnvändarnamn.Location = new Point(12, 53);
            lblAnvändarnamn.Name = "lblAnvändarnamn";
            lblAnvändarnamn.Size = new Size(133, 25);
            lblAnvändarnamn.TabIndex = 2;
            lblAnvändarnamn.Text = "Användarnamn";
            // 
            // lblLösenord
            // 
            lblLösenord.AutoSize = true;
            lblLösenord.Location = new Point(12, 162);
            lblLösenord.Name = "lblLösenord";
            lblLösenord.Size = new Size(86, 25);
            lblLösenord.TabIndex = 3;
            lblLösenord.Text = "Lösenord";
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(406, 312);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(112, 34);
            btnLoggaIn.TabIndex = 4;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(12, 312);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(112, 34);
            btnAvbryt.TabIndex = 5;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // LoggaIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 358);
            Controls.Add(btnAvbryt);
            Controls.Add(btnLoggaIn);
            Controls.Add(lblLösenord);
            Controls.Add(lblAnvändarnamn);
            Controls.Add(txtLösenord);
            Controls.Add(txtAnvändarnamn);
            Name = "LoggaIn";
            Text = "LoggaIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnvändarnamn;
        private TextBox txtLösenord;
        private Label lblAnvändarnamn;
        private Label lblLösenord;
        private Button btnLoggaIn;
        private Button btnAvbryt;
    }
}