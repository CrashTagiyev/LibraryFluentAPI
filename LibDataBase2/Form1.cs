using ConsoleApp1.Contex;
using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace LibDataBase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var contex = new LibDbContext())
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibDbContext())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        context.Add(new Authors() { Fistname = $"Auuthor {i}", Lastname = $"Auuthorov {i}" });
                    }
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new LibDbContext())
                {
                    for (int i = 0; i < context.Authors.Count(); i++)
                    {
                        ListViewItem lvi = new ListViewItem("Id:" + context.Authors.ToList()[i].Id + " " + context.Authors.ToList()[i].Fistname + " " + context.Authors.ToList()[i].Lastname + "\n");
                        AuthorsListView.Items.Add(lvi);
                    }
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}