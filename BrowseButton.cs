using System.Windows.Forms;

namespace ArtLibrary.ControlLogic
{
    public class BrowseButton
    {
        private string folderPath;
        public string FolderPath => folderPath;

        public void Browse()
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории";

            if (DirDialog.ShowDialog() == DialogResult.OK)
               folderPath =  DirDialog.SelectedPath;
        }
    }
}
