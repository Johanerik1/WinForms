namespace WinForm_GUI
{
    partial class MAHanteraBok
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
            dataGridView1 = new DataGridView();
            btnRefreshDataGridView = new Button();
            btnTaBortBok = new Button();
            btnLäggTillBok = new Button();
            lblBokHantering = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(914, 413);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnRefreshDataGridView
            // 
            btnRefreshDataGridView.ForeColor = SystemColors.ActiveCaptionText;
            btnRefreshDataGridView.Location = new Point(814, 523);
            btnRefreshDataGridView.Name = "btnRefreshDataGridView";
            btnRefreshDataGridView.Size = new Size(112, 34);
            btnRefreshDataGridView.TabIndex = 1;
            btnRefreshDataGridView.Text = "Refresh";
            btnRefreshDataGridView.UseVisualStyleBackColor = true;
            btnRefreshDataGridView.Click += btnRefreshDataGridView_Click;
            // 
            // btnTaBortBok
            // 
            btnTaBortBok.Location = new Point(161, 523);
            btnTaBortBok.Name = "btnTaBortBok";
            btnTaBortBok.Size = new Size(112, 34);
            btnTaBortBok.TabIndex = 2;
            btnTaBortBok.Text = "Ta Bort Bok";
            btnTaBortBok.UseVisualStyleBackColor = true;
            btnTaBortBok.Click += btnTaBortBok_Click;
            // 
            // btnLäggTillBok
            // 
            btnLäggTillBok.Location = new Point(12, 523);
            btnLäggTillBok.Name = "btnLäggTillBok";
            btnLäggTillBok.Size = new Size(130, 34);
            btnLäggTillBok.TabIndex = 3;
            btnLäggTillBok.Text = "Lägg Till Bok";
            btnLäggTillBok.UseVisualStyleBackColor = true;
            btnLäggTillBok.Click += btnLäggTillBok_Click;
            // 
            // lblBokHantering
            // 
            lblBokHantering.AutoSize = true;
            lblBokHantering.Location = new Point(12, 53);
            lblBokHantering.Name = "lblBokHantering";
            lblBokHantering.Size = new Size(117, 25);
            lblBokHantering.TabIndex = 4;
            lblBokHantering.Text = "Bokhantering";
            // 
            // MAHanteraBok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(936, 563);
            Controls.Add(lblBokHantering);
            Controls.Add(btnLäggTillBok);
            Controls.Add(btnTaBortBok);
            Controls.Add(btnRefreshDataGridView);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MAHanteraBok";
            Text = "Hantera Bok";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRefreshDataGridView;
        private Button btnTaBortBok;
        private Button btnLäggTillBok;
        private Label lblBokHantering;
    }
}
