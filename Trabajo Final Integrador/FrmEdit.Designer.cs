namespace Trabajo_Final_Integrador
{
    partial class FrmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            lblCategoryEdit = new Label();
            lblDescriptionEdit = new Label();
            lblPriceEdit = new Label();
            lblTitleEdit = new Label();
            lblIdEdit = new Label();
            txtBoxIdEdit = new TextBox();
            btnCancelEdit = new Button();
            btnAcceptEdit = new Button();
            txtBoxCategoryEdit = new TextBox();
            txtBoxDescriptionEdit = new TextBox();
            txtBoxPriceEdit = new TextBox();
            txtBoxTitleEdit = new TextBox();
            SuspendLayout();
            // 
            // lblCategoryEdit
            // 
            lblCategoryEdit.AutoSize = true;
            lblCategoryEdit.ForeColor = SystemColors.Control;
            lblCategoryEdit.Location = new Point(51, 241);
            lblCategoryEdit.Name = "lblCategoryEdit";
            lblCategoryEdit.Size = new Size(68, 17);
            lblCategoryEdit.TabIndex = 47;
            lblCategoryEdit.Text = "Categoria:";
            // 
            // lblDescriptionEdit
            // 
            lblDescriptionEdit.AutoSize = true;
            lblDescriptionEdit.ForeColor = SystemColors.Control;
            lblDescriptionEdit.Location = new Point(51, 188);
            lblDescriptionEdit.Name = "lblDescriptionEdit";
            lblDescriptionEdit.Size = new Size(79, 17);
            lblDescriptionEdit.TabIndex = 46;
            lblDescriptionEdit.Text = "Descripcion:";
            // 
            // lblPriceEdit
            // 
            lblPriceEdit.AutoSize = true;
            lblPriceEdit.ForeColor = SystemColors.Control;
            lblPriceEdit.Location = new Point(51, 134);
            lblPriceEdit.Name = "lblPriceEdit";
            lblPriceEdit.Size = new Size(47, 17);
            lblPriceEdit.TabIndex = 45;
            lblPriceEdit.Text = "Precio:";
            // 
            // lblTitleEdit
            // 
            lblTitleEdit.AutoSize = true;
            lblTitleEdit.ForeColor = SystemColors.Control;
            lblTitleEdit.Location = new Point(51, 83);
            lblTitleEdit.Name = "lblTitleEdit";
            lblTitleEdit.Size = new Size(43, 17);
            lblTitleEdit.TabIndex = 44;
            lblTitleEdit.Text = "Titulo:";
            // 
            // lblIdEdit
            // 
            lblIdEdit.AutoSize = true;
            lblIdEdit.ForeColor = SystemColors.Control;
            lblIdEdit.Location = new Point(53, 33);
            lblIdEdit.Name = "lblIdEdit";
            lblIdEdit.Size = new Size(23, 17);
            lblIdEdit.TabIndex = 43;
            lblIdEdit.Text = "ID:";
            // 
            // txtBoxIdEdit
            // 
            txtBoxIdEdit.Location = new Point(53, 53);
            txtBoxIdEdit.Name = "txtBoxIdEdit";
            txtBoxIdEdit.ReadOnly = true;
            txtBoxIdEdit.Size = new Size(147, 25);
            txtBoxIdEdit.TabIndex = 42;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = SystemColors.ControlDarkDark;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.ForeColor = SystemColors.ButtonHighlight;
            btnCancelEdit.Location = new Point(143, 307);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(83, 26);
            btnCancelEdit.TabIndex = 41;
            btnCancelEdit.Text = "Cancelar";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnAcceptEdit
            // 
            btnAcceptEdit.BackColor = SystemColors.ControlDarkDark;
            btnAcceptEdit.FlatAppearance.BorderSize = 0;
            btnAcceptEdit.FlatStyle = FlatStyle.Flat;
            btnAcceptEdit.ForeColor = SystemColors.ButtonHighlight;
            btnAcceptEdit.Location = new Point(37, 307);
            btnAcceptEdit.Name = "btnAcceptEdit";
            btnAcceptEdit.Size = new Size(83, 26);
            btnAcceptEdit.TabIndex = 40;
            btnAcceptEdit.Text = "Aceptar";
            btnAcceptEdit.UseVisualStyleBackColor = false;
            btnAcceptEdit.Click += btnAcceptEdit_Click;
            // 
            // txtBoxCategoryEdit
            // 
            txtBoxCategoryEdit.Location = new Point(51, 262);
            txtBoxCategoryEdit.Name = "txtBoxCategoryEdit";
            txtBoxCategoryEdit.Size = new Size(149, 25);
            txtBoxCategoryEdit.TabIndex = 39;
            // 
            // txtBoxDescriptionEdit
            // 
            txtBoxDescriptionEdit.Location = new Point(51, 209);
            txtBoxDescriptionEdit.Name = "txtBoxDescriptionEdit";
            txtBoxDescriptionEdit.Size = new Size(149, 25);
            txtBoxDescriptionEdit.TabIndex = 38;
            // 
            // txtBoxPriceEdit
            // 
            txtBoxPriceEdit.Location = new Point(51, 153);
            txtBoxPriceEdit.Name = "txtBoxPriceEdit";
            txtBoxPriceEdit.Size = new Size(149, 25);
            txtBoxPriceEdit.TabIndex = 37;
            // 
            // txtBoxTitleEdit
            // 
            txtBoxTitleEdit.Location = new Point(51, 104);
            txtBoxTitleEdit.Name = "txtBoxTitleEdit";
            txtBoxTitleEdit.Size = new Size(149, 25);
            txtBoxTitleEdit.TabIndex = 36;
            // 
            // FrmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(848, 366);
            Controls.Add(lblCategoryEdit);
            Controls.Add(lblDescriptionEdit);
            Controls.Add(lblPriceEdit);
            Controls.Add(lblTitleEdit);
            Controls.Add(lblIdEdit);
            Controls.Add(txtBoxIdEdit);
            Controls.Add(btnCancelEdit);
            Controls.Add(btnAcceptEdit);
            Controls.Add(txtBoxCategoryEdit);
            Controls.Add(txtBoxDescriptionEdit);
            Controls.Add(txtBoxPriceEdit);
            Controls.Add(txtBoxTitleEdit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEdit";
            Text = "Editar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryEdit;
        private Label lblDescriptionEdit;
        private Label lblPriceEdit;
        private Label lblTitleEdit;
        private Label lblIdEdit;
        private TextBox txtBoxIdEdit;
        private Button btnCancelEdit;
        private Button btnAcceptEdit;
        private TextBox txtBoxCategoryEdit;
        private TextBox txtBoxDescriptionEdit;
        private TextBox txtBoxPriceEdit;
        private TextBox txtBoxTitleEdit;
    }
}