namespace Task2
{
    partial class SetZForm
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
            this.LbZ = new System.Windows.Forms.Label();
            this.TbZ = new System.Windows.Forms.TextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.TbTMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTStep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbZ
            // 
            this.LbZ.AutoSize = true;
            this.LbZ.Location = new System.Drawing.Point(12, 9);
            this.LbZ.Name = "LbZ";
            this.LbZ.Size = new System.Drawing.Size(103, 17);
            this.LbZ.TabIndex = 0;
            this.LbZ.Text = "Координата, z";
            // 
            // TbZ
            // 
            this.TbZ.Location = new System.Drawing.Point(15, 29);
            this.TbZ.Name = "TbZ";
            this.TbZ.Size = new System.Drawing.Size(257, 22);
            this.TbZ.TabIndex = 1;
            this.TbZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(12, 249);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(260, 36);
            this.BtSubmit.TabIndex = 2;
            this.BtSubmit.Text = "OK";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // TbTMin
            // 
            this.TbTMin.Location = new System.Drawing.Point(15, 79);
            this.TbTMin.Name = "TbTMin";
            this.TbTMin.Size = new System.Drawing.Size(257, 22);
            this.TbTMin.TabIndex = 4;
            this.TbTMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время, t(min)";
            // 
            // TbTMax
            // 
            this.TbTMax.Location = new System.Drawing.Point(15, 138);
            this.TbTMax.Name = "TbTMax";
            this.TbTMax.Size = new System.Drawing.Size(257, 22);
            this.TbTMax.TabIndex = 6;
            this.TbTMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время, t(max)";
            // 
            // TbTStep
            // 
            this.TbTStep.Location = new System.Drawing.Point(15, 200);
            this.TbTStep.Name = "TbTStep";
            this.TbTStep.Size = new System.Drawing.Size(257, 22);
            this.TbTStep.TabIndex = 8;
            this.TbTStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время, t(шаг)";
            // 
            // SetZForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.TbTStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbTMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbTMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbZ);
            this.Controls.Add(this.LbZ);
            this.Name = "SetZForm";
            this.Text = "Ввод";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbZ;
        private System.Windows.Forms.TextBox TbZ;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.TextBox TbTMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTStep;
        private System.Windows.Forms.Label label3;
    }
}