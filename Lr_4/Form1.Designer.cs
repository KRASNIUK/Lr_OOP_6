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
            this.buttonNextFigure = new System.Windows.Forms.Button();
            this.buttonInformation1 = new System.Windows.Forms.Button();
            this.buttonRunCode = new System.Windows.Forms.Button();
            this.buttonAddCode = new System.Windows.Forms.Button();
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
            // buttonNextFigure
            // 
            this.buttonNextFigure.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextFigure.Location = new System.Drawing.Point(384, 47);
            this.buttonNextFigure.Name = "buttonNextFigure";
            this.buttonNextFigure.Size = new System.Drawing.Size(155, 292);
            this.buttonNextFigure.TabIndex = 2;
            this.buttonNextFigure.Text = "Next figure";
            this.buttonNextFigure.UseVisualStyleBackColor = true;
            this.buttonNextFigure.Click += new System.EventHandler(this.buttonNextFigure_Click);
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
            // buttonRunCode
            // 
            this.buttonRunCode.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunCode.Location = new System.Drawing.Point(556, 105);
            this.buttonRunCode.Name = "buttonRunCode";
            this.buttonRunCode.Size = new System.Drawing.Size(104, 177);
            this.buttonRunCode.TabIndex = 4;
            this.buttonRunCode.Text = "Run something code";
            this.buttonRunCode.UseVisualStyleBackColor = true;
            this.buttonRunCode.Click += new System.EventHandler(this.buttonRunCode_Click);
            // 
            // buttonAddCode
            // 
            this.buttonAddCode.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCode.Location = new System.Drawing.Point(556, 288);
            this.buttonAddCode.Name = "buttonAddCode";
            this.buttonAddCode.Size = new System.Drawing.Size(104, 87);
            this.buttonAddCode.TabIndex = 5;
            this.buttonAddCode.Text = "Add something code";
            this.buttonAddCode.UseVisualStyleBackColor = true;
            this.buttonAddCode.Click += new System.EventHandler(this.buttonAddCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(695, 433);
            this.Controls.Add(this.buttonAddCode);
            this.Controls.Add(this.buttonRunCode);
            this.Controls.Add(this.buttonInformation1);
            this.Controls.Add(this.buttonNextFigure);
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
        private System.Windows.Forms.Button buttonNextFigure;
        private System.Windows.Forms.Button buttonInformation1;
        private System.Windows.Forms.Button buttonRunCode;
        private System.Windows.Forms.Button buttonAddCode;
    }
}

