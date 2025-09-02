namespace Lesson_3
{
    partial class Example1
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
            this.sum_btn = new System.Windows.Forms.Button();
            this.firstinput_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondinput_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thirdinput_txtbox = new System.Windows.Forms.TextBox();
            this.fourthinput_txtbox = new System.Windows.Forms.TextBox();
            this.difference_btn = new System.Windows.Forms.Button();
            this.product_btn = new System.Windows.Forms.Button();
            this.quotient_btn = new System.Windows.Forms.Button();
            this.outputdisplay_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sum_btn
            // 
            this.sum_btn.Location = new System.Drawing.Point(28, 228);
            this.sum_btn.Name = "sum_btn";
            this.sum_btn.Size = new System.Drawing.Size(75, 42);
            this.sum_btn.TabIndex = 0;
            this.sum_btn.Text = "SUM";
            this.sum_btn.UseVisualStyleBackColor = true;
            this.sum_btn.Click += new System.EventHandler(this.sum_btn_Click);
            // 
            // firstinput_txtbox
            // 
            this.firstinput_txtbox.Location = new System.Drawing.Point(178, 30);
            this.firstinput_txtbox.Name = "firstinput_txtbox";
            this.firstinput_txtbox.Size = new System.Drawing.Size(198, 20);
            this.firstinput_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Input Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Input Data:";
            // 
            // secondinput_txtbox
            // 
            this.secondinput_txtbox.Location = new System.Drawing.Point(178, 60);
            this.secondinput_txtbox.Name = "secondinput_txtbox";
            this.secondinput_txtbox.Size = new System.Drawing.Size(198, 20);
            this.secondinput_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Third Input Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fourth Input Data:";
            // 
            // thirdinput_txtbox
            // 
            this.thirdinput_txtbox.Location = new System.Drawing.Point(178, 90);
            this.thirdinput_txtbox.Name = "thirdinput_txtbox";
            this.thirdinput_txtbox.Size = new System.Drawing.Size(198, 20);
            this.thirdinput_txtbox.TabIndex = 7;
            // 
            // fourthinput_txtbox
            // 
            this.fourthinput_txtbox.Location = new System.Drawing.Point(178, 120);
            this.fourthinput_txtbox.Name = "fourthinput_txtbox";
            this.fourthinput_txtbox.Size = new System.Drawing.Size(198, 20);
            this.fourthinput_txtbox.TabIndex = 8;
            // 
            // difference_btn
            // 
            this.difference_btn.Location = new System.Drawing.Point(109, 228);
            this.difference_btn.Name = "difference_btn";
            this.difference_btn.Size = new System.Drawing.Size(85, 42);
            this.difference_btn.TabIndex = 9;
            this.difference_btn.Text = "DIFFERENCE";
            this.difference_btn.UseVisualStyleBackColor = true;
            this.difference_btn.Click += new System.EventHandler(this.difference_btn_Click);
            // 
            // product_btn
            // 
            this.product_btn.Location = new System.Drawing.Point(200, 228);
            this.product_btn.Name = "product_btn";
            this.product_btn.Size = new System.Drawing.Size(85, 42);
            this.product_btn.TabIndex = 10;
            this.product_btn.Text = "PRODUCT";
            this.product_btn.UseVisualStyleBackColor = true;
            this.product_btn.Click += new System.EventHandler(this.product_btn_Click);
            // 
            // quotient_btn
            // 
            this.quotient_btn.Location = new System.Drawing.Point(291, 228);
            this.quotient_btn.Name = "quotient_btn";
            this.quotient_btn.Size = new System.Drawing.Size(85, 42);
            this.quotient_btn.TabIndex = 11;
            this.quotient_btn.Text = "QUOTIENT";
            this.quotient_btn.UseVisualStyleBackColor = true;
            this.quotient_btn.Click += new System.EventHandler(this.quotient_btn_Click);
            // 
            // outputdisplay_txtbox
            // 
            this.outputdisplay_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputdisplay_txtbox.Location = new System.Drawing.Point(178, 150);
            this.outputdisplay_txtbox.Multiline = true;
            this.outputdisplay_txtbox.Name = "outputdisplay_txtbox";
            this.outputdisplay_txtbox.Size = new System.Drawing.Size(198, 68);
            this.outputdisplay_txtbox.TabIndex = 13;
            this.outputdisplay_txtbox.TextChanged += new System.EventHandler(this.outputdisplay__txtbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output Display:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 298);
            this.Controls.Add(this.outputdisplay_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quotient_btn);
            this.Controls.Add(this.product_btn);
            this.Controls.Add(this.difference_btn);
            this.Controls.Add(this.fourthinput_txtbox);
            this.Controls.Add(this.thirdinput_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondinput_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstinput_txtbox);
            this.Controls.Add(this.sum_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sum_btn;
        private System.Windows.Forms.TextBox firstinput_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondinput_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thirdinput_txtbox;
        private System.Windows.Forms.TextBox fourthinput_txtbox;
        private System.Windows.Forms.Button difference_btn;
        private System.Windows.Forms.Button product_btn;
        private System.Windows.Forms.Button quotient_btn;
        private System.Windows.Forms.TextBox outputdisplay_txtbox;
        private System.Windows.Forms.Label label5;
    }
}

