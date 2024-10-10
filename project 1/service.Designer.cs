namespace project_1
{
    partial class service
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(service));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.service_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.photo);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.issue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.service_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1334, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 69);
            this.button4.TabIndex = 25;
            this.button4.Text = "Reply From Service Center";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1152, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 49);
            this.button3.TabIndex = 24;
            this.button3.Text = "reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(945, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1065, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Upload Picture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photo.Location = new System.Drawing.Point(1086, 32);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(242, 273);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 21;
            this.photo.TabStop = false;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(982, 407);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(243, 35);
            this.email.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(939, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email";
            // 
            // issue
            // 
            this.issue.Location = new System.Drawing.Point(77, 503);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(312, 94);
            this.issue.TabIndex = 18;
            this.issue.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Issue";
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(92, 403);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(243, 35);
            this.model.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Model";
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(92, 301);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(243, 35);
            this.brand.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Brand";
            // 
            // service_id
            // 
            this.service_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_id.Location = new System.Drawing.Point(92, 197);
            this.service_id.Name = "service_id";
            this.service_id.Size = new System.Drawing.Size(243, 35);
            this.service_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Service ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile Service";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "18****";
            // 
            // service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 720);
            this.Controls.Add(this.panel1);
            this.Name = "service";
            this.Text = "service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox service_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox issue;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
    }
}