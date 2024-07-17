namespace Project.WindowsUI
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
            this.catName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.catDescription = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catName
            // 
            this.catName.AutoSize = true;
            this.catName.Location = new System.Drawing.Point(31, 43);
            this.catName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(80, 16);
            this.catName.TabIndex = 0;
            this.catName.Text = "Kategori Adı";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(136, 39);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(132, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(136, 90);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(132, 22);
            this.txtCategoryDescription.TabIndex = 3;
            // 
            // catDescription
            // 
            this.catDescription.AutoSize = true;
            this.catDescription.Location = new System.Drawing.Point(49, 90);
            this.catDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catDescription.Name = "catDescription";
            this.catDescription.Size = new System.Drawing.Size(63, 16);
            this.catDescription.TabIndex = 2;
            this.catDescription.Text = "Açıklama";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(136, 159);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 43);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(324, 43);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(704, 372);
            this.listBoxCategories.TabIndex = 5;
            this.listBoxCategories.Click += new System.EventHandler(this.listBoxCategories_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 220);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 43);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(136, 282);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 346);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // form2
            // 
            this.form2.Location = new System.Drawing.Point(928, 457);
            this.form2.Margin = new System.Windows.Forms.Padding(4);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(100, 43);
            this.form2.TabIndex = 9;
            this.form2.Text = "Form 2";
            this.form2.UseVisualStyleBackColor = true;
            this.form2.Click += new System.EventHandler(this.form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.form2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.catDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.catName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label catDescription;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button form2;
    }
}

