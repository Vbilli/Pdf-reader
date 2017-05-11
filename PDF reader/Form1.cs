using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PDF_reader
{
	public partial class Form1 : Form
	{

		string PicPath = @"D:\picture\";
		bool bDrawStart = false;
		Point pointStart = Point.Empty;
		Point pointContinue = Point.Empty;
		Dictionary<Point, Point> dicPoints = new Dictionary<Point, Point>();
		public Form1()
		{
			InitializeComponent();
			GetMaxLabelNum();
			pictureBox2.Image = Properties.Resources.close;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
			List<string> imageLists = new List<string>();
			string ImageLocation = "";
			imageList1.Images.Clear();
			listView1.Items.Clear();
			imageLists.Clear();

			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "PDFfiles|*.pdf";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				axAcroPDF1.LoadFile(ofd.FileName);
				PDFAnlyer.ConvertPDF2Image(ofd.FileName, PicPath, "captrue", 1, 500, ImageFormat.Jpeg, PDFAnlyer.Definition.Two);
				for (int i = 1; i < PDFAnlyer.PageCount; i++)
				{
					PictureBox pb = new PictureBox();
					//pb.Load(Application.StartupPath + "capture" + i + "." + ImageFormat.Jpeg);
					//Image imagefile = Image.FromFile(Application.StartupPath + "capture" + i + "." + ImageFormat.Jpeg);
					//pb.Image = imagefile;
					ImageLocation = PicPath + "captrue" + i + "." + ImageFormat.Jpeg;
					pb.SizeMode = PictureBoxSizeMode.AutoSize;
					imageLists.Add(ImageLocation);
				}

			}
			for (int i = 0; i < imageLists.Count; i++)
			{

				imageList1.Images.Add(System.Drawing.Image.FromFile(imageLists[i].ToString()));
				imageList1.ImageSize = new Size(100, 100);
				listView1.LargeImageList = imageList1;
				listView1.Items.Add(System.IO.Path.GetFileName(imageLists[i].ToString()), i);
				listView1.Items[i].ImageIndex = i;
				listView1.Items[i].Name = imageLists[i].ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//_SCREEN_CAPTURE.FrmCapture capture = new _SCREEN_CAPTURE.FrmCapture();
			//capture.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "JPeg Image|*.jpg";
			saveFileDialog1.FilterIndex = 0;
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("没有预览图片");
			}
			else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (pictureBox1.Image != null)
				{
					Bitmap map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
					pictureBox1.DrawToBitmap(map, new Rectangle(0, 0, map.Width, map.Height));
					map.Save(saveFileDialog1.FileName);
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				pictureBox1.Image = Image.FromFile(listView1.SelectedItems[0].Name);
			}
		}

		private void listView1_MouseHover(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				int listX = listView1.Location.X + listView1.SelectedItems[0].Position.X;
				int listY = listView1.Location.Y + listView1.SelectedItems[0].Position.Y;
				pictureBox2.Location = new Point(listX, listY);
				//listView1.SelectedItems[0].Position.X
			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
			//ScreenSaver ss = new ScreenSaver();
			//ss.Show();
			TouchAreaContent area = new TouchAreaContent(GetMaxLabelNum());
			this.flowLayoutPanel1.Controls.Add(area.newlabel);
			this.flowLayoutPanel1.Controls.Add(area.firstButton);
			this.flowLayoutPanel1.Controls.Add(area.secondButton);
		}


		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (bDrawStart)
			{
				bDrawStart = false;
			}
			else
			{
				bDrawStart = true;

				pointStart = e.Location;
			}
		}



		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (bDrawStart)
			{
				pointContinue = e.Location;
				Refresh();
			}
		}



		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (bDrawStart)
			{
				dicPoints.Add(pointStart, pointContinue);
			}
			bDrawStart = false;
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)

		{
			System.Drawing.Pen pen = new System.Drawing.Pen(Color.LimeGreen);
			pen.Width = 2;
			if (bDrawStart)
			{
				//实时的画矩形
				Graphics g = e.Graphics;
				g.DrawRectangle(pen, pointStart.X, pointStart.Y, pointContinue.X - pointStart.X, pointContinue.Y - pointStart.Y);
			}
			//实时的画之前已经画好的矩形
			foreach (var item in dicPoints)
			{
				Point p1 = item.Key;
				Point p2 = item.Value;
				e.Graphics.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
			}
			pen.Dispose();
		}

		public int GetMaxLabelNum()
		{
			int count = 0;
			foreach (Control c in this.flowLayoutPanel1.Controls)
			{
				if (c.GetType().ToString() == "System.Windows.Forms.Label")
				{
					count++;
				}
			}
			//MessageBox.Show(count.ToString());
			return count;
		}

		public void GenarateControls()
		{
			int count = GetMaxLabelNum();


		}

		public static int RemoveNotNumber(string key)
		{
			return Convert.ToInt32(Regex.Replace(key, @"[^/d]*", ""));
		}
	}
}
