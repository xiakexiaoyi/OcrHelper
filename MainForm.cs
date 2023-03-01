using PaddleOCRSharp;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OcrHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        OCRStructureResult ocrResult = new OCRStructureResult();
        PaddleOCREngine ocrEngine = new PaddleOCREngine(null, new OCRParameter());
        Rectangle rectangle = Screen.PrimaryScreen.Bounds;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
            new Thread(() =>
            {
                while (true)
                {
                    StartOcr(true);
                    Thread.Sleep(500);
                }

            })
            { IsBackground = true }.Start();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        public void StartOcr(bool auto=false)
        {
            if (!checkBox_Auto.Checked&&auto) { return; }
            Image image = new Bitmap(panel_Image.Width, panel_Image.Height);
            Graphics graph = Graphics.FromImage(image);
            graph.CopyFromScreen(new Point(this.Left, this.Top + (this.Height - this.ClientSize.Height)), new Point(0, 0), new Size(panel_Image.Width, panel_Image.Height - (this.Height - this.ClientSize.Height)));
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ocrResult = ocrEngine.DetectStructure(image);
            List<TextBlock> textBlocks = ocrResult.TextBlocks;
            string result = "";
            for (int i = 0; i < textBlocks.Count; i++)
            {
                result += textBlocks[i].Text+"\r\n";

            }
            this.BeginInvoke(new Action(() =>
            {
                richTextBox_Result.Text = result;
            }));

        }

        private void button_StartOcr_Click(object sender, EventArgs e)
        {
            StartOcr(false);
        }

        private void checkBox_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Auto.Checked) { button_StartOcr.Enabled = false; }
            else {
                button_StartOcr.Enabled = true;
            }
        }
    }
}