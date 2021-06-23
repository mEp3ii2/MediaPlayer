
namespace AT3_MediaPlayer_V1
{
    partial class Sort
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortParam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sortBtn.Location = new System.Drawing.Point(44, 82);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // sortParam
            // 
            this.sortParam.FormattingEnabled = true;
            this.sortParam.Location = new System.Drawing.Point(34, 55);
            this.sortParam.Name = "sortParam";
            this.sortParam.Size = new System.Drawing.Size(121, 21);
            this.sortParam.TabIndex = 1;
            this.sortParam.SelectedIndexChanged += new System.EventHandler(this.sortParam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort Parameters";
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortParam);
            this.Controls.Add(this.sortBtn);
            this.Name = "Sort";
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.Sort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortParam;
        private System.Windows.Forms.Label label1;
    }
}