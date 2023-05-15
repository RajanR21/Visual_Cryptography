using System.Drawing;
using System.Drawing.Imaging;

Bitmap img1 = new Bitmap(@"C:\Users\G3-3500\Pictures\Saved Pictures\Colour_Share_1.png");
Bitmap img2 = new Bitmap(@"C:\Users\G3-3500\Pictures\Saved Pictures\Colour_Share_2.png");

// To load two images from the file and create Bitmap objects
//representing the images.

Bitmap xorImg = new Bitmap(img1.Width, img1.Height);
//creating dummy object with same dimentions as img1 to store output


//this two loops are to iterate each pixel of images
for (int x = 0; x < img1.Width; x++)
{
    for (int y = 0; y < img1.Height; y++)
    {
        Color Color_of_img1 = img1.GetPixel(x, y);
        Color Color_of_img2 = img2.GetPixel(x, y);
        //to extract the color of the corresponding pixel
        //from img1 and img2

        int r = Color_of_img1.R ^ Color_of_img2.R;
        int g = Color_of_img1.G ^ Color_of_img2.G;
        int b = Color_of_img1.B ^ Color_of_img2.B;
        //to perform the XOR operation on the RGB values
        //of the two pixels to obtain new RGB values for the output image.

        Color Color_of_xored = Color.FromArgb(r, g, b);
     //to create a new color object with above RGB values

        xorImg.SetPixel(x, y, Color_of_xored);
     //to set the pixel in output image
    }
}

xorImg.Save(@"C:\Users\G3-3500\Pictures\Saved Pictures\XORed_Colour_out.png");
//final output images
