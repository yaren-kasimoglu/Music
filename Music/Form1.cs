using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bağlantımızı global alanda tanımlıyoruz
        MySqlConnection baglanti = new MySqlConnection("SERVER = localhost; DATABASE = muzikler; UID = root; PWD = Yaren.7030*");

        void listele() //listele adında bir void oluşturuyoruz. Form yüklenince ve ekleme/silme gibi işlemlerden sonra bu voidi çağırmamız gerekicek
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select muzikad from tbl_muzik order by muzikad", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]).ToString();
                //sadece müzik isimlerini çekmemiz yeterli olucak. müzik yolunu nerde kullanacağımızı ilerleyen kısımlarda göreceğiz
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele(); //form yüklenince databse de kayıtlı müzikleri listbox'a listeliyoruz
        }
        string sarkiyol, sarkiad;

        private void btnsarkiekle_Click(object sender, EventArgs e) //şarkı ekleme butonu
        {
            OpenFileDialog open = new OpenFileDialog(); //müzik eklemek için openfiledialog kullanacağız. isterseniz araç kısmından ekleyipte kullanabilirsiniz
            open.Multiselect = true; //multiselect true yapıyoruz ki tek seferde birden çok müzik ekleyebilelim
            open.Filter = "Music Files(*.mp3)|*.mp3"; //filterimiz ise mp3 formatındaki dosyalar. böylece mp3 formatı dışında veri eklemenin önüne geçmiş oluyoruz
            if (open.ShowDialog() == DialogResult.OK) //eğer openfiledialog açılıp tamam denirse şunu şunu yap:
            {
                for (int i = 0; i <= open.SafeFileNames.Length - 1; i++) //eklemek istediğimiz şarkının isminı i adlı değişkende tutuyoruz
                {
                    sarkiad = Convert.ToString(open.SafeFileNames[i]); //müzik ismini sarkiad isimli string'de tutuyorum
                    sarkiyol = Convert.ToString(open.FileNames[i]); //müzik yolunu ise sarkiyol isimli değişkende tutuyorum

                    //şimdi buraya bi if şartı eklememiz lazım. aynı şarkıyı birdaha sql'e eklememek için bunu yapmamız lazım.
                    if (listBox1.Items.Contains(sarkiad) == true) //eğer seçtiğimiz şarkı listbox'da var ise şunu yap
                    {
                        baglanti.Open();
                        //eğer eklemek istediğimiz şarkı listbox'da var ise müzik yolunu güncelliyorum. bunu yapmamın sebebi eğer müzik yolu değişmiş ise 
                        //müziği silip yeniden eklemek yerine direk müzik yolunu güncelliyoruz. böylece tekrar sil/ekle işlemlerine gerek kalmıyor.
                        //aynı zamanda aynı müzikten birkaç tane eklemenin önüne geçilmiş olunuyor.
                        MySqlCommand komut = new MySqlCommand("update tbl_muzik set muzikyol=@p1 where muzikad=@p2", baglanti);
                        komut.Parameters.AddWithValue("@p1", sarkiyol);
                        komut.Parameters.AddWithValue("@p2", sarkiad);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else //eğer ekliyeceğimiz şarkı listbox'da yok ise şunu yap:
                    {
                        baglanti.Open();
                        //artık burda şarkı ekleme kısmına geçiyoruz. tbl_müzikler adlı tablomuza şarkının adını ve yolunu kaydediyoruz
                        MySqlCommand komut = new MySqlCommand("insert into tbl_muzik (muzikad,muzikyol) values (@p1,@p2)", baglanti);
                        komut.Parameters.AddWithValue("@p1", sarkiad);
                        komut.Parameters.AddWithValue("@p2", sarkiyol);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
            }
            //ardından listbox'u temizlememiz lazım. temizlemez isek şarkıları 2 defa görüntülemiş oluruz.(tam anlatamadım ama deneyip görmeniz daha iyi olur :) )
            listBox1.Items.Clear();
            listele(); //ardından listele metodumuzu çağırıp listbox'da şarkı isimlerini görüntülüyoruz
        }

        private void btnsarkisil_Click(object sender, EventArgs e) //şarkı sil butonu
        {
            baglanti.Open();

            if (listBox1.Items.Count == 0) //ilk olarak listede hiç şarkı yok ise mesaj box ile bi uyarı veriyoruz
            {
                MessageBox.Show("Müzik bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBox1.SelectedItem == null) //eğer listbox'da item var ise ama hiçbir şarkı seçilmemiş ise başka bir uyarı veriyoruz
            {
                MessageBox.Show("Silmek için bir şarkı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Seçilen müziği silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //eğer kullanıcı evet'e basarsa şunları yap
                baglanti.Close();
                baglanti.Open();
                //müziğin ismine göre silme işlemini gerçekleştiricez. aynı isme sahip sadece 1 müzik olucağından sadece seçili müzik tablodan silinecek
                MySqlCommand komut = new MySqlCommand("delete from tbl_muzik where muzikad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", Convert.ToString(listBox1.SelectedItem)); //parametremiz listbox'da seçilmiş olan item
                komut.ExecuteNonQuery();
                baglanti.Close();
                listBox1.Items.Clear(); //ardından listbox'u temizleyip verileri tekrar listeliyoruz
                listele();
            }
            baglanti.Close();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) //listbox'a çift tıklandığında
        {
            baglanti.Open();
            //muzik adı listbox'da seçilen değer olanın müzik yolunu select sorgusu ile getiriyoruz
            MySqlCommand komut = new MySqlCommand("select muzikyol from tbl_muzik where muzikad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToString(listBox1.SelectedItem)); //şartımız listbox'da seçilen item. buda seçilen müziğin ismi demek
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                axWindowsMediaPlayer1.URL = dr[0].ToString(); //media player'a oynatacağı şarkının yolunu gösteriyoruz. 
                                                              //select sorgusundan gelen değer seçtiğimiz şarkının müzik yolu
                                                              //böylece media player'ın oynatacağı şarkıyı belirlemiş oluyoruz

                axWindowsMediaPlayer1.Ctlcontrols.play(); //ardından media player'ı başlatıyoruz
            }
            baglanti.Close();
        }


        private void btnoynat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play(); //media playerı oynat
        }

        private void btnduraklat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); //media playerı duraklat
        }
    }
}