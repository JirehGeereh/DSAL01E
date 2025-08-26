namespace ACTIVITY4
{
    partial class Activity3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FoodARdbtn = new System.Windows.Forms.RadioButton();
            this.FoodBRdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxtbox = new System.Windows.Forms.TextBox();
            this.discounttxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.A_FriedChickenCheckBox = new System.Windows.Forms.CheckBox();
            this.A_KFCSpecialRiceCheckBox = new System.Windows.Forms.CheckBox();
            this.A_SaltBreadCheckBox = new System.Windows.Forms.CheckBox();
            this.A_LargeFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.A_SweetCornCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.B_IcedTeaCheckBox = new System.Windows.Forms.CheckBox();
            this.B_RegularFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.B_PeachMangoPieCheckBox = new System.Windows.Forms.CheckBox();
            this.B_PlainRiceCheckBox = new System.Windows.Forms.CheckBox();
            this.B_JollyChickenCheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "4JEE Food Ordering Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FoodBRdbtn);
            this.groupBox1.Controls.Add(this.FoodARdbtn);
            this.groupBox1.Location = new System.Drawing.Point(37, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Order Choices";
            // 
            // FoodARdbtn
            // 
            this.FoodARdbtn.AutoSize = true;
            this.FoodARdbtn.Location = new System.Drawing.Point(36, 52);
            this.FoodARdbtn.Name = "FoodARdbtn";
            this.FoodARdbtn.Size = new System.Drawing.Size(140, 24);
            this.FoodARdbtn.TabIndex = 0;
            this.FoodARdbtn.TabStop = true;
            this.FoodARdbtn.Text = "Food Bundle A";
            this.FoodARdbtn.UseVisualStyleBackColor = true;
            this.FoodARdbtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FoodBRdbtn
            // 
            this.FoodBRdbtn.AutoSize = true;
            this.FoodBRdbtn.Location = new System.Drawing.Point(36, 102);
            this.FoodBRdbtn.Name = "FoodBRdbtn";
            this.FoodBRdbtn.Size = new System.Drawing.Size(140, 24);
            this.FoodBRdbtn.TabIndex = 1;
            this.FoodBRdbtn.TabStop = true;
            this.FoodBRdbtn.Text = "Food Bundle B";
            this.FoodBRdbtn.UseVisualStyleBackColor = true;
            this.FoodBRdbtn.CheckedChanged += new System.EventHandler(this.FoodBRdbtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exitbtn);
            this.groupBox2.Controls.Add(this.clearbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DisplayPictureBox);
            this.groupBox2.Controls.Add(this.discounttxtbox);
            this.groupBox2.Controls.Add(this.pricetxtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 607);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // pricetxtbox
            // 
            this.pricetxtbox.Location = new System.Drawing.Point(140, 47);
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(335, 26);
            this.pricetxtbox.TabIndex = 2;
            // 
            // discounttxtbox
            // 
            this.discounttxtbox.Location = new System.Drawing.Point(140, 85);
            this.discounttxtbox.Name = "discounttxtbox";
            this.discounttxtbox.Size = new System.Drawing.Size(335, 26);
            this.discounttxtbox.TabIndex = 3;
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
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(26, 503);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(220, 80);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(255, 503);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(220, 80);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.A_SweetCornCheckBox);
            this.groupBox3.Controls.Add(this.A_LargeFriesCheckBox);
            this.groupBox3.Controls.Add(this.A_SaltBreadCheckBox);
            this.groupBox3.Controls.Add(this.A_KFCSpecialRiceCheckBox);
            this.groupBox3.Controls.Add(this.A_FriedChickenCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(570, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 385);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food Bundles A";
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
            this.A_FriedChickenCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.A_KFCSpecialRiceCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.B_IcedTeaCheckBox);
            this.groupBox5.Controls.Add(this.B_RegularFriesCheckBox);
            this.groupBox5.Controls.Add(this.B_PeachMangoPieCheckBox);
            this.groupBox5.Controls.Add(this.B_PlainRiceCheckBox);
            this.groupBox5.Controls.Add(this.B_JollyChickenCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(570, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 385);
            this.groupBox5.TabIndex = 5;
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
            // B_JollyChickenCheckBox
            // 
            this.B_JollyChickenCheckBox.AutoSize = true;
            this.B_JollyChickenCheckBox.Location = new System.Drawing.Point(25, 55);
            this.B_JollyChickenCheckBox.Name = "B_JollyChickenCheckBox";
            this.B_JollyChickenCheckBox.Size = new System.Drawing.Size(172, 24);
            this.B_JollyChickenCheckBox.TabIndex = 0;
            this.B_JollyChickenCheckBox.Text = "8 pcs. Jolly Chicken";
            this.B_JollyChickenCheckBox.UseVisualStyleBackColor = true;
            this.B_JollyChickenCheckBox.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // DisplayPictureBox
            // 
            this.DisplayPictureBox.Location = new System.Drawing.Point(140, 134);
            this.DisplayPictureBox.Name = "DisplayPictureBox";
            this.DisplayPictureBox.Size = new System.Drawing.Size(335, 344);
            this.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayPictureBox.TabIndex = 4;
            this.DisplayPictureBox.TabStop = false;
            // 
            // Activity3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 929);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Activity3";
            this.Text = "Example4";
            this.Load += new System.EventHandler(this.Activity3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FoodBRdbtn;
        private System.Windows.Forms.RadioButton FoodARdbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discounttxtbox;
        private System.Windows.Forms.TextBox pricetxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox A_FriedChickenCheckBox;
        private System.Windows.Forms.CheckBox A_SweetCornCheckBox;
        private System.Windows.Forms.CheckBox A_LargeFriesCheckBox;
        private System.Windows.Forms.CheckBox A_SaltBreadCheckBox;
        private System.Windows.Forms.CheckBox A_KFCSpecialRiceCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox B_IcedTeaCheckBox;
        private System.Windows.Forms.CheckBox B_RegularFriesCheckBox;
        private System.Windows.Forms.CheckBox B_PeachMangoPieCheckBox;
        private System.Windows.Forms.CheckBox B_PlainRiceCheckBox;
        private System.Windows.Forms.CheckBox B_JollyChickenCheckBox;
        private System.Windows.Forms.PictureBox DisplayPictureBox;
    }
}

