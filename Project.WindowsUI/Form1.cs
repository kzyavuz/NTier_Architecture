using Project.WindowsUI.ViewModels;
using Project_BLL.DesignPattems.GenericRepository.ConcRep;
using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WindowsUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _categoryRepository;
        CategoryViewModel _selected;

        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

        void ListCategories()
        {
            listBoxCategories.DataSource = _categoryRepository.Select(x => new CategoryViewModel
            {
                ID = x.ID,
                CategoryName = x.CatagoryName,
                Description = x.Description,
                Products = x.Products
            }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                MessageBox.Show("Lütfen Kategori işmini giriniz");
                return;
            }

            Category c = new Category()
            {
                CatagoryName = txtCategoryName.Text,
                Description = txtCategoryDescription.Text
            };
            _categoryRepository.Add(c);
            ListCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category toBeUpdate = _categoryRepository.Find(_selected.ID);
                toBeUpdate.CatagoryName = txtCategoryName.Text;
                toBeUpdate.Description = txtCategoryDescription.Text;
                _categoryRepository.Update(toBeUpdate);
                ListCategories();
                _selected = null;
                txtCategoryDescription = txtCategoryName = null;
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçiniz");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category ToBeDeleteCategory = _categoryRepository.Find(_selected.ID);
                _categoryRepository.Delete(ToBeDeleteCategory);
                ListCategories();
                _selected = null;
                txtCategoryDescription.Text = txtCategoryName.Text = null;
            }
        }

        private void form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void listBoxCategories_Click(object sender, EventArgs e)
        {
            if(listBoxCategories.SelectedIndex > -1)
            {
                _selected = (CategoryViewModel)listBoxCategories.SelectedItem;
                txtCategoryName.Text = _selected.CategoryName;
                txtCategoryDescription.Text = _selected.Description;
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori Seçiniz");
            }
        }
    }
}
