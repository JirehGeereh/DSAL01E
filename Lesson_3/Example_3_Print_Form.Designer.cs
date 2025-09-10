namespace Lesson_3
{
    partial class Example_3_Print_Form
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GeerehFoods_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 344);
            this.listBox1.TabIndex = 0;
            // 
            // GeerehFoods_lbl
            // 
            this.GeerehFoods_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeerehFoods_lbl.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeerehFoods_lbl.Location = new System.Drawing.Point(0, 0);
            this.GeerehFoods_lbl.Name = "GeerehFoods_lbl";
            this.GeerehFoods_lbl.Size = new System.Drawing.Size(407, 89);
            this.GeerehFoods_lbl.TabIndex = 141;
            this.GeerehFoods_lbl.Text = "GEEREH FOOD ORDERING APPLICATION";
            this.GeerehFoods_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Example_3_Print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.GeerehFoods_lbl);
            this.Controls.Add(this.listBox1);
            this.Name = "Example_3_Print_Form";
            this.Text = "Example_3_Print_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label GeerehFoods_lbl;
    }
}