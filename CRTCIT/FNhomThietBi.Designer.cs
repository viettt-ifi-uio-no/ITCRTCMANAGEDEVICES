namespace CRTCIT
{
    partial class FNhomThietBi
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
            this.dataGridNhom = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHe = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lblHe = new System.Windows.Forms.Label();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.btnAddNhom = new System.Windows.Forms.Button();
            this.btnDelNhom = new System.Windows.Forms.Button();
            this.btnEditNhom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhom)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridNhom
            // 
            this.dataGridNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNhom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridNhom.Location = new System.Drawing.Point(2, 2);
            this.dataGridNhom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNhom.MultiSelect = false;
            this.dataGridNhom.Name = "dataGridNhom";
            this.dataGridNhom.RowTemplate.Height = 28;
            this.dataGridNhom.Size = new System.Drawing.Size(508, 500);
            this.dataGridNhom.TabIndex = 5;
            this.dataGridNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNhom_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.02345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.97655F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridNhom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 504);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.67265F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.32735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.txtHe, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTenNhom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNhom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHe, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTenNhom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMaNhom, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNhom, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDelNhom, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnEditNhom, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(514, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 500);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtHe
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtHe, 2);
            this.txtHe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHe.Location = new System.Drawing.Point(111, 56);
            this.txtHe.Margin = new System.Windows.Forms.Padding(2);
            this.txtHe.Name = "txtHe";
            this.txtHe.Size = new System.Drawing.Size(224, 20);
            this.txtHe.TabIndex = 5;
            // 
            // txtTenNhom
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtTenNhom, 2);
            this.txtTenNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNhom.Location = new System.Drawing.Point(111, 29);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(224, 20);
            this.txtTenNhom.TabIndex = 3;
            // 
            // txtMaNhom
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtMaNhom, 2);
            this.txtMaNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNhom.Location = new System.Drawing.Point(111, 2);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(224, 20);
            this.txtMaNhom.TabIndex = 2;
            // 
            // lblHe
            // 
            this.lblHe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHe.AutoSize = true;
            this.lblHe.Location = new System.Drawing.Point(2, 54);
            this.lblHe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHe.Name = "lblHe";
            this.lblHe.Size = new System.Drawing.Size(105, 27);
            this.lblHe.TabIndex = 4;
            this.lblHe.Text = "Hệ";
            this.lblHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTenNhom.Location = new System.Drawing.Point(2, 27);
            this.lblTenNhom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(105, 27);
            this.lblTenNhom.TabIndex = 1;
            this.lblTenNhom.Text = "Tên Nhóm";
            this.lblTenNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(2, 0);
            this.lblMaNhom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(105, 27);
            this.lblMaNhom.TabIndex = 0;
            this.lblMaNhom.Text = "Mã Nhóm";
            this.lblMaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNhom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNhom.Location = new System.Drawing.Point(2, 83);
            this.btnAddNhom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(105, 72);
            this.btnAddNhom.TabIndex = 1;
            this.btnAddNhom.Text = "Thêm Nhóm";
            this.btnAddNhom.UseVisualStyleBackColor = false;
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // btnDelNhom
            // 
            this.btnDelNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelNhom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelNhom.Location = new System.Drawing.Point(111, 83);
            this.btnDelNhom.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelNhom.Name = "btnDelNhom";
            this.btnDelNhom.Size = new System.Drawing.Size(103, 72);
            this.btnDelNhom.TabIndex = 2;
            this.btnDelNhom.Text = "Xóa Nhóm";
            this.btnDelNhom.UseVisualStyleBackColor = false;
            this.btnDelNhom.Click += new System.EventHandler(this.btnDelNhom_Click);
            // 
            // btnEditNhom
            // 
            this.btnEditNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNhom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditNhom.Enabled = false;
            this.btnEditNhom.Location = new System.Drawing.Point(218, 83);
            this.btnEditNhom.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditNhom.Name = "btnEditNhom";
            this.btnEditNhom.Size = new System.Drawing.Size(117, 72);
            this.btnEditNhom.TabIndex = 6;
            this.btnEditNhom.Text = "Sửa";
            this.btnEditNhom.UseVisualStyleBackColor = false;
            this.btnEditNhom.Click += new System.EventHandler(this.btnEditNhom_Click);
            // 
            // FNhomThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FNhomThietBi";
            this.Text = "NhomThietBi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhom)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridNhom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtHe;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label lblHe;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.Button btnAddNhom;
        private System.Windows.Forms.Button btnDelNhom;
        private System.Windows.Forms.Button btnEditNhom;
    }
}