namespace FileOrganiserSuccession
{
    public partial class Form1 : Form
    {
        private readonly string[] filePath = Directory.GetFiles(Environment.CurrentDirectory);
        
        // Source: https://www.computerhope.com/issues/ch001789.htm
        private readonly Dictionary<string, string[]> _fileTypes = new()
        {
            { "audio", ["aif", "cda", "mid", "midi", "mp3", "mpa", "ogg", "wav", "wma", "wpl"] },
            { "compressed", ["7z", "arj", "deb", "pkg", "rar", "rpm", "tar", "gz", "z", "zip"] },
            { "image", ["ai", "bmp", "gif", "ico", "jpeg", "jpg", "png", "ps", "psd", "scr", "svg", "tif", "tiff", "webp"] }
        };
        
        public Form1()
        {
            InitializeComponent();
            lblFileCount.Text = $"Detected: {filePath.Length} files";
        }

        private void btnOrganise_Click(object sender, EventArgs e)
        {
            foreach (string file in filePath)
            {
                Console.WriteLine(file);
            }
        }
    }
}
