extern alias aControllerInterlop; // WARNING : delete
using aControllerInterlop::ABBYY.FlexiCapture;

using System.Windows;

namespace AbbyyDataExport
{
    public class BaseClass
    {
        public void ShowMessage(string text)
        {
            // will show text by standard FlexiCapture means static method void ShowMessage(string text, bool IsError) from static class FCTools ABBYY.FlexiCapture.FCTools.ShowMessage(text, false);
            //MessageBox.Show("Hello World");

            FCTools.ShowMessage(text, false);
        }
    }
}
