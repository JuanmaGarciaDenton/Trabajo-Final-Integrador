namespace Trabajo_Final_Integrador
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            dataGridView = new DataGridView();
            cntxMenuStripDelete = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxCategory = new ComboBox();
            btnAscDesc = new Button();
            btnNew = new Button();
            panel1 = new Panel();
            lblLimit = new Label();
            lblSeach = new Label();
            lblFilterCategory = new Label();
            lblNew = new Label();
            lblAscDesc = new Label();
            txtBoxLimit = new TextBox();
            txtBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            cntxMenuStripDelete.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.DarkSlateGray;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ContextMenuStrip = cntxMenuStripDelete;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 73);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1238, 557);
            dataGridView.TabIndex = 0;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // cntxMenuStripDelete
            // 
            cntxMenuStripDelete.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            cntxMenuStripDelete.Name = "cntxMenuStripDelete";
            cntxMenuStripDelete.Size = new Size(114, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(113, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cmbBoxCategory
            // 
            cmbBoxCategory.BackColor = Color.Maroon;
            cmbBoxCategory.FlatStyle = FlatStyle.Flat;
            cmbBoxCategory.ForeColor = SystemColors.ButtonFace;
            cmbBoxCategory.FormattingEnabled = true;
            cmbBoxCategory.Location = new Point(136, 33);
            cmbBoxCategory.Name = "cmbBoxCategory";
            cmbBoxCategory.Size = new Size(120, 25);
            cmbBoxCategory.TabIndex = 1;
            cmbBoxCategory.SelectedIndexChanged += cmbBoxCategory_SelectedIndexChanged;
            // 
            // btnAscDesc
            // 
            btnAscDesc.BackColor = Color.Maroon;
            btnAscDesc.FlatAppearance.BorderSize = 0;
            btnAscDesc.FlatStyle = FlatStyle.Flat;
            btnAscDesc.ForeColor = SystemColors.ButtonFace;
            btnAscDesc.Location = new Point(514, 32);
            btnAscDesc.Name = "btnAscDesc";
            btnAscDesc.Size = new Size(90, 24);
            btnAscDesc.TabIndex = 2;
            btnAscDesc.Text = "Descendente";
            btnAscDesc.UseVisualStyleBackColor = false;
            btnAscDesc.Click += btnAscDesc_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Maroon;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = SystemColors.ButtonFace;
            btnNew.Location = new Point(12, 32);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(90, 24);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(lblLimit);
            panel1.Controls.Add(lblSeach);
            panel1.Controls.Add(lblFilterCategory);
            panel1.Controls.Add(lblNew);
            panel1.Controls.Add(lblAscDesc);
            panel1.Controls.Add(txtBoxLimit);
            panel1.Controls.Add(txtBoxSearch);
            panel1.Controls.Add(btnAscDesc);
            panel1.Controls.Add(cmbBoxCategory);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 73);
            panel1.TabIndex = 5;
            // 
            // lblLimit
            // 
            lblLimit.AutoSize = true;
            lblLimit.ForeColor = Color.MintCream;
            lblLimit.Location = new Point(379, 11);
            lblLimit.Name = "lblLimit";
            lblLimit.Size = new Size(110, 17);
            lblLimit.TabIndex = 11;
            lblLimit.Text = "Limitar Productos";
            // 
            // lblSeach
            // 
            lblSeach.AutoSize = true;
            lblSeach.ForeColor = Color.MintCream;
            lblSeach.Location = new Point(289, 11);
            lblSeach.Name = "lblSeach";
            lblSeach.Size = new Size(61, 17);
            lblSeach.TabIndex = 10;
            lblSeach.Text = "Buscar Id";
            lblSeach.Click += lblSeach_Click;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.ForeColor = Color.MintCream;
            lblFilterCategory.Location = new Point(136, 11);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(102, 17);
            lblFilterCategory.TabIndex = 9;
            lblFilterCategory.Text = "Filtrar Categoria";
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.ForeColor = Color.MintCream;
            lblNew.Location = new Point(5, 9);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(97, 17);
            lblNew.TabIndex = 8;
            lblNew.Text = "Crear Producto";
            lblNew.Click += lblNew_Click;
            // 
            // lblAscDesc
            // 
            lblAscDesc.AutoSize = true;
            lblAscDesc.ForeColor = Color.MintCream;
            lblAscDesc.Location = new Point(526, 9);
            lblAscDesc.Name = "lblAscDesc";
            lblAscDesc.Size = new Size(57, 17);
            lblAscDesc.TabIndex = 7;
            lblAscDesc.Text = "Ordenar";
            // 
            // txtBoxLimit
            // 
            txtBoxLimit.BackColor = Color.Maroon;
            txtBoxLimit.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLimit.ForeColor = SystemColors.ButtonFace;
            txtBoxLimit.Location = new Point(379, 34);
            txtBoxLimit.Name = "txtBoxLimit";
            txtBoxLimit.Size = new Size(102, 25);
            txtBoxLimit.TabIndex = 6;
            txtBoxLimit.TextChanged += txtBoxLimit_TextChanged;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BackColor = Color.Maroon;
            txtBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSearch.ForeColor = SystemColors.ButtonFace;
            txtBoxSearch.Location = new Point(289, 34);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(55, 25);
            txtBoxSearch.TabIndex = 5;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 630);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "Trabajo Final Integrador";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            cntxMenuStripDelete.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox cmbBoxCategory;
        private Button btnAscDesc;
        private Button btnNew;
        private ContextMenuStrip cntxMenuStripDelete;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel1;
        private TextBox txtBoxSearch;
        private TextBox txtBoxLimit;
        private Label lblLimit;
        private Label lblSeach;
        private Label lblFilterCategory;
        private Label lblNew;
        private Label lblAscDesc;
    }
}