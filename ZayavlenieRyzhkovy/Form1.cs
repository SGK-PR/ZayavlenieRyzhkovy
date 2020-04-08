using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ap=Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;



namespace ZayavlenieRyzhkovy
{
    public partial class Form1 : Form
    {
        private string[] vs = new string[] { "ИС-18-02" };
        private string[] vs1 = new string[] { "Афанасьев А.", "Чиликин А.", "Хусаинов М." };
        private string[] vs2 = new string[] { "Заявление" };


        public Form1()
        {
            InitializeComponent();
            cbGroup.Items.AddRange(vs);
            cbSurname.Items.AddRange(vs1);
            cbView.Items.AddRange(vs2);

        }
        
        private void btOpen_Click(object sender, EventArgs e)
        {
            Ap.Application app = new Ap.Application();
            Document doc = app.Documents.Add(Visible: true);

            Range r= doc.Range();
            r.Text = "Директору ГАПОУ СГК\n"  + 
                " О.Н.Шалдыбиной \n" +
            "Студент группы "+" " + cbGroup.SelectedItem+"\n"
            +    cbSurname.SelectedItem+"\n";
            r.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            r.Font.Size = 14;
            r.Font.Name = "Times New Roman";


           Range d = doc.Range();
            Object collapseDirection = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd;
            d.Collapse(ref collapseDirection);
            d.InsertParagraphAfter();
            d.Text = cbView.SelectedItem + "\n" + "Прошу назначить мне," +" "+ cbSurname.SelectedItem +" "+
                ",стипендию в размере 100000 р.(Ста тысяч рублей) за то, что я такой хороший" + "\n";
            d.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            d.Font.Size = 14;
            d.Font.Name = "Times New Roman";



            Range c = doc.Range();
            Object collapseDirection1 = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd;
            c.Collapse(ref collapseDirection);
            c.InsertParagraphAfter();
            c.Text = cbSurname.SelectedItem + "\n" + dateTimePicker1.Text;
            c.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            c.Font.Size = 14;
            c.Font.Name = "Times New Roman";

            doc.Save();
         
            try
            {
                doc.Close();
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
