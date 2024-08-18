using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace anketödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenForm2WithValues(int total, List<string> selectedItems)//Butona tıkladığında, tüm soruların cevaplarını alır, gerekli kontrolleri yapar ve
                                                                               //OpenForm2WithValues metodunu çağırır.
                                                                               //Tüm kontroller tamamsa, kullanıcının seçtiği cevaplar ve toplam değer Form 2'ye aktarılıyor ve Form 2 gösteriliyor. Bu işlem, OpenForm2WithValues metodunda gerçekleştiriliyor.
        {
            Form2 form2 = new Form2(total, selectedItems);
            form2.Show();
            this.Hide(); // Form1'i gizle
        }
        public int GetValue(GroupBox gB) //GetValue metodu, her bir grup kutusundan seçilen değeri RadioButton'un değerini döndürür. 
        {
            int value = -1; // Seçim yapılmadığında -1 döndürmek için varsayılan değer
            foreach (RadioButton r in gB.Controls)
            {
                if (r.Checked)
                {
                    value = Convert.ToInt32(r.Text);
                    break; // Seçilen RadioButton'u bulduktan sonra döngüyü sonlandır
                }
            }
            return value;
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private bool IsAnyGroupBoxEmpty()//IsAnyGroupBoxEmpty metodu, herhangi bir grup kutusunun boş olup olmadığını kontrol eder.
        {
            foreach (Control control in Controls)
            {
                if (control is GroupBox groupBox)
                {
                    bool groupBoxEmpty = true;
                    foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                    {
                        if (radioButton.Checked)
                        {
                            groupBoxEmpty = false;
                            break; // En az bir RadioButton seçilmişse, GroupBox boş değil demektir, döngüyü sonlandır
                        }
                    }
                    if (groupBoxEmpty)
                    {
                        return true; // Bir GroupBox'un içi boşsa, true döndür
                    }
                }
            }
            return false; // Hiçbir GroupBox boş değilse, false döndür
        }
        private bool IsCheckedListBoxEmpty() //IsCheckedListBoxEmpty metodu, kontrol listesi kutusunun boş olup olmadığını kontrol eder
        {
            return checkedListBox1.CheckedItems.Count == 0;
        }

        private void button1_Click(object sender, EventArgs e)//button1_Click olayı, kullanıcının cevapları göndermek için butona tıkladığında tetiklenir.
        {
            int  soru1 = GetValue(groupBox1);
            int soru2 = GetValue(groupBox2);
            int soru3 = GetValue(groupBox3);
            int soru4 = GetValue(groupBox4);
            int soru5 = GetValue(groupBox5);
            int soru6 = GetValue(groupBox6);
            int soru7 = GetValue(groupBox7);
            int soru8 = GetValue(groupBox8);
            int soru9 = GetValue(groupBox9);
            int soru10 = GetValue(groupBox10);
            
            // Öncelikle, checkedListBox1 içindeki seçili öğelerin metnini bir dize listesine ekleyelim
            bool groupBoxesEmpty = IsAnyGroupBoxEmpty();
             bool checkedListBoxEmpty = IsCheckedListBoxEmpty();
            // Koşulu kontrol et
            if (groupBoxesEmpty || checkedListBoxEmpty)
            {
                // Eğer herhangi bir grup kutusu boşsa veya kontrol listesi kutusu boşsa, uygun bir mesaj göster
                if (groupBoxesEmpty)
                {
                    MessageBox.Show("Lütfen tüm soruları yanıtlayın!", "Anket Eksik Dolduruldu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (checkedListBoxEmpty)
                {
                    MessageBox.Show("Lütfen en az bir öğe seçin!", "Öğe Seçimi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                int total = soru1 + soru2 + soru3 + soru4 + soru5 + soru6 + soru7 + soru8 + soru9 + soru10;
                List<string> selectedItemsList = new List<string>();
                foreach (object item in checkedListBox1.CheckedItems)//checkedListBox1.CheckedItems özelliği, checkedListBox1 kontrolünde işaretlenmiş öğelerin bir koleksiyonunu döndürür. 
                {//foreach döngüsüyle, checkedListBox1.CheckedItems koleksiyonundaki her bir öğe üzerinde gezinilir.
                    //Her bir öğe, item adı altında geçici bir değişkene atanır.
                    //item.ToString() metodu kullanılarak, item'ın metinsel değeri alınır ve selectedItemsList listesine eklenir.
                    selectedItemsList.Add(item.ToString());
                }

                OpenForm2WithValues(total, selectedItemsList);// OpenForm2WithValues metodu, Form2'yi açar ve seçilen değerleri aktarır.
            }

        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
