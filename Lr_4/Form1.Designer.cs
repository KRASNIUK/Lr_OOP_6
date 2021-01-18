namespace Lr_4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonShowParallelogram = new System.Windows.Forms.Button();
            this.buttonShowTrapezoid = new System.Windows.Forms.Button();
            this.buttonInformation1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(27, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 292);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonShowParallelogram
            // 
            this.buttonShowParallelogram.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowParallelogram.Location = new System.Drawing.Point(384, 112);
            this.buttonShowParallelogram.Name = "buttonShowParallelogram";
            this.buttonShowParallelogram.Size = new System.Drawing.Size(155, 55);
            this.buttonShowParallelogram.TabIndex = 1;
            this.buttonShowParallelogram.Text = "Parallelogra";
            this.buttonShowParallelogram.UseVisualStyleBackColor = true;
            this.buttonShowParallelogram.Click += new System.EventHandler(this.buttonShowParallelogram_Click);
            // 
            // buttonShowTrapezoid
            // 
            this.buttonShowTrapezoid.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTrapezoid.Location = new System.Drawing.Point(384, 188);
            this.buttonShowTrapezoid.Name = "buttonShowTrapezoid";
            this.buttonShowTrapezoid.Size = new System.Drawing.Size(155, 55);
            this.buttonShowTrapezoid.TabIndex = 2;
            this.buttonShowTrapezoid.Text = "Trapezoid";
            this.buttonShowTrapezoid.UseVisualStyleBackColor = true;
            this.buttonShowTrapezoid.Click += new System.EventHandler(this.buttonShowTrapezoid_Click);
            // 
            // buttonInformation1
            // 
            this.buttonInformation1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformation1.Location = new System.Drawing.Point(27, 359);
            this.buttonInformation1.Name = "buttonInformation1";
            this.buttonInformation1.Size = new System.Drawing.Size(512, 40);
            this.buttonInformation1.TabIndex = 3;
            this.buttonInformation1.Text = "Information";
            this.buttonInformation1.UseVisualStyleBackColor = true;
            this.buttonInformation1.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(565, 433);
            this.Controls.Add(this.buttonInformation1);
            this.Controls.Add(this.buttonShowTrapezoid);
            this.Controls.Add(this.buttonShowParallelogram);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowParallelogram;
        private System.Windows.Forms.Button buttonShowTrapezoid;
        private System.Windows.Forms.Button buttonInformation1;
    }
}

