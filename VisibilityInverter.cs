using System.Collections.Generic;
using System.Windows.Forms;

namespace ArtLibrary.ControlLogic
{
    public class VisibilityInverter<T> where T : Control
    {
        public void InvertVisibility(List<T> listControls) 
        {
            foreach( var element  in listControls)
            {
                InvertVisibility(element);
            }
        }

        public void InvertVisibility(T control)
        {
            control.Visible = !control.Visible;
        }
    }
}
