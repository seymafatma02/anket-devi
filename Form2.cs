using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketödevi
{
    public partial class Form2 : Form
    {
        //Form2'yi çağırmak için Form1'deki OpenForm2WithValues metodunu kullanıyoruz. Bu metod, Form2'yi oluşturur ve seçilen öğelerin listesini ve toplamını alır. Sonra bu formu gösterir.
        //Form 1'den alınan seçilen öğeler ve toplam değer, Form 2'nin yapıcı metoduna iletiliyor.
        //Yapıcı metot, bu değerleri Form 2'deki uygun kontrol öğelerine (TextBox ve Label) yerleştiriyor.

        public Form2(int total, List<string> selectedItems)//Form2'nin yapıcı metodu, int total ve List<string> selectedItems parametrelerini alır.
                                                           //Yapıcı metot, aldığı bu değerleri Total ve SelectedItems özelliklerine atar.
        {
            InitializeComponent();
            Total = total;
            SelectedItems = selectedItems;
            // Form2'nin yapıcı metodunda, aldığımız değerleri TextBox'a yazıyoruz
            textBox1.Text = "Seçilen öğeler: "+"  \n " + string.Join("\n", selectedItems);
            label3.Text =  total.ToString();
        }

        public int Total { get; }
        public List<string> SelectedItems { get; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
