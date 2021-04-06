
namespace FormUI
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxSupplierId = new System.Windows.Forms.TextBox();
            this.tbxCategoryId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 328);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(112, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Id:";
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxId.Location = new System.Drawing.Point(137, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(150, 16);
            this.tbxId.TabIndex = 40;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProductUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProductUpdate.Image")));
            this.btnProductUpdate.Location = new System.Drawing.Point(324, 60);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(162, 42);
            this.btnProductUpdate.TabIndex = 39;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDelete.Image")));
            this.btnProductDelete.Location = new System.Drawing.Point(408, 12);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(78, 42);
            this.btnProductDelete.TabIndex = 38;
            this.btnProductDelete.Text = "Sil";
            this.btnProductDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductAdd.ForeColor = System.Drawing.Color.White;
            this.btnProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnProductAdd.Image")));
            this.btnProductAdd.Location = new System.Drawing.Point(324, 12);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(78, 42);
            this.btnProductAdd.TabIndex = 35;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxUnitsInStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUnitsInStock.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxUnitsInStock.Location = new System.Drawing.Point(139, 144);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(148, 16);
            this.tbxUnitsInStock.TabIndex = 33;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUnitPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxUnitPrice.Location = new System.Drawing.Point(139, 122);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(148, 16);
            this.tbxUnitPrice.TabIndex = 32;
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxProductName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxProductName.Location = new System.Drawing.Point(137, 78);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(150, 16);
            this.tbxProductName.TabIndex = 31;
            // 
            // tbxSupplierId
            // 
            this.tbxSupplierId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxSupplierId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSupplierId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSupplierId.Location = new System.Drawing.Point(137, 56);
            this.tbxSupplierId.Name = "tbxSupplierId";
            this.tbxSupplierId.Size = new System.Drawing.Size(150, 16);
            this.tbxSupplierId.TabIndex = 30;
            // 
            // tbxCategoryId
            // 
            this.tbxCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCategoryId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxCategoryId.Location = new System.Drawing.Point(137, 34);
            this.tbxCategoryId.Name = "tbxCategoryId";
            this.tbxCategoryId.Size = new System.Drawing.Size(150, 16);
            this.tbxCategoryId.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(57, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Stok Adedi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(66, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Birim fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(98, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(72, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tedarikçi Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kategori Id";
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbxQuantityPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxQuantityPerUnit.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(139, 100);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(148, 16);
            this.tbxQuantityPerUnit.TabIndex = 42;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(741, 494);
            this.Controls.Add(this.tbxQuantityPerUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.tbxUnitsInStock);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.tbxSupplierId);
            this.Controls.Add(this.tbxCategoryId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxSupplierId;
        private System.Windows.Forms.TextBox tbxCategoryId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
    }
}