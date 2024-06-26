using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbbyyDataExport
{
    public class BaseClass
    {
        public void Show(string text)
        {
            // will show text by standard FlexiCapture means static method void ShowMessage(string text, bool IsError) from static class FCTools ABBYY.FlexiCapture.FCTools.ShowMessage(text, false);
            MessageBox.Show("Hello World");
        }
    }
}
