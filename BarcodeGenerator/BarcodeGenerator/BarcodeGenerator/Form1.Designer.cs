namespace BarcodeGenerator
{
    partial class BarcodeGenerator
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
            label1 = new Label();
            BarcodeTextBox = new TextBox();
            BarcodeButton = new Button();
            QRButton = new Button();
            QRTextBox = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Barcode:";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Location = new Point(125, 28);
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.Size = new Size(486, 27);
            BarcodeTextBox.TabIndex = 1;
            BarcodeTextBox.TextChanged += BarcodeTextBox_TextChanged;
            // 
            // BarcodeButton
            // 
            BarcodeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BarcodeButton.Location = new Point(617, 17);
            BarcodeButton.Name = "BarcodeButton";
            BarcodeButton.Size = new Size(122, 43);
            BarcodeButton.TabIndex = 2;
            BarcodeButton.Text = "Generate";
            BarcodeButton.UseVisualStyleBackColor = true;
            BarcodeButton.Click += BarcodeButton_Click;
            // 
            // QRButton
            // 
            QRButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QRButton.Location = new Point(617, 90);
            QRButton.Name = "QRButton";
            QRButton.Size = new Size(122, 43);
            QRButton.TabIndex = 5;
            QRButton.Text = "Generate";
            QRButton.UseVisualStyleBackColor = true;
            QRButton.Click += QRButton_Click;
            // 
            // QRTextBox
            // 
            QRTextBox.Location = new Point(125, 101);
            QRTextBox.Name = "QRTextBox";
            QRTextBox.Size = new Size(486, 27);
            QRTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 3;
            label2.Text = "QRcode:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(125, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 215);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SaveButton.Location = new Point(299, 395);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(122, 43);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BarcodeGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(pictureBox1);
            Controls.Add(QRButton);
            Controls.Add(QRTextBox);
            Controls.Add(label2);
            Controls.Add(BarcodeButton);
            Controls.Add(BarcodeTextBox);
            Controls.Add(label1);
            Name = "BarcodeGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barcode Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BarcodeTextBox;
        private Button BarcodeButton;
        private Button QRButton;
        private TextBox QRTextBox;
        private Label label2;
        private PictureBox pictureBox1;
        private Button SaveButton;
    }
}
