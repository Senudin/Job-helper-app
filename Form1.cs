using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Senudin_app
{
    public partial class Form1 : Form
    {
        private const int V = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_cm_Click(object sender, EventArgs e)
        {
            panel_cm.Visible = true;
            panel_oil_paper.Visible = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_EAN.Text) || string.IsNullOrEmpty(textBox_quantity_product.Text))
                return;
            ListViewItem item = new ListViewItem(textBox_EAN.Text);
            item.SubItems.Add(textBox_name_product.Text);
            item.SubItems.Add(dateTimePicker_expire.Text);
            item.SubItems.Add(textBox_quantity_product.Text);
            listView1.Items.Add(item);
            textBox_EAN.Clear();
            textBox_name_product.Clear();
            textBox_quantity_product.Clear();

        }
private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[V]);
            else
                MessageBox.Show("Item not selected");
        }

        private void button_print_Click(object sender, EventArgs e)
        {
     
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("C:/Users/pc/Desktop/Prijava rokova za CM/Prijava rokova za CM.pdf", FileMode.Create));
            doc.Open();

            Paragraph p = new Paragraph("Crvena Jabuka Jajce PJ 2 Jajce");
            p.Alignment = Element.ALIGN_LEFT;
            p.SpacingBefore = 80f;

            Paragraph pl = new Paragraph("Najava povrata za CM");
            pl.Alignment = Element.ALIGN_CENTER;
            pl.SpacingBefore = 100f;
            pl.SpacingAfter = 100f;

            Paragraph pl1 = new Paragraph("U nastavku:");
            pl1.Alignment = Element.ALIGN_BASELINE;
            pl1.SpacingAfter = 30f;

            PdfPTable pdfPTable = new PdfPTable(listView1.Columns.Count);
            pdfPTable.DefaultCell.Padding = 2;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            foreach (ColumnHeader column in listView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                pdfPTable.AddCell(cell);
            }
            foreach (ListViewItem itemRow in listView1.Items)
            {
                int i = 0;
                for (i = 0; i < itemRow.SubItems.Count; i++)
                {
                    pdfPTable.AddCell(itemRow.SubItems[i].Text);
                }
                }

            string v = DateTime.Today.ToString();
            Paragraph pl2 = new Paragraph(v);
            pl2.Alignment = Element.ALIGN_BASELINE;
            pl2.SpacingBefore = 200f;

            doc.Add(p);
            doc.Add(pl);
            doc.Add(pl1);
            doc.Add(pdfPTable);
            doc.Add(pl2);
            doc.Close();
            MessageBox.Show("Sucessufull generated pdf file!");
        }

        private void button_oil_paper_Click(object sender, EventArgs e)
        {
            panel_oil_paper.Visible = true;
            panel_cm.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Senudin_app.mdf;Integrated Security=True";

            string Query1 = "insert into dbo.oil_paper (date, oil_quantity,paper_quantity,naylon_quantity)"+"values ('"+this.dateTimePicker_oil_paper.Text+"' , '"+textBox_oil_quantity.Text+"' , '"+textBox_paper_quantity.Text+"' , '"+textBox_naylon_quantity.Text+"');";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query1, conDatabase);
            SqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                conDatabase.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + ex.Message);
            }

            textBox_oil_quantity.Clear();
            textBox_naylon_quantity.Clear();
            textBox_paper_quantity.Clear();

        }

        private void button_display_data_Click(object sender, EventArgs e)
        {

                string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Senudin_app.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = new SqlCommand("select * from dbo.oil_paper", con))

            {
                con.Open();
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dataGridView_oil_paper.DataSource = dt;
                con.Close();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==  0)
            {
                string constring1 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Senudin_app.mdf;Integrated Security=True";

                using (SqlConnection con1 = new SqlConnection(constring1))
                using (SqlCommand cmd1 = new SqlCommand("select * from dbo.oil_paper WHERE DATEDIFF(Month, date,GETDATE()) = 1", con1))

                {
                    con1.Open();
                    var dt1 = new DataTable();
                    dt1.Load(cmd1.ExecuteReader());

                    dataGridView_oil_paper.DataSource = dt1;
                    con1.Close();

                }
                
                int sum_oil = 0;
                int sum_paper = 0;
                int sum_naylon = 0;

                for (int i = 0; i < dataGridView_oil_paper.Rows.Count; ++i)
                {

                    sum_oil += Convert.ToInt32(dataGridView_oil_paper.Rows[i].Cells[1].Value);
                    sum_paper += Convert.ToInt32(dataGridView_oil_paper.Rows[i].Cells[2].Value);
                    sum_naylon += Convert.ToInt32(dataGridView_oil_paper.Rows[i].Cells[4].Value);

                }

                MessageBox.Show("Kolicina ulja: " + sum_oil.ToString() + " Kolicina papira: " + sum_paper.ToString() + " Kolicina najlona: " + sum_naylon.ToString() + " ");

            }
            else
            {
                string path = "C:\\Users\\pc\\Desktop\\Prijava rokova za CM";
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
