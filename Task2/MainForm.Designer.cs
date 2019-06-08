namespace Task2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.BtSaveByZ = new System.Windows.Forms.Button();
            this.BtSaveByT = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtCalculate = new System.Windows.Forms.Button();
            this.TbSteps = new System.Windows.Forms.TextBox();
            this.LbSteps = new System.Windows.Forms.Label();
            this.TbU0 = new System.Windows.Forms.TextBox();
            this.LbU0 = new System.Windows.Forms.Label();
            this.TbKappa = new System.Windows.Forms.TextBox();
            this.LbKappa = new System.Windows.Forms.Label();
            this.TbH = new System.Windows.Forms.TextBox();
            this.LbH = new System.Windows.Forms.Label();
            this.TbNu = new System.Windows.Forms.TextBox();
            this.LbNu = new System.Windows.Forms.Label();
            this.TbXi0 = new System.Windows.Forms.TextBox();
            this.LbXi0 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.Panel2.SuspendLayout();
            this.SCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SCMain
            // 
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SCMain.Location = new System.Drawing.Point(0, 0);
            this.SCMain.Margin = new System.Windows.Forms.Padding(4);
            this.SCMain.Name = "SCMain";
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.BtSaveByZ);
            this.SCMain.Panel1.Controls.Add(this.BtSaveByT);
            this.SCMain.Panel1.Controls.Add(this.BtClear);
            this.SCMain.Panel1.Controls.Add(this.BtStop);
            this.SCMain.Panel1.Controls.Add(this.BtCalculate);
            this.SCMain.Panel1.Controls.Add(this.TbSteps);
            this.SCMain.Panel1.Controls.Add(this.LbSteps);
            this.SCMain.Panel1.Controls.Add(this.TbU0);
            this.SCMain.Panel1.Controls.Add(this.LbU0);
            this.SCMain.Panel1.Controls.Add(this.TbKappa);
            this.SCMain.Panel1.Controls.Add(this.LbKappa);
            this.SCMain.Panel1.Controls.Add(this.TbH);
            this.SCMain.Panel1.Controls.Add(this.LbH);
            this.SCMain.Panel1.Controls.Add(this.TbNu);
            this.SCMain.Panel1.Controls.Add(this.LbNu);
            this.SCMain.Panel1.Controls.Add(this.TbXi0);
            this.SCMain.Panel1.Controls.Add(this.LbXi0);
            // 
            // SCMain.Panel2
            // 
            this.SCMain.Panel2.Controls.Add(this.mainChart);
            this.SCMain.Size = new System.Drawing.Size(1019, 582);
            this.SCMain.SplitterDistance = 320;
            this.SCMain.SplitterWidth = 5;
            this.SCMain.TabIndex = 0;
            // 
            // BtSaveByZ
            // 
            this.BtSaveByZ.Enabled = false;
            this.BtSaveByZ.Location = new System.Drawing.Point(19, 448);
            this.BtSaveByZ.Margin = new System.Windows.Forms.Padding(4);
            this.BtSaveByZ.Name = "BtSaveByZ";
            this.BtSaveByZ.Size = new System.Drawing.Size(289, 28);
            this.BtSaveByZ.TabIndex = 30;
            this.BtSaveByZ.Text = "Сохранить с зафиксированным z";
            this.BtSaveByZ.UseVisualStyleBackColor = true;
            this.BtSaveByZ.Click += new System.EventHandler(this.BtSaveByZ_Click);
            // 
            // BtSaveByT
            // 
            this.BtSaveByT.Enabled = false;
            this.BtSaveByT.Location = new System.Drawing.Point(19, 412);
            this.BtSaveByT.Margin = new System.Windows.Forms.Padding(4);
            this.BtSaveByT.Name = "BtSaveByT";
            this.BtSaveByT.Size = new System.Drawing.Size(289, 28);
            this.BtSaveByT.TabIndex = 29;
            this.BtSaveByT.Text = "Сохранить с зафиксированным t";
            this.BtSaveByT.UseVisualStyleBackColor = true;
            this.BtSaveByT.Click += new System.EventHandler(this.BtSaveByT_Click);
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(19, 376);
            this.BtClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(289, 28);
            this.BtClear.TabIndex = 28;
            this.BtClear.Text = "Очистить";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtStop
            // 
            this.BtStop.Enabled = false;
            this.BtStop.Location = new System.Drawing.Point(19, 340);
            this.BtStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(289, 28);
            this.BtStop.TabIndex = 27;
            this.BtStop.Text = "Остановить";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // BtCalculate
            // 
            this.BtCalculate.Location = new System.Drawing.Point(19, 304);
            this.BtCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.BtCalculate.Name = "BtCalculate";
            this.BtCalculate.Size = new System.Drawing.Size(289, 28);
            this.BtCalculate.TabIndex = 26;
            this.BtCalculate.Text = "Начать";
            this.BtCalculate.UseVisualStyleBackColor = true;
            this.BtCalculate.Click += new System.EventHandler(this.BtCalculate_Click);
            // 
            // TbSteps
            // 
            this.TbSteps.Location = new System.Drawing.Point(19, 274);
            this.TbSteps.Margin = new System.Windows.Forms.Padding(4);
            this.TbSteps.Name = "TbSteps";
            this.TbSteps.Size = new System.Drawing.Size(289, 22);
            this.TbSteps.TabIndex = 25;
            this.TbSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // LbSteps
            // 
            this.LbSteps.AutoSize = true;
            this.LbSteps.Location = new System.Drawing.Point(21, 253);
            this.LbSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSteps.Name = "LbSteps";
            this.LbSteps.Size = new System.Drawing.Size(32, 17);
            this.LbSteps.TabIndex = 24;
            this.LbSteps.Text = "Шаг";
            // 
            // TbU0
            // 
            this.TbU0.Location = new System.Drawing.Point(19, 227);
            this.TbU0.Margin = new System.Windows.Forms.Padding(4);
            this.TbU0.Name = "TbU0";
            this.TbU0.Size = new System.Drawing.Size(289, 22);
            this.TbU0.TabIndex = 23;
            // 
            // LbU0
            // 
            this.LbU0.AutoSize = true;
            this.LbU0.Location = new System.Drawing.Point(16, 206);
            this.LbU0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbU0.Name = "LbU0";
            this.LbU0.Size = new System.Drawing.Size(104, 17);
            this.LbU0.TabIndex = 22;
            this.LbU0.Text = "Функция, u₀(z)";
            // 
            // TbKappa
            // 
            this.TbKappa.Location = new System.Drawing.Point(19, 180);
            this.TbKappa.Margin = new System.Windows.Forms.Padding(4);
            this.TbKappa.Name = "TbKappa";
            this.TbKappa.Size = new System.Drawing.Size(289, 22);
            this.TbKappa.TabIndex = 21;
            this.TbKappa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbKappa
            // 
            this.LbKappa.AutoSize = true;
            this.LbKappa.Location = new System.Drawing.Point(16, 159);
            this.LbKappa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbKappa.Name = "LbKappa";
            this.LbKappa.Size = new System.Drawing.Size(165, 17);
            this.LbKappa.TabIndex = 20;
            this.LbKappa.Text = "Время запаздывания, ϰ";
            // 
            // TbH
            // 
            this.TbH.Location = new System.Drawing.Point(19, 133);
            this.TbH.Margin = new System.Windows.Forms.Padding(4);
            this.TbH.Name = "TbH";
            this.TbH.Size = new System.Drawing.Size(289, 22);
            this.TbH.TabIndex = 19;
            this.TbH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbH
            // 
            this.LbH.AutoSize = true;
            this.LbH.Location = new System.Drawing.Point(16, 112);
            this.LbH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbH.Name = "LbH";
            this.LbH.Size = new System.Drawing.Size(135, 17);
            this.LbH.TabIndex = 18;
            this.LbH.Text = "Толщина канала, h";
            // 
            // TbNu
            // 
            this.TbNu.Location = new System.Drawing.Point(19, 86);
            this.TbNu.Margin = new System.Windows.Forms.Padding(4);
            this.TbNu.Name = "TbNu";
            this.TbNu.Size = new System.Drawing.Size(289, 22);
            this.TbNu.TabIndex = 17;
            this.TbNu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbNu
            // 
            this.LbNu.AutoSize = true;
            this.LbNu.Location = new System.Drawing.Point(16, 65);
            this.LbNu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNu.Name = "LbNu";
            this.LbNu.Size = new System.Drawing.Size(292, 17);
            this.LbNu.TabIndex = 16;
            this.LbNu.Text = "Кинематический коэффициент вязкости, ν";
            // 
            // TbXi0
            // 
            this.TbXi0.Location = new System.Drawing.Point(19, 39);
            this.TbXi0.Margin = new System.Windows.Forms.Padding(4);
            this.TbXi0.Name = "TbXi0";
            this.TbXi0.Size = new System.Drawing.Size(289, 22);
            this.TbXi0.TabIndex = 15;
            this.TbXi0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Double_KeyPress);
            // 
            // LbXi0
            // 
            this.LbXi0.AutoSize = true;
            this.LbXi0.Location = new System.Drawing.Point(16, 18);
            this.LbXi0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbXi0.Name = "LbXi0";
            this.LbXi0.Size = new System.Drawing.Size(157, 17);
            this.LbXi0.TabIndex = 14;
            this.LbXi0.Text = "Градиент давления, ξ₀";
            // 
            // mainChart
            // 
            chartArea6.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea6);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.mainChart.Legends.Add(legend6);
            this.mainChart.Location = new System.Drawing.Point(0, 0);
            this.mainChart.Margin = new System.Windows.Forms.Padding(4);
            this.mainChart.Name = "mainChart";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Неньютоновская";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Ньютоновская";
            this.mainChart.Series.Add(series11);
            this.mainChart.Series.Add(series12);
            this.mainChart.Size = new System.Drawing.Size(694, 582);
            this.mainChart.TabIndex = 27;
            this.mainChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 582);
            this.Controls.Add(this.SCMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Решение задачи в случае нестационарного течения в канале вязкоупругой жидкости ти" +
    "па Фойгта";
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel1.PerformLayout();
            this.SCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.Button BtCalculate;
        private System.Windows.Forms.TextBox TbSteps;
        private System.Windows.Forms.Label LbSteps;
        private System.Windows.Forms.TextBox TbU0;
        private System.Windows.Forms.Label LbU0;
        private System.Windows.Forms.TextBox TbKappa;
        private System.Windows.Forms.Label LbKappa;
        private System.Windows.Forms.TextBox TbH;
        private System.Windows.Forms.Label LbH;
        private System.Windows.Forms.TextBox TbNu;
        private System.Windows.Forms.Label LbNu;
        private System.Windows.Forms.TextBox TbXi0;
        private System.Windows.Forms.Label LbXi0;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtSaveByZ;
        private System.Windows.Forms.Button BtSaveByT;
    }
}

