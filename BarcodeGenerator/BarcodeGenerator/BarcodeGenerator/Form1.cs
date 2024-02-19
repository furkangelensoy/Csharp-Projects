using System.DirectoryServices;
using System.Drawing.Imaging;

namespace BarcodeGenerator
{
    public partial class BarcodeGenerator : Form
    {

        bool isGenerated = false;
        public BarcodeGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BarcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarcodeButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(BarcodeTextBox.Text, 200);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(QRTextBox.Text, 200);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path1 = @"D:\.NetPractice\vs\BarcodeGenerator";

                pictureBox1.Image.Save(path1 + "\\" + DateTime.Now.Second.ToString() +
                    DateTime.Now.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);
            }
           
        }
    }
}
