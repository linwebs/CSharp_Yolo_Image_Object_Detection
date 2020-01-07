using Alturos.Yolo;
using Alturos.Yolo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End1 {
	public partial class Form1:Form {
		private bool is_load_img, show_border;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			is_load_img = false;
			show_border = true;
			result_richTextBox.Text = "請開啟圖檔";
		}

		private void open_file_btn_Click(object sender, EventArgs e) {
			var open_file = new OpenFileDialog();
			open_file.Filter = "Image Files|*.jpg;*.png";
			if(open_file.ShowDialog() == DialogResult.OK) {
				detect_pictureBox.Image = Image.FromFile(open_file.FileName);
				result_richTextBox.Text = "檔案載入成功，\r\n已可進行辨識";
				is_load_img = true;
			} else {
				result_richTextBox.Text = "載入圖檔失敗，\r\n請重新選擇檔案";
				is_load_img = false;
			}
		}

		private void detect_btn_Click(object sender, EventArgs e) {
			result_richTextBox.Text = "辨識中，請稍後...";
			detect_animal();
		}

		private void detect_animal() {
			if(is_load_img) {
				try {
					var config_detector = new ConfigurationDetector();
					var config = config_detector.Detect();
					var yolo = new YoloWrapper(config);
					var memory_stream = new MemoryStream();
					detect_pictureBox.Image.Save(memory_stream, ImageFormat.Png);
					var items = yolo.Detect(memory_stream.ToArray()).ToList();
					result_richTextBox.Text = "辨識結果:";
					int succ = 0;
					bool[] showed = { false, false, false, false, false, false};
					foreach(var item in items) {
						result_richTextBox.Text += " ";
						/* 辨識結果說明:
						 * 此 Yolo 辨識系統可辨識以下 20 種物體
						 * aeroplane, bicycle, bird, boat, bottle, bus, car, cat, chair, cow, diningtable, dog, horse, motorbike, person, pottedplant, sheep, sofa, train, tvmonitor
						 */
						switch(item.Type) {
							case "bird":
								if(!showed[0]) {
									result_richTextBox.Text += "鳥" + "、";
									showed[0] = true;
								}
								succ++;
								break;
							case "cat":
								if(!showed[1]) {
									result_richTextBox.Text += "貓" + "、";
									showed[1] = true;
								}
								succ++;
								break;
							case "cow":
								if(!showed[2]) {
									result_richTextBox.Text += "牛" + "、";
									showed[2] = true;
								}
								succ++;
								break;
							case "dog":
								if(!showed[3]) {
									result_richTextBox.Text += "狗" + "、";
									showed[3] = true;
								}
								succ++;
								break;
							case "horse":
								if(!showed[4]) {
									result_richTextBox.Text += "馬" + "、";
									showed[4] = true;
								}
								succ++;
								break;
							case "sheep":
								if(!showed[5]) {
									result_richTextBox.Text += "羊" + "、";
									showed[5] = true;
								}
								succ++;
								break;
							default:
								//result_richTextBox1.Text += item.Type;
								Console.WriteLine("辨識結果: " + item.Type);
								break;
						}
					}
					if(succ > 0) {
						result_richTextBox.Text = result_richTextBox.Text.Substring(0, result_richTextBox.Text.Length - 1);
					}
					if(show_border) {
						add_detail_to_img(detect_pictureBox, items);
					}
					if(items.Count == 0) {
						result_richTextBox.Text += " 無結果";
					}
				} catch(Exception exception) {
					result_richTextBox.Text = "圖檔辨識失敗";
					Console.WriteLine("Detect Image Failed: " + exception);
				}
			} else {
				result_richTextBox.Text = "請先開啟圖檔，\r\n再進行辨識";
			}
		}

		private void add_detail_to_img(PictureBox pb, List<YoloItem> items) {
			var bitmap = pb.Image;
			var graphics = Graphics.FromImage(bitmap);
			foreach(var item in items) {
				var x = item.X;
				var y = item.Y;
				var width = item.Width;
				var height = item.Height;
				var rect = new Rectangle(x, y, width, height);
				var pen = new Pen(Color.Red, 6);
				graphics.DrawRectangle(pen, rect);
			}
			pb.Image = bitmap;
		}
	}
}
