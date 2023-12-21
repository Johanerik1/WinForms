namespace WinForm_GUI
{
    partial class MALäggTillBok
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
            btnAvbryt = new Button();
            btnSparaBok = new Button();
            txtTitel = new TextBox();
            txtTågstation = new TextBox();
            txtFörfattare = new TextBox();
            lblTitel = new Label();
            lblFörFattare = new Label();
            lblÄrTillgänglig = new Label();
            lblTågstation = new Label();
            chbTillgänglighet = new CheckBox();
            SuspendLayout();
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(432, 397);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(112, 34);
            btnAvbryt.TabIndex = 0;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // btnSparaBok
            // 
            btnSparaBok.Location = new Point(12, 397);
            btnSparaBok.Name = "btnSparaBok";
            btnSparaBok.Size = new Size(112, 34);
            btnSparaBok.TabIndex = 1;
            btnSparaBok.Text = "Spara Bok";
            btnSparaBok.UseVisualStyleBackColor = true;
            btnSparaBok.Click += btnSparaBok_Click;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(12, 78);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(346, 31);
            txtTitel.TabIndex = 2;
            // 
            // txtTågstation
            // 
            txtTågstation.Location = new Point(12, 233);
            txtTågstation.Name = "txtTågstation";
            txtTågstation.Size = new Size(346, 31);
            txtTågstation.TabIndex = 3;
            // 
            // txtFörfattare
            // 
            txtFörfattare.Location = new Point(12, 157);
            txtFörfattare.Name = "txtFörfattare";
            txtFörfattare.Size = new Size(346, 31);
            txtFörfattare.TabIndex = 5;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(12, 50);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(44, 25);
            lblTitel.TabIndex = 7;
            lblTitel.Text = "Titel";
            // 
            // lblFörFattare
            // 
            lblFörFattare.AutoSize = true;
            lblFörFattare.Location = new Point(12, 129);
            lblFörFattare.Name = "lblFörFattare";
            lblFörFattare.Size = new Size(89, 25);
            lblFörFattare.TabIndex = 11;
            lblFörFattare.Text = "Författare";
            // 
            // lblÄrTillgänglig
            // 
            lblÄrTillgänglig.AutoSize = true;
            lblÄrTillgänglig.Location = new Point(12, 289);
            lblÄrTillgänglig.Name = "lblÄrTillgänglig";
            lblÄrTillgänglig.Size = new Size(118, 25);
            lblÄrTillgänglig.TabIndex = 12;
            lblÄrTillgänglig.Text = "Tillgänglighet";
            // 
            // lblTågstation
            // 
            lblTågstation.AutoSize = true;
            lblTågstation.Location = new Point(12, 205);
            lblTågstation.Name = "lblTågstation";
            lblTågstation.Size = new Size(93, 25);
            lblTågstation.TabIndex = 13;
            lblTågstation.Text = "Tågstation";
            // 
            // chbTillgänglighet
            // 
            chbTillgänglighet.AutoSize = true;
            chbTillgänglighet.Location = new Point(19, 319);
            chbTillgänglighet.Name = "chbTillgänglighet";
            chbTillgänglighet.Size = new Size(119, 29);
            chbTillgänglighet.TabIndex = 14;
            chbTillgänglighet.Text = "Tillgänglig";
            chbTillgänglighet.UseVisualStyleBackColor = true;
            // 
            // MALäggTillBok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 444);
            Controls.Add(chbTillgänglighet);
            Controls.Add(lblTågstation);
            Controls.Add(lblÄrTillgänglig);
            Controls.Add(lblFörFattare);
            Controls.Add(lblTitel);
            Controls.Add(txtFörfattare);
            Controls.Add(txtTågstation);
            Controls.Add(txtTitel);
            Controls.Add(btnSparaBok);
            Controls.Add(btnAvbryt);
            Name = "MALäggTillBok";
            Text = "Lägg Till Bok";
            Load += MALäggTillBok_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvbryt;
        private Button btnSparaBok;
        private TextBox txtTitel;
        private TextBox txtTågstation;
        private TextBox txtFörfattare;
        private Label lblTitel;
        private Label lblTågstation;
        private Label label2;
        private Label label3;
        private Label lblFörFattare;
        private Label lblÄrTillgänglig;
        private CheckBox chbTillgänglighet;
    }
}