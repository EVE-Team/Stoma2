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

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItems.Count == 0)
            {
                btnEditCat.Enabled = false;
                btnDelCat.Enabled = false;
                return;
            }

            btnEditCat.Enabled = true;
            btnDelCat.Enabled = true;
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            int id = categoryId[categoryListBox.SelectedIndex];
            StomaDB.Instance.DeleteCategory(id);
            UpdateCategoryList();
        }
	}
}
