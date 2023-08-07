using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Drawing;


///     ENCRYPTION
/*
class Program
{
    static void Main()
    {
        // Step 1: Load the original image
        Bitmap originalImage = new Bitmap("C:\\Users\\G3-3500\\Pictures\\binary.png"); // Replace with the path to your original image

        // Step 2: Generate share 1
        Bitmap share1 = GenerateShare1(originalImage);

        // Step 3: Generate share 2 using XOR operation between original image and share 1
        Bitmap share2 = GenerateShare2(originalImage, share1);

        // Step 4: Save the shares
        share1.Save("C:\\Users\\G3-3500\\Pictures\\sh1.png"); // Replace with the desired output path for share 1
        share2.Save("C:\\Users\\G3-3500\\Pictures\\sh2.png"); // Replace with the desired output path for share 2

        Console.WriteLine("Shares generated successfully.");
    }

    static Bitmap GenerateShare1(Bitmap originalImage)
    {
        int width = originalImage.Width;
        int height = originalImage.Height;

        Bitmap share1 = new Bitmap(width, height);

        Random random = new Random();

        // Generate random pixels (0 or 1) for share 1
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                bool randomBit = random.Next(2) == 1; // Generate a random bit (0 or 1)
                Color pixelColor = randomBit ? Color.White : Color.Black;
                share1.SetPixel(j, i, pixelColor);
            }
        }

        return share1;
    }

    static Bitmap GenerateShare2(Bitmap originalImage, Bitmap share1)
    {
        int width = originalImage.Width;
        int height = originalImage.Height;

        Bitmap share2 = new Bitmap(width, height);

        // Generate share 2 by XORing each pixel of the original image with share 1
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Color originalPixel = originalImage.GetPixel(j, i);
                Color share1Pixel = share1.GetPixel(j, i);

                // XOR operation between the original pixel and share 1 pixel
                Color share2Pixel = Color.FromArgb(
                    originalPixel.R ^ share1Pixel.R,
                    originalPixel.G ^ share1Pixel.G,
                    originalPixel.B ^ share1Pixel.B
                );

                share2.SetPixel(j, i, share2Pixel);
            }
        }

        return share2;
    }
}

*/
                  

                /////DECRYPTION

Bitmap img1 = new Bitmap(@"C:\Users\G3-3500\Pictures\sh1.png");
Bitmap img2 = new Bitmap(@"C:\Users\G3-3500\Pictures\sh2.png");

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

xorImg.Save(@"C:\Users\G3-3500\Pictures\XORed_Colour_out3.png");
//final output images

