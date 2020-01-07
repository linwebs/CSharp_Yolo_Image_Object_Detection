namespace End1 {
	partial class Form1 {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.detect_pictureBox = new System.Windows.Forms.PictureBox();
			this.open_file_btn = new System.Windows.Forms.Button();
			this.detect_btn = new System.Windows.Forms.Button();
			this.result_richTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.detect_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// detect_pictureBox
			// 
			this.detect_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.detect_pictureBox.Location = new System.Drawing.Point(280, 10);
			this.detect_pictureBox.Name = "detect_pictureBox";
			this.detect_pictureBox.Size = new System.Drawing.Size(640, 360);
			this.detect_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.detect_pictureBox.TabIndex = 0;
			this.detect_pictureBox.TabStop = false;
			// 
			// open_file_btn
			// 
			this.open_file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
			this.open_file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.open_file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.open_file_btn.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.open_file_btn.Location = new System.Drawing.Point(10, 10);
			this.open_file_btn.Name = "open_file_btn";
			this.open_file_btn.Size = new System.Drawing.Size(260, 60);
			this.open_file_btn.TabIndex = 1;
			this.open_file_btn.Text = "開啟檔案";
			this.open_file_btn.UseVisualStyleBackColor = false;
			this.open_file_btn.Click += new System.EventHandler(this.open_file_btn_Click);
			// 
			// detect_btn
			// 
			this.detect_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
			this.detect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.detect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.detect_btn.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.detect_btn.Location = new System.Drawing.Point(10, 80);
			this.detect_btn.Name = "detect_btn";
			this.detect_btn.Size = new System.Drawing.Size(260, 60);
			this.detect_btn.TabIndex = 2;
			this.detect_btn.Text = "辨識影像";
			this.detect_btn.UseVisualStyleBackColor = false;
			this.detect_btn.Click += new System.EventHandler(this.detect_btn_Click);
			// 
			// result_richTextBox
			// 
			this.result_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
			this.result_richTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.result_richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
			this.result_richTextBox.Location = new System.Drawing.Point(10, 150);
			this.result_richTextBox.Name = "result_richTextBox";
			this.result_richTextBox.ReadOnly = true;
			this.result_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.result_richTextBox.Size = new System.Drawing.Size(260, 220);
			this.result_richTextBox.TabIndex = 4;
			this.result_richTextBox.Text = "程式載入中...";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(934, 381);
			this.Controls.Add(this.result_richTextBox);
			this.Controls.Add(this.detect_btn);
			this.Controls.Add(this.open_file_btn);
			this.Controls.Add(this.detect_pictureBox);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "1072926 林哲緯 視窗程式設計期末考 動物辨識系統";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.detect_pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox detect_pictureBox;
		private System.Windows.Forms.Button open_file_btn;
		private System.Windows.Forms.Button detect_btn;
		private System.Windows.Forms.RichTextBox result_richTextBox;
	}
}

