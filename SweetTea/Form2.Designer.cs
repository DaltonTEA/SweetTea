
namespace SweetTea
{
	partial class SweetTea
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MarketCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartCB = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = global::SweetTea.Properties.Resources.TEA_Main_Logo_JPEG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(35, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Day Ahead Awards Report Manager";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MarketCB
            // 
            this.MarketCB.FormattingEnabled = true;
            this.MarketCB.Location = new System.Drawing.Point(101, 191);
            this.MarketCB.Name = "MarketCB";
            this.MarketCB.Size = new System.Drawing.Size(121, 23);
            this.MarketCB.TabIndex = 2;
            this.MarketCB.SelectedIndexChanged += new System.EventHandler(this.MarketCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "What Market would you like re-ran?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "What Participant?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartCB
            // 
            this.PartCB.FormattingEnabled = true;
            this.PartCB.Location = new System.Drawing.Point(101, 277);
            this.PartCB.Name = "PartCB";
            this.PartCB.Size = new System.Drawing.Size(121, 23);
            this.PartCB.TabIndex = 4;
            this.PartCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "What day?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SweetTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(331, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarketCB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SweetTea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SweetTea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox MarketCB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PartCB;
    }
}

