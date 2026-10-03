using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppMergeSortPersonalAssigment
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
            label_infoSize = new Label();
            numericUpDown_SizeOfArray = new NumericUpDown();
            button_GenerateArray = new Button();
            textBox_ArrayAtFirst = new TextBox();
            label_infoArrayAtFirst = new Label();
            label_infoSortedArray = new Label();
            textBox_SortedArray = new TextBox();
            button_Sort = new Button();
            label_infoTime = new Label();
            textBox_Time = new TextBox();
            richTextBox_Steps = new RichTextBox();
            label_infoSteps = new Label();
            button_Clear = new Button();
            label_infoArrayFunc = new Label();
            textBox_ArrayFunc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SizeOfArray).BeginInit();
            SuspendLayout();
            // 
            // label_infoSize
            // 
            label_infoSize.AutoSize = true;
            label_infoSize.Location = new Point(25, 41);
            label_infoSize.Name = "label_infoSize";
            label_infoSize.Size = new Size(167, 20);
            label_infoSize.TabIndex = 0;
            label_infoSize.Text = "Введіть розмір масиву";
            // 
            // numericUpDown_SizeOfArray
            // 
            numericUpDown_SizeOfArray.Location = new Point(195, 38);
            numericUpDown_SizeOfArray.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown_SizeOfArray.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_SizeOfArray.Name = "numericUpDown_SizeOfArray";
            numericUpDown_SizeOfArray.Size = new Size(60, 27);
            numericUpDown_SizeOfArray.TabIndex = 1;
            numericUpDown_SizeOfArray.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // button_GenerateArray
            // 
            button_GenerateArray.BackColor = Color.LightCyan;
            button_GenerateArray.Location = new Point(286, 27);
            button_GenerateArray.Name = "button_GenerateArray";
            button_GenerateArray.Size = new Size(105, 49);
            button_GenerateArray.TabIndex = 2;
            button_GenerateArray.Text = "Згенерувати масив";
            button_GenerateArray.UseVisualStyleBackColor = false;
            // 
            // textBox_ArrayAtFirst
            // 
            textBox_ArrayAtFirst.BackColor = Color.Honeydew;
            textBox_ArrayAtFirst.Location = new Point(25, 149);
            textBox_ArrayAtFirst.Name = "textBox_ArrayAtFirst";
            textBox_ArrayAtFirst.Size = new Size(463, 27);
            textBox_ArrayAtFirst.TabIndex = 3;
            // 
            // label_infoArrayAtFirst
            // 
            label_infoArrayAtFirst.AutoSize = true;
            label_infoArrayAtFirst.Location = new Point(187, 126);
            label_infoArrayAtFirst.Name = "label_infoArrayAtFirst";
            label_infoArrayAtFirst.Size = new Size(140, 20);
            label_infoArrayAtFirst.TabIndex = 4;
            label_infoArrayAtFirst.Text = "Початковий масив";
            // 
            // label_infoSortedArray
            // 
            label_infoSortedArray.AutoSize = true;
            label_infoSortedArray.BackColor = Color.OldLace;
            label_infoSortedArray.Location = new Point(175, 343);
            label_infoSortedArray.Name = "label_infoSortedArray";
            label_infoSortedArray.Size = new Size(159, 20);
            label_infoSortedArray.TabIndex = 6;
            label_infoSortedArray.Text = "Посортований масив";
            // 
            // textBox_SortedArray
            // 
            textBox_SortedArray.BackColor = Color.FloralWhite;
            textBox_SortedArray.Location = new Point(25, 366);
            textBox_SortedArray.Name = "textBox_SortedArray";
            textBox_SortedArray.Size = new Size(463, 27);
            textBox_SortedArray.TabIndex = 5;
            // 
            // button_Sort
            // 
            button_Sort.BackColor = Color.LightGreen;
            button_Sort.Location = new Point(394, 260);
            button_Sort.Name = "button_Sort";
            button_Sort.Size = new Size(94, 35);
            button_Sort.TabIndex = 7;
            button_Sort.Text = "Сортувати";
            button_Sort.UseVisualStyleBackColor = false;
            // 
            // label_infoTime
            // 
            label_infoTime.AutoSize = true;
            label_infoTime.Location = new Point(27, 458);
            label_infoTime.Name = "label_infoTime";
            label_infoTime.Size = new Size(118, 20);
            label_infoTime.TabIndex = 8;
            label_infoTime.Text = "Час сортування";
            // 
            // textBox_Time
            // 
            textBox_Time.Location = new Point(147, 454);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(125, 27);
            textBox_Time.TabIndex = 9;
            // 
            // richTextBox_Steps
            // 
            richTextBox_Steps.Location = new Point(546, 61);
            richTextBox_Steps.Name = "richTextBox_Steps";
            richTextBox_Steps.Size = new Size(503, 465);
            richTextBox_Steps.TabIndex = 10;
            richTextBox_Steps.Text = "";
            // 
            // label_infoSteps
            // 
            label_infoSteps.AutoSize = true;
            label_infoSteps.Location = new Point(726, 38);
            label_infoSteps.Name = "label_infoSteps";
            label_infoSteps.Size = new Size(136, 20);
            label_infoSteps.TabIndex = 11;
            label_infoSteps.Text = "Кроки сортування";
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Salmon;
            button_Clear.Location = new Point(955, 539);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 35);
            button_Clear.TabIndex = 12;
            button_Clear.Text = "Очистити";
            button_Clear.UseVisualStyleBackColor = false;
            // 
            // label_infoArrayFunc
            // 
            label_infoArrayFunc.AutoSize = true;
            label_infoArrayFunc.Location = new Point(147, 204);
            label_infoArrayFunc.Name = "label_infoArrayFunc";
            label_infoArrayFunc.Size = new Size(227, 20);
            label_infoArrayFunc.TabIndex = 14;
            label_infoArrayFunc.Text = "Масив з застосуванням функції";
            label_infoArrayFunc.Click += this.label1_Click;
            // 
            // textBox_ArrayFunc
            // 
            textBox_ArrayFunc.BackColor = Color.Honeydew;
            textBox_ArrayFunc.Location = new Point(25, 227);
            textBox_ArrayFunc.Name = "textBox_ArrayFunc";
            textBox_ArrayFunc.Size = new Size(463, 27);
            textBox_ArrayFunc.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 586);
            Controls.Add(label_infoArrayFunc);
            Controls.Add(textBox_ArrayFunc);
            Controls.Add(button_Clear);
            Controls.Add(label_infoSteps);
            Controls.Add(richTextBox_Steps);
            Controls.Add(textBox_Time);
            Controls.Add(label_infoTime);
            Controls.Add(button_Sort);
            Controls.Add(label_infoSortedArray);
            Controls.Add(textBox_SortedArray);
            Controls.Add(label_infoArrayAtFirst);
            Controls.Add(textBox_ArrayAtFirst);
            Controls.Add(button_GenerateArray);
            Controls.Add(numericUpDown_SizeOfArray);
            Controls.Add(label_infoSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SizeOfArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_infoSize;
        private NumericUpDown numericUpDown_SizeOfArray;
        private Button button_GenerateArray;
        private TextBox textBox_ArrayAtFirst;
        private Label label_infoArrayAtFirst;
        private Label label_infoSortedArray;
        private TextBox textBox_SortedArray;
        private Button button_Sort;
        private Label label_infoTime;
        private TextBox textBox_Time;
        private RichTextBox richTextBox_Steps;
        private Label label_infoSteps;
        private Button button_Clear;
        private Label label_infoArrayFunc;
        private TextBox textBox_ArrayFunc;
    }
}
