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
        private List<int> categoryId = new List<int>();

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
            categoryId.Clear();

            var reader = StomaDB.Instance.GetCategoriesReader();

            while (reader.Read())
            {
                categoryListBox.Items.Add(reader["name"]);
                categoryId.Add(Convert.ToInt32(reader["id"]));
            }

            CategoryListOnIndexChange();
        }

        private void UpdateServiceList()
        {
            serviceListView.Items.Clear();

            if (categoryListBox.SelectedIndex >= 0)
            {
                Int64 id = categoryId[categoryListBox.SelectedIndex];

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
            int id = categoryId[categoryListBox.SelectedIndex];
            StomaDB.Instance.DeleteCategory(id);
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
            int id = categoryId[categoryListBox.SelectedIndex];
            new NewService(id).ShowDialog();
            UpdateServiceList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceListRecord rec = (ServiceListRecord)serviceListView.SelectedItems[0].Tag;
            rec.Delete();
            UpdateServiceList();
        }
	}
}
