﻿namespace Main
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxColumn1 = new System.Windows.Forms.TextBox();
            this.textBoxRows1 = new System.Windows.Forms.TextBox();
            this.label1Column = new System.Windows.Forms.Label();
            this.label1Rows = new System.Windows.Forms.Label();
            this.label2Rows = new System.Windows.Forms.Label();
            this.label2Column = new System.Windows.Forms.Label();
            this.textBoxRows2 = new System.Windows.Forms.TextBox();
            this.textBoxColumn2 = new System.Windows.Forms.TextBox();
            this.groupBoxMatrix1 = new System.Windows.Forms.GroupBox();
            this.checkBox1Random = new System.Windows.Forms.CheckBox();
            this.groupBoxMatrix2 = new System.Windows.Forms.GroupBox();
            this.checkBox2Random = new System.Windows.Forms.CheckBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.rbBackWard = new System.Windows.Forms.RadioButton();
            this.radioButtonDeterminant = new System.Windows.Forms.RadioButton();
            this.radioButtonTransportation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.buttonResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxMatrix1.SuspendLayout();
            this.groupBoxMatrix2.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(454, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(401, 329);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewResult.Location = new System.Drawing.Point(882, 198);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(401, 329);
            this.dataGridViewResult.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            // 
            // textBoxColumn1
            // 
            this.textBoxColumn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn1.Location = new System.Drawing.Point(115, 19);
            this.textBoxColumn1.MaxLength = 2;
            this.textBoxColumn1.Name = "textBoxColumn1";
            this.textBoxColumn1.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumn1.TabIndex = 3;
            // 
            // textBoxRows1
            // 
            this.textBoxRows1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRows1.Location = new System.Drawing.Point(115, 58);
            this.textBoxRows1.MaxLength = 2;
            this.textBoxRows1.Name = "textBoxRows1";
            this.textBoxRows1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows1.TabIndex = 4;
            // 
            // label1Column
            // 
            this.label1Column.AutoSize = true;
            this.label1Column.Location = new System.Drawing.Point(26, 22);
            this.label1Column.Name = "label1Column";
            this.label1Column.Size = new System.Drawing.Size(51, 13);
            this.label1Column.TabIndex = 5;
            this.label1Column.Text = "Столбцы";
            // 
            // label1Rows
            // 
            this.label1Rows.AutoSize = true;
            this.label1Rows.Location = new System.Drawing.Point(26, 61);
            this.label1Rows.Name = "label1Rows";
            this.label1Rows.Size = new System.Drawing.Size(43, 13);
            this.label1Rows.TabIndex = 6;
            this.label1Rows.Text = "Строки";
            // 
            // label2Rows
            // 
            this.label2Rows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2Rows.AutoSize = true;
            this.label2Rows.Location = new System.Drawing.Point(41, 65);
            this.label2Rows.Name = "label2Rows";
            this.label2Rows.Size = new System.Drawing.Size(43, 13);
            this.label2Rows.TabIndex = 11;
            this.label2Rows.Text = "Строки";
            // 
            // label2Column
            // 
            this.label2Column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2Column.AutoSize = true;
            this.label2Column.Location = new System.Drawing.Point(41, 26);
            this.label2Column.Name = "label2Column";
            this.label2Column.Size = new System.Drawing.Size(51, 13);
            this.label2Column.TabIndex = 10;
            this.label2Column.Text = "Столбцы";
            // 
            // textBoxRows2
            // 
            this.textBoxRows2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRows2.Location = new System.Drawing.Point(120, 61);
            this.textBoxRows2.MaxLength = 2;
            this.textBoxRows2.Name = "textBoxRows2";
            this.textBoxRows2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows2.TabIndex = 9;
            // 
            // textBoxColumn2
            // 
            this.textBoxColumn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn2.Location = new System.Drawing.Point(120, 23);
            this.textBoxColumn2.MaxLength = 2;
            this.textBoxColumn2.Name = "textBoxColumn2";
            this.textBoxColumn2.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumn2.TabIndex = 8;
            // 
            // groupBoxMatrix1
            // 
            this.groupBoxMatrix1.Controls.Add(this.checkBox1Random);
            this.groupBoxMatrix1.Controls.Add(this.label1Column);
            this.groupBoxMatrix1.Controls.Add(this.textBoxColumn1);
            this.groupBoxMatrix1.Controls.Add(this.textBoxRows1);
            this.groupBoxMatrix1.Controls.Add(this.label1Rows);
            this.groupBoxMatrix1.Location = new System.Drawing.Point(22, 14);
            this.groupBoxMatrix1.Name = "groupBoxMatrix1";
            this.groupBoxMatrix1.Size = new System.Drawing.Size(402, 156);
            this.groupBoxMatrix1.TabIndex = 13;
            this.groupBoxMatrix1.TabStop = false;
            this.groupBoxMatrix1.Text = "Матрица1";
            // 
            // checkBox1Random
            // 
            this.checkBox1Random.AutoSize = true;
            this.checkBox1Random.Location = new System.Drawing.Point(29, 96);
            this.checkBox1Random.Name = "checkBox1Random";
            this.checkBox1Random.Size = new System.Drawing.Size(142, 17);
            this.checkBox1Random.TabIndex = 8;
            this.checkBox1Random.Text = "Случайное заполнение";
            this.checkBox1Random.UseVisualStyleBackColor = true;
            // 
            // groupBoxMatrix2
            // 
            this.groupBoxMatrix2.Controls.Add(this.checkBox2Random);
            this.groupBoxMatrix2.Controls.Add(this.textBoxColumn2);
            this.groupBoxMatrix2.Controls.Add(this.textBoxRows2);
            this.groupBoxMatrix2.Controls.Add(this.label2Rows);
            this.groupBoxMatrix2.Controls.Add(this.label2Column);
            this.groupBoxMatrix2.Location = new System.Drawing.Point(454, 14);
            this.groupBoxMatrix2.Name = "groupBoxMatrix2";
            this.groupBoxMatrix2.Size = new System.Drawing.Size(401, 156);
            this.groupBoxMatrix2.TabIndex = 14;
            this.groupBoxMatrix2.TabStop = false;
            this.groupBoxMatrix2.Text = "Матрица2";
            // 
            // checkBox2Random
            // 
            this.checkBox2Random.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2Random.AutoSize = true;
            this.checkBox2Random.Location = new System.Drawing.Point(44, 96);
            this.checkBox2Random.Name = "checkBox2Random";
            this.checkBox2Random.Size = new System.Drawing.Size(142, 17);
            this.checkBox2Random.TabIndex = 9;
            this.checkBox2Random.Text = "Случайное заполнение";
            this.checkBox2Random.UseVisualStyleBackColor = true;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAction.Controls.Add(this.rbBackWard);
            this.groupBoxAction.Controls.Add(this.radioButtonDeterminant);
            this.groupBoxAction.Controls.Add(this.radioButtonTransportation);
            this.groupBoxAction.Controls.Add(this.radioButtonDivision);
            this.groupBoxAction.Controls.Add(this.radioButtonMultiply);
            this.groupBoxAction.Controls.Add(this.radioButtonSubtraction);
            this.groupBoxAction.Controls.Add(this.radioButtonAddition);
            this.groupBoxAction.Location = new System.Drawing.Point(882, 14);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(401, 156);
            this.groupBoxAction.TabIndex = 15;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Действие";
            // 
            // rbBackWard
            // 
            this.rbBackWard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBackWard.AutoSize = true;
            this.rbBackWard.Location = new System.Drawing.Point(15, 114);
            this.rbBackWard.Name = "rbBackWard";
            this.rbBackWard.Size = new System.Drawing.Size(120, 17);
            this.rbBackWard.TabIndex = 6;
            this.rbBackWard.TabStop = true;
            this.rbBackWard.Text = "Обратная матрица";
            this.rbBackWard.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeterminant
            // 
            this.radioButtonDeterminant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDeterminant.AutoSize = true;
            this.radioButtonDeterminant.Location = new System.Drawing.Point(263, 57);
            this.radioButtonDeterminant.Name = "radioButtonDeterminant";
            this.radioButtonDeterminant.Size = new System.Drawing.Size(98, 17);
            this.radioButtonDeterminant.TabIndex = 5;
            this.radioButtonDeterminant.TabStop = true;
            this.radioButtonDeterminant.Text = "Определитель";
            this.radioButtonDeterminant.UseVisualStyleBackColor = true;
            this.radioButtonDeterminant.CheckedChanged += new System.EventHandler(this.radioButtonDeterminant_CheckedChanged);
            // 
            // radioButtonTransportation
            // 
            this.radioButtonTransportation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTransportation.AutoSize = true;
            this.radioButtonTransportation.Location = new System.Drawing.Point(263, 86);
            this.radioButtonTransportation.Name = "radioButtonTransportation";
            this.radioButtonTransportation.Size = new System.Drawing.Size(127, 17);
            this.radioButtonTransportation.TabIndex = 4;
            this.radioButtonTransportation.TabStop = true;
            this.radioButtonTransportation.Text = "Транспортирование";
            this.radioButtonTransportation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(150, 86);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDivision.TabIndex = 3;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "Деление";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(15, 86);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(85, 17);
            this.radioButtonMultiply.TabIndex = 2;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "Умножение";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Location = new System.Drawing.Point(150, 57);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(80, 17);
            this.radioButtonSubtraction.TabIndex = 1;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "Вычитание";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(15, 57);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(76, 17);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Сложение";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResult.Location = new System.Drawing.Point(1118, 533);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(165, 36);
            this.buttonResult.TabIndex = 16;
            this.buttonResult.Text = "Решить";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 581);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxMatrix2);
            this.Controls.Add(this.groupBoxMatrix1);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1311, 620);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBoxMatrix1.ResumeLayout(false);
            this.groupBoxMatrix1.PerformLayout();
            this.groupBoxMatrix2.ResumeLayout(false);
            this.groupBoxMatrix2.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.TextBox textBoxColumn1;
        private System.Windows.Forms.TextBox textBoxRows1;
        private System.Windows.Forms.Label label1Column;
        private System.Windows.Forms.Label label1Rows;
        private System.Windows.Forms.Label label2Rows;
        private System.Windows.Forms.Label label2Column;
        private System.Windows.Forms.TextBox textBoxRows2;
        private System.Windows.Forms.TextBox textBoxColumn2;
        private System.Windows.Forms.GroupBox groupBoxMatrix1;
        private System.Windows.Forms.GroupBox groupBoxMatrix2;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.RadioButton radioButtonDeterminant;
        private System.Windows.Forms.RadioButton radioButtonTransportation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.CheckBox checkBox1Random;
        private System.Windows.Forms.CheckBox checkBox2Random;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.RadioButton rbBackWard;
    }
}

