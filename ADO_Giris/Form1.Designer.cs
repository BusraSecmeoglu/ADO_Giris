namespace ADO_Giris
{
    partial class Form1
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
            this.btnFillProduct = new System.Windows.Forms.Button();
            this.btnFillCategory = new System.Windows.Forms.Button();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.btnGetCategory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillProduct
            // 
            this.btnFillProduct.Location = new System.Drawing.Point(49, 55);
            this.btnFillProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillProduct.Name = "btnFillProduct";
            this.btnFillProduct.Size = new System.Drawing.Size(164, 46);
            this.btnFillProduct.TabIndex = 0;
            this.btnFillProduct.Text = "Ürün Doldur";
            this.btnFillProduct.UseVisualStyleBackColor = true;
            this.btnFillProduct.Click += new System.EventHandler(this.btnFillProduct_Click);
            // 
            // btnFillCategory
            // 
            this.btnFillCategory.Location = new System.Drawing.Point(836, 55);
            this.btnFillCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillCategory.Name = "btnFillCategory";
            this.btnFillCategory.Size = new System.Drawing.Size(164, 46);
            this.btnFillCategory.TabIndex = 0;
            this.btnFillCategory.Text = "Kategori Doldur";
            this.btnFillCategory.UseVisualStyleBackColor = true;
            this.btnFillCategory.Click += new System.EventHandler(this.btnFillCategory_Click);
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(49, 144);
            this.btnGetProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(164, 46);
            this.btnGetProduct.TabIndex = 0;
            this.btnGetProduct.Text = "Ürün Getir";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // btnGetCategory
            // 
            this.btnGetCategory.Location = new System.Drawing.Point(836, 144);
            this.btnGetCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new System.Drawing.Size(164, 46);
            this.btnGetCategory.TabIndex = 0;
            this.btnGetCategory.Text = "Kategori Getir";
            this.btnGetCategory.UseVisualStyleBackColor = true;
            this.btnGetCategory.Click += new System.EventHandler(this.btnGetCategory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetCategory);
            this.Controls.Add(this.btnGetProduct);
            this.Controls.Add(this.btnFillCategory);
            this.Controls.Add(this.btnFillProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillProduct;
        private System.Windows.Forms.Button btnFillCategory;
        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.Button btnGetCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

