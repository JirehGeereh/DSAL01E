namespace Lesson_2
{
    partial class Example_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.foodB_rdbtn = new System.Windows.Forms.RadioButton();
            this.foodA_rdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.display_picbox = new System.Windows.Forms.PictureBox();
            this.discount_txtbox = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A_LargeFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.A_SweetCornCheckBox = new System.Windows.Forms.CheckBox();
            this.A_SaltBreadCheckBox = new System.Windows.Forms.CheckBox();
            this.A_KFCSpecialRiceCheckBox = new System.Windows.Forms.CheckBox();
            this.A_FriedChickenCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_PlainRiceCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.B_IcedTeaCheckBox = new System.Windows.Forms.CheckBox();
            this.B_RegularFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.B_PeachMangoPieCheckBox = new System.Windows.Forms.CheckBox();
            this.B_JollyChickenCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_picbox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "4JEE Food Ordering Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodB_rdbtn
            // 
            this.foodB_rdbtn.AutoSize = true;
            this.foodB_rdbtn.Location = new System.Drawing.Point(36, 102);
            this.foodB_rdbtn.Name = "foodB_rdbtn";
            this.foodB_rdbtn.Size = new System.Drawing.Size(140, 24);
            this.foodB_rdbtn.TabIndex = 1;
            this.foodB_rdbtn.TabStop = true;
            this.foodB_rdbtn.Text = "Food Bundle B";
            this.foodB_rdbtn.UseVisualStyleBackColor = true;
            this.foodB_rdbtn.CheckedChanged += new System.EventHandler(this.foodB_rdbtn_CheckedChanged);
            // 
            // foodA_rdbtn
            // 
            this.foodA_rdbtn.AutoSize = true;
            this.foodA_rdbtn.Location = new System.Drawing.Point(36, 52);
            this.foodA_rdbtn.Name = "foodA_rdbtn";
            this.foodA_rdbtn.Size = new System.Drawing.Size(140, 24);
            this.foodA_rdbtn.TabIndex = 0;
            this.foodA_rdbtn.TabStop = true;
            this.foodA_rdbtn.Text = "Food Bundle A";
            this.foodA_rdbtn.UseVisualStyleBackColor = true;
            this.foodA_rdbtn.CheckedChanged += new System.EventHandler(this.foodA_rdbtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exit_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.display_picbox);
            this.groupBox2.Controls.Add(this.discount_txtbox);
            this.groupBox2.Controls.Add(this.price_txtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(39, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 607);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(255, 503);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(220, 80);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(26, 503);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(220, 80);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order Image:";
            // 
            // display_picbox
            // 
            this.display_picbox.Location = new System.Drawing.Point(140, 134);
            this.display_picbox.Name = "display_picbox";
            this.display_picbox.Size = new System.Drawing.Size(335, 344);
            this.display_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display_picbox.TabIndex = 4;
            this.display_picbox.TabStop = false;
            // 
            // discount_txtbox
            // 
            this.discount_txtbox.Location = new System.Drawing.Point(140, 85);
            this.discount_txtbox.Name = "discount_txtbox";
            this.discount_txtbox.Size = new System.Drawing.Size(335, 26);
            this.discount_txtbox.TabIndex = 3;
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(140, 47);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(335, 26);
            this.price_txtbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // A_LargeFriesCheckBox
            // 
            this.A_LargeFriesCheckBox.AutoSize = true;
            this.A_LargeFriesCheckBox.Location = new System.Drawing.Point(25, 256);
            this.A_LargeFriesCheckBox.Name = "A_LargeFriesCheckBox";
            this.A_LargeFriesCheckBox.Size = new System.Drawing.Size(128, 24);
            this.A_LargeFriesCheckBox.TabIndex = 3;
            this.A_LargeFriesCheckBox.Text = "1 Large Fries";
            this.A_LargeFriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.A_SweetCornCheckBox);
            this.groupBox3.Controls.Add(this.A_LargeFriesCheckBox);
            this.groupBox3.Controls.Add(this.A_SaltBreadCheckBox);
            this.groupBox3.Controls.Add(this.A_KFCSpecialRiceCheckBox);
            this.groupBox3.Controls.Add(this.A_FriedChickenCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(572, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 385);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food Bundles A";
            // 
            // A_SweetCornCheckBox
            // 
            this.A_SweetCornCheckBox.AutoSize = true;
            this.A_SweetCornCheckBox.Location = new System.Drawing.Point(25, 323);
            this.A_SweetCornCheckBox.Name = "A_SweetCornCheckBox";
            this.A_SweetCornCheckBox.Size = new System.Drawing.Size(118, 24);
            this.A_SweetCornCheckBox.TabIndex = 4;
            this.A_SweetCornCheckBox.Text = "Sweet Corn";
            this.A_SweetCornCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_SaltBreadCheckBox
            // 
            this.A_SaltBreadCheckBox.AutoSize = true;
            this.A_SaltBreadCheckBox.Location = new System.Drawing.Point(25, 189);
            this.A_SaltBreadCheckBox.Name = "A_SaltBreadCheckBox";
            this.A_SaltBreadCheckBox.Size = new System.Drawing.Size(152, 24);
            this.A_SaltBreadCheckBox.TabIndex = 2;
            this.A_SaltBreadCheckBox.Text = "2pcs. Salt Bread";
            this.A_SaltBreadCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_KFCSpecialRiceCheckBox
            // 
            this.A_KFCSpecialRiceCheckBox.AutoSize = true;
            this.A_KFCSpecialRiceCheckBox.Location = new System.Drawing.Point(25, 122);
            this.A_KFCSpecialRiceCheckBox.Name = "A_KFCSpecialRiceCheckBox";
            this.A_KFCSpecialRiceCheckBox.Size = new System.Drawing.Size(158, 24);
            this.A_KFCSpecialRiceCheckBox.TabIndex = 1;
            this.A_KFCSpecialRiceCheckBox.Text = "KFC Special Rice";
            this.A_KFCSpecialRiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_FriedChickenCheckBox
            // 
            this.A_FriedChickenCheckBox.AutoSize = true;
            this.A_FriedChickenCheckBox.Location = new System.Drawing.Point(25, 55);
            this.A_FriedChickenCheckBox.Name = "A_FriedChickenCheckBox";
            this.A_FriedChickenCheckBox.Size = new System.Drawing.Size(255, 24);
            this.A_FriedChickenCheckBox.TabIndex = 0;
            this.A_FriedChickenCheckBox.Text = "10 pcs. Delicious Fried Chicken";
            this.A_FriedChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodB_rdbtn);
            this.groupBox1.Controls.Add(this.foodA_rdbtn);
            this.groupBox1.Location = new System.Drawing.Point(39, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Order Choices";
            // 
            // B_PlainRiceCheckBox
            // 
            this.B_PlainRiceCheckBox.AutoSize = true;
            this.B_PlainRiceCheckBox.Location = new System.Drawing.Point(25, 122);
            this.B_PlainRiceCheckBox.Name = "B_PlainRiceCheckBox";
            this.B_PlainRiceCheckBox.Size = new System.Drawing.Size(151, 24);
            this.B_PlainRiceCheckBox.TabIndex = 1;
            this.B_PlainRiceCheckBox.Text = "4 pcs. Plain Rice";
            this.B_PlainRiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.B_IcedTeaCheckBox);
            this.groupBox5.Controls.Add(this.B_RegularFriesCheckBox);
            this.groupBox5.Controls.Add(this.B_PeachMangoPieCheckBox);
            this.groupBox5.Controls.Add(this.B_PlainRiceCheckBox);
            this.groupBox5.Controls.Add(this.B_JollyChickenCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(572, 518);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 385);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Food Bundles B";
            // 
            // B_IcedTeaCheckBox
            // 
            this.B_IcedTeaCheckBox.AutoSize = true;
            this.B_IcedTeaCheckBox.Location = new System.Drawing.Point(25, 323);
            this.B_IcedTeaCheckBox.Name = "B_IcedTeaCheckBox";
            this.B_IcedTeaCheckBox.Size = new System.Drawing.Size(143, 24);
            this.B_IcedTeaCheckBox.TabIndex = 4;
            this.B_IcedTeaCheckBox.Text = "4 pcs. Iced Tea";
            this.B_IcedTeaCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_RegularFriesCheckBox
            // 
            this.B_RegularFriesCheckBox.AutoSize = true;
            this.B_RegularFriesCheckBox.Location = new System.Drawing.Point(25, 256);
            this.B_RegularFriesCheckBox.Name = "B_RegularFriesCheckBox";
            this.B_RegularFriesCheckBox.Size = new System.Drawing.Size(176, 24);
            this.B_RegularFriesCheckBox.TabIndex = 3;
            this.B_RegularFriesCheckBox.Text = "4 pcs. Regular Fries";
            this.B_RegularFriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_PeachMangoPieCheckBox
            // 
            this.B_PeachMangoPieCheckBox.AutoSize = true;
            this.B_PeachMangoPieCheckBox.Location = new System.Drawing.Point(25, 189);
            this.B_PeachMangoPieCheckBox.Name = "B_PeachMangoPieCheckBox";
            this.B_PeachMangoPieCheckBox.Size = new System.Drawing.Size(205, 24);
            this.B_PeachMangoPieCheckBox.TabIndex = 2;
            this.B_PeachMangoPieCheckBox.Text = "4 pcs. Peach Mango Pie";
            this.B_PeachMangoPieCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_JollyChickenCheckBox
            // 
            this.B_JollyChickenCheckBox.AutoSize = true;
            this.B_JollyChickenCheckBox.Location = new System.Drawing.Point(25, 55);
            this.B_JollyChickenCheckBox.Name = "B_JollyChickenCheckBox";
            this.B_JollyChickenCheckBox.Size = new System.Drawing.Size(172, 24);
            this.B_JollyChickenCheckBox.TabIndex = 0;
            this.B_JollyChickenCheckBox.Text = "8 pcs. Jolly Chicken";
            this.B_JollyChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Example_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 941);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Example_4";
            this.Text = "Example_4";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_picbox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton foodB_rdbtn;
        private System.Windows.Forms.RadioButton foodA_rdbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox display_picbox;
        private System.Windows.Forms.TextBox discount_txtbox;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox A_LargeFriesCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox A_SweetCornCheckBox;
        private System.Windows.Forms.CheckBox A_SaltBreadCheckBox;
        private System.Windows.Forms.CheckBox A_KFCSpecialRiceCheckBox;
        private System.Windows.Forms.CheckBox A_FriedChickenCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox B_PlainRiceCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox B_IcedTeaCheckBox;
        private System.Windows.Forms.CheckBox B_RegularFriesCheckBox;
        private System.Windows.Forms.CheckBox B_PeachMangoPieCheckBox;
        private System.Windows.Forms.CheckBox B_JollyChickenCheckBox;
    }
}