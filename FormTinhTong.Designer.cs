namespace b1p1c4
{
    partial class FormTinhTong
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
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.Ibtong = new System.Windows.Forms.Button();
            this.Iblamlai = new System.Windows.Forms.Button();
            this.Ibthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ket qua:";
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(158, 46);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 29);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(158, 133);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 29);
            this.txtb.TabIndex = 4;
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
            // 
            // txtkq
            // 
            this.txtkq.Enabled = false;
            this.txtkq.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(158, 212);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 29);
            this.txtkq.TabIndex = 5;
            // 
            // Ibtong
            // 
            this.Ibtong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibtong.Location = new System.Drawing.Point(347, 48);
            this.Ibtong.Name = "Ibtong";
            this.Ibtong.Size = new System.Drawing.Size(100, 40);
            this.Ibtong.TabIndex = 6;
            this.Ibtong.Text = "Tinh tong";
            this.Ibtong.UseVisualStyleBackColor = true;
            this.Ibtong.Click += new System.EventHandler(this.Ibtong_Click);
            // 
            // Iblamlai
            // 
            this.Iblamlai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iblamlai.Location = new System.Drawing.Point(347, 131);
            this.Iblamlai.Name = "Iblamlai";
            this.Iblamlai.Size = new System.Drawing.Size(100, 40);
            this.Iblamlai.TabIndex = 7;
            this.Iblamlai.Text = "Lam lai";
            this.Iblamlai.UseVisualStyleBackColor = true;
            this.Iblamlai.Click += new System.EventHandler(this.Iblamlai_Click);
            // 
            // Ibthoat
            // 
            this.Ibthoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibthoat.Location = new System.Drawing.Point(347, 210);
            this.Ibthoat.Name = "Ibthoat";
            this.Ibthoat.Size = new System.Drawing.Size(100, 40);
            this.Ibthoat.TabIndex = 8;
            this.Ibthoat.Text = "Thoat";
            this.Ibthoat.UseVisualStyleBackColor = true;
            this.Ibthoat.Click += new System.EventHandler(this.Ibthoat_Click);
            // 
            // FormTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.Ibthoat);
            this.Controls.Add(this.Iblamlai);
            this.Controls.Add(this.Ibtong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTinhTong";
            this.Text = "FormTinhTong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button Ibtong;
        private System.Windows.Forms.Button Iblamlai;
        private System.Windows.Forms.Button Ibthoat;
    }
}