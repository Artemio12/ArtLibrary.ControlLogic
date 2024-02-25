using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ArtLibrary.ControlLogic
{
    public enum SwitchButtonEnum
    {
        LastPicture,
        NextPicture,
    }
    
    public class SwitchImageButtons
    {
        private List<string> pathImages;
        public List<string> PathImages { get; set; }   
        
        private PictureBox pictureBox;
        public PictureBox PictureBox {  get; set; }

        public void SwitchButton(SwitchButtonEnum switchButton,ref int i)
        {
            switch (switchButton)
            {
                case SwitchButtonEnum.LastPicture:
                    LastPicture(ref i);
                    break;
                case SwitchButtonEnum.NextPicture:
                    NextPicture(ref i);
                    break;
            }
        }

        private void LastPicture(ref int i)
        {
            if (i != 0)
            {
                i--;
                ShowPicture(i);
            }
            else MessageBox.Show("Это первое изображение в папке");
        }

        private void NextPicture(ref int i)
        {
            if (i != pathImages.Count - 1)
            {
                i++;
                ShowPicture(i);
            }
            else MessageBox.Show("Это последнее изображение в папке");
        }

        private void ShowPicture(int i)
        {
            pictureBox.Image = Image.FromFile(pathImages[i]);
        }
    }
}
