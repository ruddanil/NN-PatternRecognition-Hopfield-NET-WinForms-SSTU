namespace Hopfield
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.picSample1 = new System.Windows.Forms.PictureBox();
            this.picSample2 = new System.Windows.Forms.PictureBox();
            this.picSample3 = new System.Windows.Forms.PictureBox();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnSelect3 = new System.Windows.Forms.Button();
            this.btnRecognizeDrawn = new System.Windows.Forms.Button();
            this.picNoised = new System.Windows.Forms.PictureBox();
            this.picSample5 = new System.Windows.Forms.PictureBox();
            this.btnSelect5 = new System.Windows.Forms.Button();
            this.picSample4 = new System.Windows.Forms.PictureBox();
            this.btnSelect4 = new System.Windows.Forms.Button();
            this.btnRecognizeNoised = new System.Windows.Forms.Button();
            this.picRecognized = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEducate = new System.Windows.Forms.Button();
            this.trackBarNoise = new System.Windows.Forms.TrackBar();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenStandart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSample1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoised)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecognized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNoise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(104, 517);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 29);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // picSample1
            // 
            this.picSample1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSample1.Location = new System.Drawing.Point(12, 31);
            this.picSample1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSample1.Name = "picSample1";
            this.picSample1.Size = new System.Drawing.Size(183, 182);
            this.picSample1.TabIndex = 2;
            this.picSample1.TabStop = false;
            // 
            // picSample2
            // 
            this.picSample2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSample2.Location = new System.Drawing.Point(201, 31);
            this.picSample2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSample2.Name = "picSample2";
            this.picSample2.Size = new System.Drawing.Size(183, 182);
            this.picSample2.TabIndex = 3;
            this.picSample2.TabStop = false;
            // 
            // picSample3
            // 
            this.picSample3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSample3.Location = new System.Drawing.Point(390, 31);
            this.picSample3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSample3.Name = "picSample3";
            this.picSample3.Size = new System.Drawing.Size(183, 182);
            this.picSample3.TabIndex = 4;
            this.picSample3.TabStop = false;
            // 
            // btnSelect1
            // 
            this.btnSelect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect1.Location = new System.Drawing.Point(12, 221);
            this.btnSelect1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(183, 30);
            this.btnSelect1.TabIndex = 5;
            this.btnSelect1.Text = "Open";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.BtnSelect1_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect2.Location = new System.Drawing.Point(201, 221);
            this.btnSelect2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(183, 30);
            this.btnSelect2.TabIndex = 6;
            this.btnSelect2.Text = "Open";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.BtnSelect2_Click);
            // 
            // btnSelect3
            // 
            this.btnSelect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect3.Location = new System.Drawing.Point(390, 221);
            this.btnSelect3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect3.Name = "btnSelect3";
            this.btnSelect3.Size = new System.Drawing.Size(183, 30);
            this.btnSelect3.TabIndex = 7;
            this.btnSelect3.Text = "Open";
            this.btnSelect3.UseVisualStyleBackColor = true;
            this.btnSelect3.Click += new System.EventHandler(this.BtnSelect3_Click);
            // 
            // btnRecognizeDrawn
            // 
            this.btnRecognizeDrawn.Enabled = false;
            this.btnRecognizeDrawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecognizeDrawn.Location = new System.Drawing.Point(104, 554);
            this.btnRecognizeDrawn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecognizeDrawn.Name = "btnRecognizeDrawn";
            this.btnRecognizeDrawn.Size = new System.Drawing.Size(183, 29);
            this.btnRecognizeDrawn.TabIndex = 8;
            this.btnRecognizeDrawn.Text = "Recognize";
            this.btnRecognizeDrawn.UseVisualStyleBackColor = true;
            this.btnRecognizeDrawn.Click += new System.EventHandler(this.BtnRecognizeDrawn_Click);
            // 
            // picNoised
            // 
            this.picNoised.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNoised.Location = new System.Drawing.Point(676, 327);
            this.picNoised.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNoised.Name = "picNoised";
            this.picNoised.Size = new System.Drawing.Size(183, 182);
            this.picNoised.TabIndex = 10;
            this.picNoised.TabStop = false;
            // 
            // picSample5
            // 
            this.picSample5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSample5.Location = new System.Drawing.Point(768, 31);
            this.picSample5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSample5.Name = "picSample5";
            this.picSample5.Size = new System.Drawing.Size(183, 182);
            this.picSample5.TabIndex = 13;
            this.picSample5.TabStop = false;
            // 
            // btnSelect5
            // 
            this.btnSelect5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect5.Location = new System.Drawing.Point(768, 221);
            this.btnSelect5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect5.Name = "btnSelect5";
            this.btnSelect5.Size = new System.Drawing.Size(183, 30);
            this.btnSelect5.TabIndex = 14;
            this.btnSelect5.Text = "Open";
            this.btnSelect5.UseVisualStyleBackColor = true;
            this.btnSelect5.Click += new System.EventHandler(this.BtnSelect5_Click);
            // 
            // picSample4
            // 
            this.picSample4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSample4.Location = new System.Drawing.Point(579, 31);
            this.picSample4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSample4.Name = "picSample4";
            this.picSample4.Size = new System.Drawing.Size(183, 182);
            this.picSample4.TabIndex = 11;
            this.picSample4.TabStop = false;
            // 
            // btnSelect4
            // 
            this.btnSelect4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect4.Location = new System.Drawing.Point(579, 221);
            this.btnSelect4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect4.Name = "btnSelect4";
            this.btnSelect4.Size = new System.Drawing.Size(183, 30);
            this.btnSelect4.TabIndex = 12;
            this.btnSelect4.Text = "Open";
            this.btnSelect4.UseVisualStyleBackColor = true;
            this.btnSelect4.Click += new System.EventHandler(this.BtnSelect4_Click);
            // 
            // btnRecognizeNoised
            // 
            this.btnRecognizeNoised.Enabled = false;
            this.btnRecognizeNoised.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecognizeNoised.Location = new System.Drawing.Point(676, 554);
            this.btnRecognizeNoised.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecognizeNoised.Name = "btnRecognizeNoised";
            this.btnRecognizeNoised.Size = new System.Drawing.Size(183, 29);
            this.btnRecognizeNoised.TabIndex = 18;
            this.btnRecognizeNoised.Text = "Recognize";
            this.btnRecognizeNoised.UseVisualStyleBackColor = true;
            this.btnRecognizeNoised.Click += new System.EventHandler(this.BtnRecognizeNoised_Click);
            // 
            // picRecognized
            // 
            this.picRecognized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRecognized.Location = new System.Drawing.Point(390, 327);
            this.picRecognized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picRecognized.Name = "picRecognized";
            this.picRecognized.Size = new System.Drawing.Size(183, 182);
            this.picRecognized.TabIndex = 19;
            this.picRecognized.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Drawing area";
            // 
            // btnEducate
            // 
            this.btnEducate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEducate.Location = new System.Drawing.Point(483, 259);
            this.btnEducate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEducate.Name = "btnEducate";
            this.btnEducate.Size = new System.Drawing.Size(468, 29);
            this.btnEducate.TabIndex = 22;
            this.btnEducate.Text = "Train";
            this.btnEducate.UseVisualStyleBackColor = true;
            this.btnEducate.Click += new System.EventHandler(this.BtnEducate_Click);
            // 
            // trackBarNoise
            // 
            this.trackBarNoise.Location = new System.Drawing.Point(676, 517);
            this.trackBarNoise.Maximum = 100;
            this.trackBarNoise.Name = "trackBarNoise";
            this.trackBarNoise.Size = new System.Drawing.Size(183, 45);
            this.trackBarNoise.TabIndex = 27;
            this.trackBarNoise.TickFrequency = 10;
            this.trackBarNoise.Value = 3;
            this.trackBarNoise.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(89, 13);
            this.radio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(31, 17);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.Radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(279, 13);
            this.radio2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(31, 17);
            this.radio2.TabIndex = 1;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.Radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(468, 13);
            this.radio3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(31, 17);
            this.radio3.TabIndex = 2;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.Radio3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(848, 13);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "5";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(657, 13);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "4";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(406, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Recognized image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(721, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Noisy image";
            // 
            // btnOpenStandart
            // 
            this.btnOpenStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenStandart.Location = new System.Drawing.Point(12, 259);
            this.btnOpenStandart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenStandart.Name = "btnOpenStandart";
            this.btnOpenStandart.Size = new System.Drawing.Size(465, 29);
            this.btnOpenStandart.TabIndex = 32;
            this.btnOpenStandart.Text = "Open standard files";
            this.btnOpenStandart.UseVisualStyleBackColor = true;
            this.btnOpenStandart.Click += new System.EventHandler(this.BtnOpenStandart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 593);
            this.Controls.Add(this.btnOpenStandart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.picSample5);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.btnSelect5);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.picSample4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect4);
            this.Controls.Add(this.btnEducate);
            this.Controls.Add(this.picSample3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picSample1);
            this.Controls.Add(this.picNoised);
            this.Controls.Add(this.picSample2);
            this.Controls.Add(this.picRecognized);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.btnRecognizeNoised);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect3);
            this.Controls.Add(this.btnRecognizeDrawn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.trackBarNoise);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hopfield Neural Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picSample1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoised)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecognized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picSample1;
        private System.Windows.Forms.PictureBox picSample2;
        private System.Windows.Forms.PictureBox picSample3;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnSelect3;
        private System.Windows.Forms.Button btnRecognizeDrawn;
        private System.Windows.Forms.PictureBox picNoised;
        private System.Windows.Forms.Button btnRecognizeNoised;
        private System.Windows.Forms.PictureBox picRecognized;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picSample4;
        private System.Windows.Forms.Button btnSelect4;
        private System.Windows.Forms.Button btnEducate;
        private System.Windows.Forms.TrackBar trackBarNoise;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox picSample5;
        private System.Windows.Forms.Button btnSelect5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenStandart;
    }
}

