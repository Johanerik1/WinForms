namespace WinForm_GUI
{
    partial class Väljbok
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
            dataGridViewBöckerAttLåna = new DataGridView();
            lblTillgänligaBöcker = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöckerAttLåna).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBöckerAttLåna
            // 
            dataGridViewBöckerAttLåna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBöckerAttLåna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBöckerAttLåna.Location = new Point(12, 85);
            dataGridViewBöckerAttLåna.Name = "dataGridViewBöckerAttLåna";
            dataGridViewBöckerAttLåna.RowHeadersWidth = 62;
            dataGridViewBöckerAttLåna.RowTemplate.Height = 33;
            dataGridViewBöckerAttLåna.Size = new Size(761, 290);
            dataGridViewBöckerAttLåna.TabIndex = 0;
            dataGridViewBöckerAttLåna.CellClick += dataGridViewBöckerAttLåna_CellClick;
            // 
            // lblTillgänligaBöcker
            // 
            lblTillgänligaBöcker.AutoSize = true;
            lblTillgänligaBöcker.Location = new Point(12, 57);
            lblTillgänligaBöcker.Name = "lblTillgänligaBöcker";
            lblTillgänligaBöcker.Size = new Size(160, 25);
            lblTillgänligaBöcker.TabIndex = 1;
            lblTillgänligaBöcker.Text = "Tillgängliga Böcker";
            // 
            // Väljbok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTillgänligaBöcker);
            Controls.Add(dataGridViewBöckerAttLåna);
            Name = "Väljbok";
            Text = "Väljbok";
            Load += Väljbok_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöckerAttLåna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBöckerAttLåna;
        private Label lblTillgänligaBöcker;
    }
}