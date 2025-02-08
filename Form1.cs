using Tomlyn;
using Tomlyn.Model;

namespace FileOrganiserSuccession
{
    public partial class Form1 : Form
    {
        private readonly string[] _filePath = Directory.GetFiles(Environment.CurrentDirectory);
        private readonly TomlTable _fileTypes;
        
        public Form1()
        {
            InitializeComponent();
            lblFileCount.Text = $"Detected: {_filePath.Length} files";
            _fileTypes = Toml.Parse(File.ReadAllText("file_mappings.toml")).ToModel();
        }

        private void btnOrganise_Click(object sender, EventArgs e)
        {
            foreach (string fileType in _fileTypes.Keys)
            {
                // WHAT DOES THIS MEAN AI
                if (_fileTypes.TryGetValue(fileType, out var tomlArray1) && tomlArray1 is TomlArray fileExtensions)
                {
                    Console.WriteLine($"{fileType}:");
                    foreach (var extension in fileExtensions)
                    {
                        Console.WriteLine(extension);
                    }
                }
            }
        }
    }
}
