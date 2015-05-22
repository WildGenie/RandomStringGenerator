namespace RandomGenerator
{
    partial class MainForm
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
            this.stringType = new System.Windows.Forms.CheckedListBox();
            this.minStringSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalStringCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxStringSize = new System.Windows.Forms.NumericUpDown();
            this.generateString = new System.Windows.Forms.Button();
            this.generatedStrings = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minStringSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalStringCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStringSize)).BeginInit();
            this.SuspendLayout();
            // 
            // stringType
            // 
            this.stringType.CheckOnClick = true;
            this.stringType.FormattingEnabled = true;
            this.stringType.Items.AddRange(new object[] {
            "Küçük Harfler (a-z)",
            "Büyük Hafler (A-Z)",
            "Rakamlar (0-9)",
            "Özel Karakterler (*$-+?_&=!%{}/)"});
            this.stringType.Location = new System.Drawing.Point(262, 12);
            this.stringType.Name = "stringType";
            this.stringType.Size = new System.Drawing.Size(186, 64);
            this.stringType.TabIndex = 0;
            // 
            // minStringSize
            // 
            this.minStringSize.Location = new System.Drawing.Point(262, 94);
            this.minStringSize.Name = "minStringSize";
            this.minStringSize.Size = new System.Drawing.Size(186, 20);
            this.minStringSize.TabIndex = 1;
            this.minStringSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(262, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "En Az Karakter Boyutu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(262, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üretilecek Satır Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalStringCount
            // 
            this.totalStringCount.Location = new System.Drawing.Point(262, 170);
            this.totalStringCount.Name = "totalStringCount";
            this.totalStringCount.Size = new System.Drawing.Size(186, 20);
            this.totalStringCount.TabIndex = 3;
            this.totalStringCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(262, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "En Çok Karakter Boyutu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxStringSize
            // 
            this.maxStringSize.Location = new System.Drawing.Point(262, 132);
            this.maxStringSize.Name = "maxStringSize";
            this.maxStringSize.Size = new System.Drawing.Size(186, 20);
            this.maxStringSize.TabIndex = 5;
            this.maxStringSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // generateString
            // 
            this.generateString.Location = new System.Drawing.Point(262, 196);
            this.generateString.Name = "generateString";
            this.generateString.Size = new System.Drawing.Size(186, 23);
            this.generateString.TabIndex = 7;
            this.generateString.Text = "Üret";
            this.generateString.UseVisualStyleBackColor = true;
            this.generateString.Click += new System.EventHandler(this.GenerateStringClick);
            // 
            // generatedStrings
            // 
            this.generatedStrings.Location = new System.Drawing.Point(12, 12);
            this.generatedStrings.Multiline = true;
            this.generatedStrings.Name = "generatedStrings";
            this.generatedStrings.Size = new System.Drawing.Size(244, 207);
            this.generatedStrings.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 229);
            this.Controls.Add(this.generatedStrings);
            this.Controls.Add(this.generateString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxStringSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalStringCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minStringSize);
            this.Controls.Add(this.stringType);
            this.Name = "MainForm";
            this.Text = "Karakter Oluşturucu";
            ((System.ComponentModel.ISupportInitialize)(this.minStringSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalStringCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStringSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox stringType;
        private System.Windows.Forms.NumericUpDown minStringSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown totalStringCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxStringSize;
        private System.Windows.Forms.Button generateString;
        private System.Windows.Forms.TextBox generatedStrings;
    }
}

