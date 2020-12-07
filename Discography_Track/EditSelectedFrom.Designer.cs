namespace Discography_Track
{
    partial class EditSelectedFrom
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
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_setvalue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(3, 23);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(203, 20);
            this.tb_title.TabIndex = 0;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(212, 23);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(203, 20);
            this.tb_time.TabIndex = 0;
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(421, 23);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(203, 20);
            this.tb_url.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "url";
            // 
            // btn_setvalue
            // 
            this.btn_setvalue.Location = new System.Drawing.Point(12, 49);
            this.btn_setvalue.Name = "btn_setvalue";
            this.btn_setvalue.Size = new System.Drawing.Size(605, 23);
            this.btn_setvalue.TabIndex = 2;
            this.btn_setvalue.Text = "Close";
            this.btn_setvalue.UseVisualStyleBackColor = true;
            this.btn_setvalue.Click += new System.EventHandler(this.btn_setvalue_Click);
            // 
            // EditSelectedFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 84);
            this.Controls.Add(this.btn_setvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSelectedFrom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_setvalue;
    }
}