namespace project_1
{
    partial class purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.payment_method = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rear_camera = new System.Windows.Forms.Label();
            this.front_camera = new System.Windows.Forms.Label();
            this.sensor = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.expandable_memory = new System.Windows.Forms.Label();
            this.internal_storage = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payment_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.payment_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.payment_method);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.company);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.payment_date);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.payment_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1187, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // payment_method
            // 
            this.payment_method.FormattingEnabled = true;
            this.payment_method.Items.AddRange(new object[] {
            "Bkash",
            "Nagad"});
            this.payment_method.Location = new System.Drawing.Point(32, 547);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(276, 34);
            this.payment_method.TabIndex = 36;
            this.payment_method.SelectedIndexChanged += new System.EventHandler(this.payment_method_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(739, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "Purchase this item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rear_camera);
            this.panel2.Controls.Add(this.front_camera);
            this.panel2.Controls.Add(this.sensor);
            this.panel2.Controls.Add(this.ram);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.expandable_memory);
            this.panel2.Controls.Add(this.internal_storage);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Location = new System.Drawing.Point(888, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 349);
            this.panel2.TabIndex = 34;
            // 
            // rear_camera
            // 
            this.rear_camera.AutoSize = true;
            this.rear_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rear_camera.Location = new System.Drawing.Point(197, 165);
            this.rear_camera.Name = "rear_camera";
            this.rear_camera.Size = new System.Drawing.Size(88, 22);
            this.rear_camera.TabIndex = 47;
            this.rear_camera.Text = "-------------";
            // 
            // front_camera
            // 
            this.front_camera.AutoSize = true;
            this.front_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.front_camera.Location = new System.Drawing.Point(197, 201);
            this.front_camera.Name = "front_camera";
            this.front_camera.Size = new System.Drawing.Size(88, 22);
            this.front_camera.TabIndex = 46;
            this.front_camera.Text = "-------------";
            // 
            // sensor
            // 
            this.sensor.AutoSize = true;
            this.sensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor.Location = new System.Drawing.Point(197, 236);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(88, 22);
            this.sensor.TabIndex = 45;
            this.sensor.Text = "-------------";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram.Location = new System.Drawing.Point(84, 59);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(88, 22);
            this.ram.TabIndex = 44;
            this.ram.Text = "-------------";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(404, 234);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(88, 22);
            this.price.TabIndex = 43;
            this.price.Text = "-------------";
            // 
            // expandable_memory
            // 
            this.expandable_memory.AutoSize = true;
            this.expandable_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandable_memory.Location = new System.Drawing.Point(199, 130);
            this.expandable_memory.Name = "expandable_memory";
            this.expandable_memory.Size = new System.Drawing.Size(88, 22);
            this.expandable_memory.TabIndex = 42;
            this.expandable_memory.Text = "-------------";
            // 
            // internal_storage
            // 
            this.internal_storage.AutoSize = true;
            this.internal_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internal_storage.Location = new System.Drawing.Point(197, 101);
            this.internal_storage.Name = "internal_storage";
            this.internal_storage.Size = new System.Drawing.Size(88, 22);
            this.internal_storage.TabIndex = 41;
            this.internal_storage.Text = "-------------";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(309, 226);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 32);
            this.label30.TabIndex = 40;
            this.label30.Text = "Price";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(14, 236);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(158, 22);
            this.label31.TabIndex = 39;
            this.label31.Text = "Fingerprint Sensor";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(20, 201);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(120, 22);
            this.label32.TabIndex = 38;
            this.label32.Text = "Front Camera";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(20, 163);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 22);
            this.label33.TabIndex = 37;
            this.label33.Text = "Rear Camera";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(14, 130);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(173, 22);
            this.label34.TabIndex = 36;
            this.label34.Text = "Expandable Memory";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(14, 99);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(137, 22);
            this.label35.TabIndex = 35;
            this.label35.Text = "Internal Storage";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(20, 57);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 20);
            this.label36.TabIndex = 34;
            this.label36.Text = "Ram";
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(443, 68);
            this.label8.TabIndex = 18;
            this.label8.Text = "          Customer Purchase";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(687, 197);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(247, 34);
            this.model.TabIndex = 17;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // company
            // 
            this.company.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(687, 96);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(247, 34);
            this.company.TabIndex = 16;
            this.company.SelectedIndexChanged += new System.EventHandler(this.company_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Company";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(32, 662);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(276, 96);
            this.address.TabIndex = 11;
            this.address.Text = "";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 629);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Method";
            // 
            // payment_date
            // 
            this.payment_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_date.Location = new System.Drawing.Point(32, 426);
            this.payment_date.Name = "payment_date";
            this.payment_date.Size = new System.Drawing.Size(276, 33);
            this.payment_date.TabIndex = 6;
            this.payment_date.ValueChanged += new System.EventHandler(this.payment_date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Date";
            // 
            // payment_id
            // 
            this.payment_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_id.Location = new System.Drawing.Point(32, 209);
            this.payment_id.Name = "payment_id";
            this.payment_id.Size = new System.Drawing.Size(276, 33);
            this.payment_id.TabIndex = 3;
            this.payment_id.TextChanged += new System.EventHandler(this.payment_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment id";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(33, 328);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(276, 33);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Email";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "21****";
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 790);
            this.Controls.Add(this.panel1);
            this.Name = "purchase";
            this.Text = "purchase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox payment_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker payment_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rear_camera;
        private System.Windows.Forms.Label front_camera;
        private System.Windows.Forms.Label sensor;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label expandable_memory;
        private System.Windows.Forms.Label internal_storage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox payment_method;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}