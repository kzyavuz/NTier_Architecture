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
    public partial class Form2 : Form
    {
        ProductRepository _productRepository;
        CategoryRepository _categoryRepository;

        public Form2()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
        }

        void ListCategories()
        {
            comboBoxCategori.DataSource = _categoryRepository.Select(x => new CategoryViewModel
            {
                ID = x.ID,
                CategoryName = x.CatagoryName,
                Description = x.Description
            }).ToList();


            comboBoxCategori.DisplayMember = "CategoryName";
            comboBoxCategori.ValueMember = "ID";
        }

        void ListProduct()
        {
            listBoxProduct.DataSource = _productRepository.Select(x => new ProductViewModel
            {
                ID = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                CategoryName = x.Category == null ? "Kategorisi yok" : x.Category.CatagoryName,
                CategoryID = x.CategoryID
            }).ToList();
        }

        ProductViewModel _selected;

        private void Form2_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProduct();
        }

        private void listBoxProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedItems.Count > -1)
            {
                _selected = listBoxProduct.SelectedItem as ProductViewModel;
                txtProductName.Text = _selected.ProductName;
                txtPrice.Text = _selected.UnitPrice.ToString();
                comboBoxCategori.SelectedValue = _selected.CategoryID != null ? _selected.CategoryID.Value : -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductName = txtProductName.Text;
                p.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                if (comboBoxCategori.SelectedIndex > -1)
                {
                    p.CategoryID = Convert.ToInt32(comboBoxCategori.SelectedValue);
                }
                _productRepository.Add(p);
                ListProduct();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selected != null)
            {
                Product product = new Product();
                _productRepository.Delete(product);
                ListProduct();
                _selected = null;
                txtProductName.Text = txtPrice.Text = null;
                comboBoxCategori.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selected == null)
                {
                    Product toProductUpdated = _productRepository.Find(_selected.ID);
                    toProductUpdated.ProductName = txtProductName.Text;
                    toProductUpdated.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                    if (comboBoxCategori.SelectedIndex > -1)
                    {
                        toProductUpdated.CategoryID = Convert.ToInt32(comboBoxCategori.SelectedValue);
                    }
                    else
                    {
                        _productRepository.Update(toProductUpdated);
                        ListProduct();
                        _selected = null;
                        txtPrice.Text = txtProductName.Text = null;
                        comboBoxCategori.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
