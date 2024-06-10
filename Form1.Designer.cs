namespace CSharp_bangcuuchuong
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.lbskq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn muốn hiển thị bảng cửu chương mấy?";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(115, 177);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(134, 27);
            this.txtso.TabIndex = 2;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(386, 177);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(100, 26);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "XEM";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // lbskq
            // 
            this.lbskq.FormattingEnabled = true;
            this.lbskq.ItemHeight = 19;
            this.lbskq.Location = new System.Drawing.Point(115, 316);
            this.lbskq.Name = "lbskq";
            this.lbskq.Size = new System.Drawing.Size(371, 194);
            this.lbskq.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(949, 607);
            this.Controls.Add(this.lbskq);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ListBox lbskq;
    }
}

