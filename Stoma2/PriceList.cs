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
        public PriceList()
		{
			InitializeComponent();
            UpdateCategoryList();

			if (cmbCategory.Items.Count > 0)
			{
				cmbCategory.SelectedIndex = 0;
			}
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            new NewCategory().ShowDialog();
            UpdateCategoryList();
        }

		class CategoryItem : object
		{
			public CategoryItem(CategoryRecord rec)
			{
				m_rec = rec;
				Text = rec.Data.Name;
			}

			public string Text { get; set; }

			public CategoryRecord Record { get { return m_rec; } }
			private CategoryRecord m_rec;

			public override string ToString()
			{
				return Text;
			}
		}

        private void UpdateCategoryList()
        {
			Int64 selectedID = -1;
			if (cmbCategory.SelectedIndex >= 0)
			{
				selectedID = (cmbCategory.SelectedItem as CategoryItem).Record.ID;
			}

            cmbCategory.Items.Clear();

			var items = new List<CategoryItem>();
            foreach (CategoryRecord rec in StomaDB.GetCategories())
            {
				items.Add(new CategoryItem(rec));
			}
			items.Sort(Comparer<CategoryItem>.Create((i1, i2) => i1.Text.CompareTo(i2.Text)));

			bool itemSelected = false;
			for (int index = 0; index < items.Count; index++)
			{
				var item = items[index];

				cmbCategory.Items.Add(item);
				if (item.Record.ID == selectedID)
				{
					cmbCategory.SelectedIndex = index;
					itemSelected = true;
				}
			}

			if (!itemSelected && cmbCategory.Items.Count > 0)
			{
				cmbCategory.SelectedIndex = 0;
			}

            CategoryListOnIndexChange();
        }

        private void UpdateServiceList()
        {
            serviceListView.Items.Clear();

			if (cmbCategory.SelectedIndex >= 0)
            {
				Int64 id = (cmbCategory.SelectedItem as CategoryItem).Record.ID;
				
                foreach (ServiceListRecord rec in StomaDB.GetServiceList(id, 0))
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

        private void CategoryListOnIndexChange()
        {
			if (cmbCategory.SelectedIndex >= 0)
			{
				btnEditCat.Enabled = true;
				btnDelCat.Enabled = true;
				btnAdd.Enabled = true;
			}
			else
            {
                btnEditCat.Enabled = false;
                btnDelCat.Enabled = false;
                btnAdd.Enabled = false;
            }

            UpdateServiceList();
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить категорию?\n" +
                "(вместе с ней будут удалены связанные услуги)",
                "Удаление категории", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                CategoryItem rec = (CategoryItem)cmbCategory.SelectedItem;
                CategoryRecord recData = rec.Record;
                CategoryFields data = recData.Data;
                data.obsolete = 1;
                recData.Save();
                UpdateCategoryList();
            }
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
			Int64 id = (cmbCategory.SelectedItem as CategoryItem).Record.ID;
            new NewService(id).ShowDialog();
            UpdateServiceList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceListRecord rec = (ServiceListRecord)serviceListView.SelectedItems[0].Tag;

            ServiceListFields recData = rec.Data;
            recData.obsolete = 1;
            rec.Save();
            UpdateServiceList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
			Int64 id = (cmbCategory.SelectedItem as CategoryItem).Record.ID;
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
			form.RecordForEditing = (cmbCategory.SelectedItem as CategoryItem).Record;
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdateCategoryList();
            }
        }

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			CategoryListOnIndexChange();
		}

		private void serviceListView_Resize(object sender, EventArgs e)
		{
			serviceListView.Columns[0].Width = serviceListView.Width - 100;
		}

		private void PriceList_Shown(object sender, EventArgs e)
		{
			Refresh();
		}

		private void groupBox2_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),
				new Rectangle(cmbCategory.Location.X - 1,
					cmbCategory.Location.Y - 1,
					cmbCategory.Size.Width + 1,
					cmbCategory.Size.Height + 1));
		}
	}
}
