namespace TaHuuCong_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txt_cd.Text));
            hinhChuNhat.setCr(int.Parse(txt_cR.Text));

            MessageBox.Show("chiều dài:" + hinhChuNhat.getCd() + "\n chiều rộng" + hinhChuNhat.getCr());
        }
    }
}
