﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;


namespace PrintTableNew
{
    public partial class Debitors : Form
    {
        public Debitors()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int currentPage = 1;
        int pagesize = 40;
        private void Debitors_Load(object sender, EventArgs e)
        {
            using (storeEntities dbo = new storeEntities())
            {
                IPagedList list = dbo.Debitors.OrderBy(p => p.Id).ToPagedList(currentPage, pagesize);
                btnNext.Enabled = list.IsFirstPage;
                btnPrevious.Enabled = list.IsLastPage;
                lblPageNumber.Text = string.Format("Page {0}/{1}", list.PageNumber, list.PageCount);
                debitorBindingSource.DataSource = list;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using (storeEntities dbo = new storeEntities())
            {
                currentPage++;
                IPagedList list = dbo.Debitors.OrderBy(p => p.Id).ToPagedList(currentPage, pagesize);
                btnNext.Enabled = list.IsFirstPage;
                btnPrevious.Enabled = list.IsLastPage;
                lblPageNumber.Text = string.Format("Page {0}/{1}", list.PageNumber, list.PageCount);
                debitorBindingSource.DataSource = list;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            using (storeEntities dbo = new storeEntities())
            {
                currentPage--;
                IPagedList list = dbo.Debitors.OrderBy(p => p.Id).ToPagedList(currentPage, pagesize);
                btnNext.Enabled = list.IsFirstPage;
                btnPrevious.Enabled = list.IsLastPage;
                lblPageNumber.Text = string.Format("Page {0}/{1}", list.PageNumber, list.PageCount);
                debitorBindingSource.DataSource = list;
            }
        }
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView.Height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            dataGridView.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
