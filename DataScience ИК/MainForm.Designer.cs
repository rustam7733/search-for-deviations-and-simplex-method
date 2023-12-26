namespace DataScience_ИК
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SimplexBt = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.ScheduleBt = new System.Windows.Forms.Button();
            this.ClearBt = new System.Windows.Forms.Button();
            this.QuadraticDependenceBt = new System.Windows.Forms.Button();
            this.LinearDependenceBt = new System.Windows.Forms.Button();
            this.YTb = new System.Windows.Forms.TextBox();
            this.XTb = new System.Windows.Forms.TextBox();
            this.y_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1703, 866);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zedGraphControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.66864F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.33136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1697, 845);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.SimplexBt);
            this.groupBox2.Controls.Add(this.ResultLbl);
            this.groupBox2.Controls.Add(this.ScheduleBt);
            this.groupBox2.Controls.Add(this.ClearBt);
            this.groupBox2.Controls.Add(this.QuadraticDependenceBt);
            this.groupBox2.Controls.Add(this.LinearDependenceBt);
            this.groupBox2.Controls.Add(this.YTb);
            this.groupBox2.Controls.Add(this.XTb);
            this.groupBox2.Controls.Add(this.y_label);
            this.groupBox2.Controls.Add(this.x_label);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1691, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заполните поля соотвецтвуя их названию";
            // 
            // SimplexBt
            // 
            this.SimplexBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimplexBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SimplexBt.Location = new System.Drawing.Point(1108, 42);
            this.SimplexBt.Name = "SimplexBt";
            this.SimplexBt.Size = new System.Drawing.Size(151, 74);
            this.SimplexBt.TabIndex = 29;
            this.SimplexBt.Text = "Симплексный метод";
            this.SimplexBt.UseVisualStyleBackColor = true;
            this.SimplexBt.Click += new System.EventHandler(this.SimplexBt_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLbl.Location = new System.Drawing.Point(9, 153);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(83, 25);
            this.ResultLbl.TabIndex = 28;
            this.ResultLbl.Text = "Ответ: ";
            // 
            // ScheduleBt
            // 
            this.ScheduleBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScheduleBt.Location = new System.Drawing.Point(794, 42);
            this.ScheduleBt.Name = "ScheduleBt";
            this.ScheduleBt.Size = new System.Drawing.Size(151, 74);
            this.ScheduleBt.TabIndex = 27;
            this.ScheduleBt.Text = "Вывести график";
            this.ScheduleBt.UseVisualStyleBackColor = true;
            this.ScheduleBt.Click += new System.EventHandler(this.ScheduleBt_Click_1);
            // 
            // ClearBt
            // 
            this.ClearBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearBt.Location = new System.Drawing.Point(951, 42);
            this.ClearBt.Name = "ClearBt";
            this.ClearBt.Size = new System.Drawing.Size(151, 74);
            this.ClearBt.TabIndex = 26;
            this.ClearBt.Text = "Очистить поля";
            this.ClearBt.UseVisualStyleBackColor = true;
            this.ClearBt.Click += new System.EventHandler(this.ClearBt_Click);
            // 
            // QuadraticDependenceBt
            // 
            this.QuadraticDependenceBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadraticDependenceBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuadraticDependenceBt.Location = new System.Drawing.Point(637, 42);
            this.QuadraticDependenceBt.Name = "QuadraticDependenceBt";
            this.QuadraticDependenceBt.Size = new System.Drawing.Size(151, 74);
            this.QuadraticDependenceBt.TabIndex = 25;
            this.QuadraticDependenceBt.Text = "Квадратичная зависимость";
            this.QuadraticDependenceBt.UseVisualStyleBackColor = true;
            this.QuadraticDependenceBt.Click += new System.EventHandler(this.QuadraticDependenceBt_Click_1);
            // 
            // LinearDependenceBt
            // 
            this.LinearDependenceBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinearDependenceBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LinearDependenceBt.Location = new System.Drawing.Point(480, 42);
            this.LinearDependenceBt.Name = "LinearDependenceBt";
            this.LinearDependenceBt.Size = new System.Drawing.Size(151, 74);
            this.LinearDependenceBt.TabIndex = 24;
            this.LinearDependenceBt.Text = "Линейная зависимость";
            this.LinearDependenceBt.UseVisualStyleBackColor = true;
            this.LinearDependenceBt.Click += new System.EventHandler(this.LinearDependenceBt_Click_1);
            // 
            // YTb
            // 
            this.YTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTb.Location = new System.Drawing.Point(38, 88);
            this.YTb.Name = "YTb";
            this.YTb.Size = new System.Drawing.Size(380, 28);
            this.YTb.TabIndex = 23;
            // 
            // XTb
            // 
            this.XTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XTb.Location = new System.Drawing.Point(38, 42);
            this.XTb.Name = "XTb";
            this.XTb.Size = new System.Drawing.Size(380, 28);
            this.XTb.TabIndex = 22;
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_label.Location = new System.Drawing.Point(10, 94);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(22, 22);
            this.y_label.TabIndex = 21;
            this.y_label.Text = "Y";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_label.Location = new System.Drawing.Point(10, 48);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(22, 22);
            this.x_label.TabIndex = 20;
            this.x_label.Text = "X";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(4, 204);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1689, 637);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите через пробел значения, соотвецтвующие названию полей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1703, 866);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Data science ИК (Субханов Рустам АТТ-2103Р)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button ScheduleBt;
        private System.Windows.Forms.Button ClearBt;
        private System.Windows.Forms.Button QuadraticDependenceBt;
        private System.Windows.Forms.Button LinearDependenceBt;
        private System.Windows.Forms.TextBox YTb;
        private System.Windows.Forms.TextBox XTb;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label x_label;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button SimplexBt;
    }
}

