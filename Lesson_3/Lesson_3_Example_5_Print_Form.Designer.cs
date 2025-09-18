namespace Lesson_3
{
    partial class Lesson_3_Example_5_Print_Form
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
            this.printdisplay_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // printdisplay_listbox
            // 
            this.printdisplay_listbox.FormattingEnabled = true;
            this.printdisplay_listbox.Location = new System.Drawing.Point(8, 8);
            this.printdisplay_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printdisplay_listbox.Name = "printdisplay_listbox";
            this.printdisplay_listbox.Size = new System.Drawing.Size(357, 446);
            this.printdisplay_listbox.TabIndex = 0;
            // 
            // Example_5_Print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 461);
            this.Controls.Add(this.printdisplay_listbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Example_5_Print_Form";
            this.Text = "Example_5_Print_Form";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox printdisplay_listbox;
    }
}