namespace Trabajo_Final_Integrador
{
    partial class FrmNew
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNew));
            lblCategory = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblTitle = new Label();
            lblId = new Label();
            txtBoxId = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            txtBoxCategory = new TextBox();
            txtBoxDescription = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxTitle = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = SystemColors.Window;
            lblCategory.Location = new Point(63, 260);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 17);
            lblCategory.TabIndex = 35;
            lblCategory.Text = "Categoria:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.Window;
            lblDescription.Location = new Point(63, 206);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 17);
            lblDescription.TabIndex = 34;
            lblDescription.Text = "Descripcion:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = SystemColors.Window;
            lblPrice.Location = new Point(63, 152);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 17);
            lblPrice.TabIndex = 33;
            lblPrice.Text = "Precio:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(63, 101);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 17);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Titulo:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.Window;
            lblId.Location = new Point(65, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 17);
            lblId.TabIndex = 31;
            lblId.Text = "ID:";
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(65, 71);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.ReadOnly = true;
            txtBoxId.Size = new Size(147, 25);
            txtBoxId.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.HotTrack;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(155, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 26);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.Info;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.ForeColor = SystemColors.ActiveCaption;
            btnAccept.Location = new Point(49, 325);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(83, 26);
            btnAccept.TabIndex = 28;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtBoxCategory
            // 
            txtBoxCategory.Location = new Point(63, 280);
            txtBoxCategory.Name = "txtBoxCategory";
            txtBoxCategory.Size = new Size(149, 25);
            txtBoxCategory.TabIndex = 27;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(63, 227);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(149, 25);
            txtBoxDescription.TabIndex = 26;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(63, 171);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(149, 25);
            txtBoxPrice.TabIndex = 25;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(63, 122);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(149, 25);
            txtBoxTitle.TabIndex = 24;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmNew
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(291, 403);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Controls.Add(lblId);
            Controls.Add(txtBoxId);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtBoxCategory);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxTitle);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmNew";
            Text = "Agregar Producto";
            Load += FrmNew_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblTitle;
        private Label lblId;
        private TextBox txtBoxId;
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtBoxCategory;
        private TextBox txtBoxDescription;
        private TextBox txtBoxPrice;
        private TextBox txtBoxTitle;
        private ErrorProvider errorProvider1;
    }
}