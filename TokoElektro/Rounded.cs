using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoElektro
{
    internal class Rounded
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // example usage: qwe.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, qwe.Width, qwe.Height, 20, 20));
        // qwe ganti jadi nama komponennya

    }
}
