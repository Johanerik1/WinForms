namespace WinForm_GUI
{
    partial class LånÅterlämna
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
            dgvBokmaskiner = new DataGridView();
            lblTillgängligaBöcker = new Label();
            btnVäljStation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBokmaskiner).BeginInit();
            SuspendLayout();
            // 
            // dgvBokmaskiner
            // 
            dgvBokmaskiner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBokmaskiner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBokmaskiner.Location = new Point(12, 75);
            dgvBokmaskiner.Name = "dgvBokmaskiner";
            dgvBokmaskiner.RowHeadersWidth = 85;
            dgvBokmaskiner.RowTemplate.Height = 33;
            dgvBokmaskiner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBokmaskiner.Size = new Size(776, 317);
            dgvBokmaskiner.TabIndex = 0;
            dgvBokmaskiner.CellClick += dgvBokmaskiner_CellClick;
            // 
            // lblTillgängligaBöcker
            // 
            lblTillgängligaBöcker.AutoSize = true;
            lblTillgängligaBöcker.Location = new Point(12, 47);
            lblTillgängligaBöcker.Name = "lblTillgängligaBöcker";
            lblTillgängligaBöcker.Size = new Size(113, 25);
            lblTillgängligaBöcker.TabIndex = 1;
            lblTillgängligaBöcker.Text = "Bokmaskiner";
            // 
            // btnVäljStation
            // 
            btnVäljStation.Location = new Point(13, 404);
            btnVäljStation.Name = "btnVäljStation";
            btnVäljStation.Size = new Size(112, 34);
            btnVäljStation.TabIndex = 2;
            btnVäljStation.Text = "Välj";
            btnVäljStation.UseVisualStyleBackColor = true;
            btnVäljStation.Click += btnVäljStation_Click;
            // 
            // LånÅterlämna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVäljStation);
            Controls.Add(lblTillgängligaBöcker);
            Controls.Add(dgvBokmaskiner);
            Name = "LånÅterlämna";
            Text = "Hantera Boklån";
            Load += LånÅterlämna_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBokmaskiner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBokmaskiner;
        private Label lblTillgängligaBöcker;
        private Button btnVäljStation;
    }
}