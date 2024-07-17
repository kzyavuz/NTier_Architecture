namespace Project.WindowsUI
{
    partial class Form2
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.catDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.catName = new System.Windows.Forms.Label();
            this.comboBoxCategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 312);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 43);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 312);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(214, 238);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 43);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 16;
            this.listBoxProduct.Location = new System.Drawing.Point(397, 52);
            this.listBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(704, 372);
            this.listBoxProduct.TabIndex = 15;
            this.listBoxProduct.Click += new System.EventHandler(this.listBoxProduct_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(96, 238);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 43);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(209, 99);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // catDescription
            // 
            this.catDescription.AutoSize = true;
            this.catDescription.Location = new System.Drawing.Point(110, 99);
            this.catDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catDescription.Name = "catDescription";
            this.catDescription.Size = new System.Drawing.Size(70, 16);
            this.catDescription.TabIndex = 12;
            this.catDescription.Text = "Ürün Fiyatı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(209, 48);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(132, 22);
            this.txtProductName.TabIndex = 11;
            // 
            // catName
            // 
            this.catName.AutoSize = true;
            this.catName.Location = new System.Drawing.Point(122, 52);
            this.catName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(58, 16);
            this.catName.TabIndex = 10;
            this.catName.Text = "Ürün Adı";
            // 
            // comboBoxCategori
            // 
            this.comboBoxCategori.FormattingEnabled = true;
            this.comboBoxCategori.Location = new System.Drawing.Point(209, 137);
            this.comboBoxCategori.Name = "comboBoxCategori";
            this.comboBoxCategori.Size = new System.Drawing.Size(132, 24);
            this.comboBoxCategori.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Seç";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategori);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxProduct);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.catDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.catName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label catDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label catName;
        private System.Windows.Forms.ComboBox comboBoxCategori;
        private System.Windows.Forms.Label label1;
    }
}