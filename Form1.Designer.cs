namespace TaHuuCong_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_nhap = new Button();
            label1 = new Label();
            txt_cd = new TextBox();
            label2 = new Label();
            txt_cR = new TextBox();
            SuspendLayout();
            // 
            // btn_nhap
            // 
            btn_nhap.Location = new Point(442, 93);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(75, 23);
            btn_nhap.TabIndex = 0;
            btn_nhap.Text = "Nhập";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 76);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Chiều Dài";
            // 
            // txt_cd
            // 
            txt_cd.Location = new Point(219, 73);
            txt_cd.Name = "txt_cd";
            txt_cd.Size = new Size(167, 23);
            txt_cd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Chiều Rộng";
            // 
            // txt_cR
            // 
            txt_cR.Location = new Point(219, 116);
            txt_cR.Name = "txt_cR";
            txt_cR.Size = new Size(167, 23);
            txt_cR.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_cR);
            Controls.Add(label2);
            Controls.Add(txt_cd);
            Controls.Add(label1);
            Controls.Add(btn_nhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_nhap;
        private Label label1;
        private TextBox txt_cd;
        private Label label2;
        private TextBox txt_cR;
    }
}
