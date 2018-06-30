using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_selection_figures
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog my_open_file_dialog = new OpenFileDialog();
            my_open_file_dialog.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif";
            if (my_open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(my_open_file_dialog.FileName);
            }
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) { MessageBox.Show("Error - Not Found Picture!", "Error!"); return; }
            Bitmap my_bitmap = new Bitmap(pictureBox1.Image);

            int h_l = 0, w_r = 0;        //最低, 最靠右
            int w_l = my_bitmap.Width;           //最靠左
            int h_h = my_bitmap.Height;         //最高
            Color pixel_color = my_bitmap.GetPixel(0, 0);

            for (int i = 0; i < my_bitmap.Width; i++)
            {
                for (int j = 0; j < my_bitmap.Height; j++)
                {
                    pixel_color = my_bitmap.GetPixel(i, j); //抓取當前像素rgb
                    if (pixel_color == Color.FromArgb(0, 0, 0) && j < h_h) { h_h = j; } //高
                    if (pixel_color == Color.FromArgb(0, 0, 0) && j > h_l) { h_l = j; }     //低
                    if (pixel_color == Color.FromArgb(0, 0, 0) && i < w_l) { w_l = i; }   //左
                    if (pixel_color == Color.FromArgb(0, 0, 0) && i > w_r) { w_r = i; }       //右
                }
            }
            //MessageBox.Show("最高 " + h_h.ToString() + "\r\n最低 " + h_l.ToString() + "\r\n最左 " + w_l.ToString() + "\r\n最右 " + w_r.ToString());
            pictureBox1.Image = myPaint(w_l, w_r, h_h, h_l);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            using (Pen pen = new Pen(Color.Red, 5))
            {
                e.Graphics.DrawRectangle(pen, 0, 200, 105, 516);
            }
            
            //左, 右, 高, 低
            /*if (w_l < 1 || w_r < 1 || h_h < 1 || h_l < 1) { MessageBox.Show("圖片內容貼近邊緣，無法框選！"); return; }

            
            e.Graphics.DrawLine(new Pen(Color.Red), (w_l - 1), (h_h - 1), (w_r + 1), (h_l + 1));*/
        }

        private Bitmap myPaint(int w_l, int w_r, int h_h, int h_l)//int w_l, int w_r, int h_h, int h_l
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Graphics myGraph = Graphics.FromImage(image);

            Rectangle rect = new Rectangle((w_l-1), (h_h-1), (w_r- w_l+2),  (h_l- h_h+2));
            Pen pen = new Pen(Color.Red);
            myGraph.DrawRectangle(pen, rect);
            return image;
            /*for (int i = h_h; i < h_l; i++)
            {
                my_bitmap.SetPixel(w_l-1, i-1, Color.FromArgb(255, 0, 0));
                my_bitmap.SetPixel(w_r-1, i-1, Color.FromArgb(255, 0, 0));
            }*/

        }
    }
}
