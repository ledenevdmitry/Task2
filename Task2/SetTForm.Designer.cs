namespace Task2
{
    partial class SetTForm
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
            this.LbT = new System.Windows.Forms.Label();
            this.TbT = new System.Windows.Forms.TextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.TbZMin = new System.Windows.Forms.TextBox();
            this.LbZMin = new System.Windows.Forms.Label();
            this.TbZMax = new System.Windows.Forms.TextBox();
            this.LbZMax = new System.Windows.Forms.Label();
            this.TbZStep = new System.Windows.Forms.TextBox();
            this.LbZStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbT
            // 
            this.LbT.AutoSize = true;
            this.LbT.Location = new System.Drawing.Point(12, 9);
            this.LbT.Name = "LbT";
            this.LbT.Size = new System.Drawing.Size(62, 17);
            this.LbT.TabIndex = 0;
            this.LbT.Text = "Время, t";
            // 
            // TbT
            // 
            this.TbT.Location = new System.Drawing.Point(15, 29);
            this.TbT.Name = "TbT";
            this.TbT.Size = new System.Drawing.Size(257, 22);
            this.TbT.TabIndex = 1;
            this.TbT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
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
            // TbZMin
            // 
            this.TbZMin.Location = new System.Drawing.Point(15, 79);
            this.TbZMin.Name = "TbZMin";
            this.TbZMin.Size = new System.Drawing.Size(257, 22);
            this.TbZMin.TabIndex = 4;
            this.TbZMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMin
            // 
            this.LbZMin.AutoSize = true;
            this.LbZMin.Location = new System.Drawing.Point(12, 59);
            this.LbZMin.Name = "LbZMin";
            this.LbZMin.Size = new System.Drawing.Size(135, 17);
            this.LbZMin.TabIndex = 3;
            this.LbZMin.Text = "Координата, z(min)";
            // 
            // TbZMax
            // 
            this.TbZMax.Location = new System.Drawing.Point(15, 138);
            this.TbZMax.Name = "TbZMax";
            this.TbZMax.Size = new System.Drawing.Size(257, 22);
            this.TbZMax.TabIndex = 6;
            this.TbZMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZMax
            // 
            this.LbZMax.AutoSize = true;
            this.LbZMax.Location = new System.Drawing.Point(12, 118);
            this.LbZMax.Name = "LbZMax";
            this.LbZMax.Size = new System.Drawing.Size(138, 17);
            this.LbZMax.TabIndex = 5;
            this.LbZMax.Text = "Координата, z(max)";
            // 
            // TbZStep
            // 
            this.TbZStep.Location = new System.Drawing.Point(15, 200);
            this.TbZStep.Name = "TbZStep";
            this.TbZStep.Size = new System.Drawing.Size(257, 22);
            this.TbZStep.TabIndex = 8;
            this.TbZStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbZStep
            // 
            this.LbZStep.AutoSize = true;
            this.LbZStep.Location = new System.Drawing.Point(12, 180);
            this.LbZStep.Name = "LbZStep";
            this.LbZStep.Size = new System.Drawing.Size(137, 17);
            this.LbZStep.TabIndex = 7;
            this.LbZStep.Text = "Координата, z(шаг)";
            // 
            // SetTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.TbZStep);
            this.Controls.Add(this.LbZStep);
            this.Controls.Add(this.TbZMax);
            this.Controls.Add(this.LbZMax);
            this.Controls.Add(this.TbZMin);
            this.Controls.Add(this.LbZMin);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbT);
            this.Controls.Add(this.LbT);
            this.Name = "SetTForm";
            this.Text = "Ввод";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbT;
        private System.Windows.Forms.TextBox TbT;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.TextBox TbZMin;
        private System.Windows.Forms.Label LbZMin;
        private System.Windows.Forms.TextBox TbZMax;
        private System.Windows.Forms.Label LbZMax;
        private System.Windows.Forms.TextBox TbZStep;
        private System.Windows.Forms.Label LbZStep;
    }
}