using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AxWMPLib;
using WMPLib;
using System.IO;
namespace Editer_v3
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }
        #region
        // danh sách các biến
        string CMD;
        int tro = 0;
        int sovideo = 0;
        int sohan = 0;
        #endregion
        private void frMain_Load(object sender, EventArgs e)
        {
            grbox.BackColor = Color.Transparent;
            grbox2.BackColor = Color.Transparent;
            pcrun.BackColor = Color.Transparent;
           
        }

        private void frMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtnhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                show_list(listin, txtnhap.Text);
            }
            catch
            {

            }
        }

        // các hàm sử dụng
        #region
        // hiện thị các video trong link file và thời gian hiển thị
        public void show_list(ListView lv, String path)// chưa hoàn thành
        {
            try
            {
                lv.Items.Clear();
                string[] ds = Directory.GetFiles(path, "*.mp4*");
                foreach (string i in ds)
                {
                    ListViewItem item = new ListViewItem();
                    string i_ngan = i.Replace(path, "");
                    item.Text = i_ngan;
                    lv.Items.Add(item);
                    item.SubItems.Add(thoigian(i));
                }
            }
            catch
            {

            }
        }
        //xuất thời gian chạy video
        public String thoigian(String path)
        {
            string times = "";
            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(path);
            times = TimeSpan.FromSeconds(clip.duration).ToString();
            return times;
        }
        bool flagL = false;
        private void btnlock_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnhap.Text==""||txtxuat.Text=="")
                {
                    MessageBox.Show("Kiểm tra hoạt động của đường dẫn !");
                    return;
                }
                if (flagL == false)
                {
                    flagL = true;
                    btnlock.Text = "Unlock";
                    txtnhap.ReadOnly = true;
                    txtxuat.ReadOnly = true;
                }
                else
                {
                    show_list(listin, txtnhap.Text);
                    show_list(listout, txtxuat.Text);
                    btnlock.Text = "Lock";
                    flagL = false;
                    txtnhap.ReadOnly = false;
                    txtxuat.ReadOnly = false;
                }
            }
            catch
            {

            }
        }
        // tính toán thời gian cắt đến
        public int get_giay(string cdau,string catdich,string times)
        {
            int giay = 0;
            int scat = doigiay(catdich) + doigiay(cdau);
            int cuoi = doigiay(times);
            giay = cuoi - scat;
            return giay;
        }
        //
        //tính số giây theo giờ và phút
        public int doigiay(string mang)
        {
            int giay=0;
            String[] ds = mang.Split(':');//1:2:3
            int coso = 1;
            for (int i = ds.Length - 1; i >= 0;i-- )
            {
                giay += int.Parse(ds[i]) * coso;
                coso = coso * 60;
            }

            return giay;
        }
        public void Process_one(String cmdx)// chay từng process riêng rẻ
        {

        }
        public int demProcess()// đếm số process đang thuc thi
        {
            int dem=0;
            return dem;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tientrinh.Enabled = false;
            sovideo = 0;
            tro = 0;
            sohan = 0;
            if (so_cmd() > 0)
            {
                DialogResult a = MessageBox.Show("Bạn vừa huỷ chạy, còn " + so_cmd() + " process đang chạy bạn có muốn huỷ chúng?!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    stop_process();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Process.Start("cmd", "/k" + txtcmd.Text); 
                CMD = txtcmd.Text;
                sohan = int.Parse(txtso.Text);
                sovideo = listin.Items.Count;
                tientrinh.Enabled = true;
                lbvideotong.Text = "/" + sovideo.ToString();
                txtdachay.Text = "0";
            }
            catch
            {
                MessageBox.Show("Hãy chắc chắn là bạn đã chọn đường dẫn video??? ");
            }
        }
        //hàm kiểm tra số tiến trình cmd đang chạy
        int so_cmd()
        {
            Process[] pc;
            pc = Process.GetProcesses();
            int so = 0;
            foreach (Process p in pc)
            {
                if (p.ProcessName == "cmd")
                {
                    so++;
                }
            }
            return so;
        }
        //
        //hàm stop tiến trình
        public void stop_process()
        {
            Process[] pc;
            pc = Process.GetProcesses();
            foreach (Process p in pc)
            {
                if (p.ProcessName == "cmd" || p.ProcessName == "ffmpeg")
                {
                    p.Kill();
                }
            }
        }
        #endregion
        int chay = 0;
        private void tientrinh_Tick(object sender, EventArgs e)
        {
            if (chay % 9 == 0)
                pcrun.Image = global::Editer_v3.Properties.Resources.r3;
            else if (chay % 6 == 0) pcrun.Image = global::Editer_v3.Properties.Resources.r2;
            else                 
                if (chay % 3 == 0) pcrun.Image = global::Editer_v3.Properties.Resources.r1;

            chay++;
            if (tro < sovideo && so_cmd() < sohan)
            {
                render(tro);
                int so = int.Parse(txtdachay.Text);
                so++;
                txtdachay.Text = (so).ToString();
            }
            if (tro == sovideo) tientrinh.Enabled = false;

        }

         public void render(int vHientai)
        {
            Process runcmd = new Process();
            if(cban.Checked==true)
            runcmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            runcmd.StartInfo.FileName = "cmd";
            ListViewItem item = new ListViewItem();
            item = listin.Items[tro];
            string _input = txtnhap.Text + item.Text;
            string _output = txtxuat.Text + item.Text;
            //MessageBox.Show(_input);
            tro++;
            string chay = CMD;
           // CMD = "-y -i \"input_video\" -af \"atempo=1.2\" -vf \"setpts=PTS/1.2,crop=iw/1.5:ih/1.5,scale=1280:720,boxblur=2:1 [mv]; movie=filter.png [f1]; [mv][f1]overlay=0:0\" -preset ultrafast \"output_video\"";
            chay = chay.Replace("input_video", _input);
            chay = chay.Replace("output_video", _output);
            chay = chay.Replace("cdau",tdau.Text);
            string tong = item.SubItems[1].Text;
            int go = get_giay(tdau.Text,tcuoi.Text,tong);
          //  int den = get_giay(tdau,tcuoi,item.SubItems[1].ToString());
            chay = chay.Replace("cdich",go.ToString());
             chay=chay.Replace("speed",txtspeed.Text);
           //Process.Start("cmd", "/c" + "ffmpeg " +chay); 
            runcmd.StartInfo.Arguments = "/c" + "ffmpeg " + chay;
           // MessageBox.Show( "/c" + "ffmpeg "+chay);
            runcmd.Start();
        }
        public void seset_list(ListView lv,string path)
         {
             lv.Items.Clear();
             show_list(lv,path);
         }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            try
            {
            int vitri = listin.Items.IndexOf(listin.SelectedItems[0]);
            listin.Items.RemoveAt(vitri);
            }
            catch
            {

            }
        }

        private void btndelete2_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = listout.Items.IndexOf(listin.SelectedItems[0]);
                listin.Items.RemoveAt(vitri);
            }
            catch
            {

            }
        }
       
    }
}
