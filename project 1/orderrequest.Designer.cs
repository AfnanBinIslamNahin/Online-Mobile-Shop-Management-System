namespace project_1
{
    partial class orderrequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderrequest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ram = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expandable_memory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.color_available = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.internal_storage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ram);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.expandable_memory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.color_available);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.internal_storage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.order_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 692);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ram
            // 
            this.ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram.FormattingEnabled = true;
            this.ram.Items.AddRange(new object[] {
            "1GB",
            "2GB",
            "3GB",
            "4GB",
            "5GB",
            "6GB",
            "7GB",
            "8GB",
            "12GB"});
            this.ram.Location = new System.Drawing.Point(83, 556);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(241, 34);
            this.ram.TabIndex = 39;
            this.ram.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(829, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 67);
            this.button2.TabIndex = 37;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(395, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 67);
            this.button1.TabIndex = 36;
            this.button1.Text = "Send Order Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(498, 403);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(243, 35);
            this.email.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Email";
            // 
            // expandable_memory
            // 
            this.expandable_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandable_memory.FormattingEnabled = true;
            this.expandable_memory.Items.AddRange(new object[] {
            "16GB",
            "32GB",
            "64GB",
            "128GB",
            "256GB",
            "500GB",
            "1TB"});
            this.expandable_memory.Location = new System.Drawing.Point(498, 308);
            this.expandable_memory.Name = "expandable_memory";
            this.expandable_memory.Size = new System.Drawing.Size(241, 34);
            this.expandable_memory.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Expandable Memory";
            // 
            // color_available
            // 
            this.color_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_available.FormattingEnabled = true;
            this.color_available.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green",
            "Blue",
            "Silver"});
            this.color_available.Location = new System.Drawing.Point(498, 181);
            this.color_available.Name = "color_available";
            this.color_available.Size = new System.Drawing.Size(241, 34);
            this.color_available.TabIndex = 31;
            this.color_available.SelectedIndexChanged += new System.EventHandler(this.color_available_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(480, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Color Available";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // internal_storage
            // 
            this.internal_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internal_storage.FormattingEnabled = true;
            this.internal_storage.Items.AddRange(new object[] {
            "16GB",
            "32GB",
            "64GB",
            "128GB",
            "256GB"});
            this.internal_storage.Location = new System.Drawing.Point(498, 97);
            this.internal_storage.Name = "internal_storage";
            this.internal_storage.Size = new System.Drawing.Size(241, 34);
            this.internal_storage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Internal Storage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ram";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(83, 452);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(243, 35);
            this.model.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(83, 345);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(243, 35);
            this.brand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // order_id
            // 
            this.order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(83, 241);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(243, 35);
            this.order_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "22****";
            // 
            // orderrequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 698);
            this.Controls.Add(this.panel1);
            this.Name = "orderrequest";
            this.Text = "orderrequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox internal_storage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox color_available;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox expandable_memory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ram;
        private System.Windows.Forms.Label label9;
    }
}