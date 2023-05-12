using System.Drawing;
using System.Drawing.Imaging;

Bitmap img1 = new Bitmap(@"C:\Users\G3-3500\Pictures\Screenshots\a.png");
Bitmap img2 = new Bitmap(@"C:\Users\G3-3500\Pictures\Screenshots\xrr.png");
Bitmap xorImg = new Bitmap(img1.Width, img1.Height);

for (int x = 0; x < img1.Width; x++)
{
    for (int y = 0; y < img1.Height; y++)
    {
        Color img1Color = img1.GetPixel(x, y);
        Color img2Color = img2.GetPixel(x, y);

        int r = img1Color.R ^ img2Color.R;
        int g = img1Color.G ^ img2Color.G;
        int b = img1Color.B ^ img2Color.B;

        Color xorColor = Color.FromArgb(r, g, b);
        xorImg.SetPixel(x, y, xorColor);
    }
}

xorImg.Save(@"C:\Users\G3-3500\Pictures\Screenshots\xrr1.png");
