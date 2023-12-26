namespace DataScience_ИК
{
    partial class SimplexMethodForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalculateBt = new System.Windows.Forms.Button();
            this.matrixRTb = new System.Windows.Forms.RichTextBox();
            this.iterationsTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limitationsTb = new System.Windows.Forms.TextBox();
            this.variablesTb = new System.Windows.Forms.TextBox();
            this.functionTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultRTb = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultRTb, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1836, 709);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CalculateBt);
            this.groupBox1.Controls.Add(this.matrixRTb);
            this.groupBox1.Controls.Add(this.iterationsTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.limitationsTb);
            this.groupBox1.Controls.Add(this.variablesTb);
            this.groupBox1.Controls.Add(this.functionTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Симплекс-метод";
            // 
            // CalculateBt
            // 
            this.CalculateBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBt.Location = new System.Drawing.Point(442, 507);
            this.CalculateBt.Name = "CalculateBt";
            this.CalculateBt.Size = new System.Drawing.Size(167, 58);
            this.CalculateBt.TabIndex = 10;
            this.CalculateBt.Text = "Рассчитать";
            this.CalculateBt.UseVisualStyleBackColor = true;
            this.CalculateBt.Click += new System.EventHandler(this.CalculateBt_Click);
            // 
            // matrixRTb
            // 
            this.matrixRTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixRTb.Location = new System.Drawing.Point(285, 248);
            this.matrixRTb.Name = "matrixRTb";
            this.matrixRTb.Size = new System.Drawing.Size(324, 242);
            this.matrixRTb.TabIndex = 9;
            this.matrixRTb.Text = "";
            // 
            // iterationsTb
            // 
            this.iterationsTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationsTb.Location = new System.Drawing.Point(285, 169);
            this.iterationsTb.Name = "iterationsTb";
            this.iterationsTb.Size = new System.Drawing.Size(324, 30);
            this.iterationsTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество итераций";
            // 
            // limitationsTb
            // 
            this.limitationsTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limitationsTb.Location = new System.Drawing.Point(285, 129);
            this.limitationsTb.Name = "limitationsTb";
            this.limitationsTb.Size = new System.Drawing.Size(324, 30);
            this.limitationsTb.TabIndex = 6;
            // 
            // variablesTb
            // 
            this.variablesTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.variablesTb.Location = new System.Drawing.Point(285, 89);
            this.variablesTb.Name = "variablesTb";
            this.variablesTb.Size = new System.Drawing.Size(324, 30);
            this.variablesTb.TabIndex = 5;
            // 
            // functionTb
            // 
            this.functionTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.functionTb.Location = new System.Drawing.Point(285, 49);
            this.functionTb.Name = "functionTb";
            this.functionTb.Size = new System.Drawing.Size(324, 30);
            this.functionTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Матрица коэффицентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество ограничений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество переменных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коэффиценты функции";
            // 
            // resultRTb
            // 
            this.resultRTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultRTb.Location = new System.Drawing.Point(645, 3);
            this.resultRTb.Name = "resultRTb";
            this.resultRTb.Size = new System.Drawing.Size(1188, 703);
            this.resultRTb.TabIndex = 1;
            this.resultRTb.Text = "";
            // 
            // SimplexMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimplexMethodForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox matrixRTb;
        private System.Windows.Forms.TextBox iterationsTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox limitationsTb;
        private System.Windows.Forms.TextBox variablesTb;
        private System.Windows.Forms.TextBox functionTb;
        private System.Windows.Forms.Button CalculateBt;
        private System.Windows.Forms.RichTextBox resultRTb;
    }
}