using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public class SolutionHelper
    {

        public static Image ConvertToImage(byte[] fileStructure) {
            MemoryStream ms = new MemoryStream(fileStructure);
            Bitmap myBitmap = new Bitmap(ms);

            return myBitmap;
        }

        public byte[] ConvertToByte(OpenFileDialog openFileDialog)
        {
            byte[] file = null;
            Stream myStream = openFileDialog.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            return file;
        }

        public void BrowseFile(OpenFileDialog openFileDialog, PictureBox pictureBox)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Archivos jpg(*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
