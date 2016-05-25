using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
	public partial class PriceList : Form
	{
        private List<CategoryRecord> categoryRecords = new List<CategoryRecord>();

        public PriceList()
		{
			InitializeComponent();
            UpdateCategoryList();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            new NewCategory().ShowDialog();
            UpdateCategoryList();
        }

        private void UpdateCategoryList()
        {
            categoryListBox.Items.Clear();
            categoryRecords.Clear();

            foreach (CategoryRecord rec in StomaDB.GetCategories())
            {
                categoryListBox.Items.Add(rec.Data.Name);
                categoryRecords.Add(rec);
            }

            CategoryListOnIndexChange();
        }

        private void UpdateServiceList()
        {
            serviceListView.Items.Clear();

            if (categoryListBox.SelectedIndex >= 0)
            {
                Int64 id = categoryRecords[categoryListBox.SelectedIndex].ID;

                foreach (ServiceListRecord rec in StomaDB.GetServiceList(id))
                {
                    var item = new ListViewItem(new string[] {
                        rec.Data.Name,
					    rec.Data.Price.ToString()
                    });
                    item.Tag = rec;
                    serviceListView.Items.Add(item);
                }
            }

            ServiceListOnIndexChange();
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryListOnIndexChange();
        }

        private void CategoryListOnIndexChange()
        {
            if (categoryListBox.SelectedItems.Count == 0)
            {
                btnEditCat.Enabled = false;
                btnDelCat.Enabled = false;
                btnAdd.Enabled = false;
            }
            else
            {
                btnEditCat.Enabled = true;
                btnDelCat.Enabled = true;
                btnAdd.Enabled = true;
            }

            UpdateServiceList();
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            categoryRecords[categoryListBox.SelectedIndex].Delete();
            UpdateCategoryList();
        }

        private void serviceListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceListOnIndexChange();
        }

        private void ServiceListOnIndexChange()
        {
            if (serviceListView.SelectedItems.Count == 0)
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                return;
            }

            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Int64 id = categoryRecords[categoryListBox.SelectedIndex].ID;
            new NewService(id).ShowDialog();
            UpdateServiceList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceListRecord rec = (ServiceListRecord)serviceListView.SelectedItems[0].Tag;
            rec.Delete();
            UpdateServiceList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int64 id = categoryRecords[categoryListBox.SelectedIndex].ID;
            NewService form = new NewService(id);
            form.RecordForEditing = (ServiceListRecord)serviceListView.SelectedItems[0].Tag;
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdateServiceList();
            }
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            NewCategory form = new NewCategory();
            form.RecordForEditing = (CategoryRecord)categoryRecords[categoryListBox.SelectedIndex];
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdateCategoryList();
            }
        }
	}
}
