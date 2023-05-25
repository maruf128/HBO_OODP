public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }
    public int[,] PixelData { get; }

    public GrayscaleImage(int[,] pixelData)
    {
        PixelData = pixelData;
    }

    public GrayscaleImage(int width, int height)
    {
        Height = height;
        Width = width;
        PixelData = new int[Width, Height];
    }

    public void AdjustBrightness(double factor)
    {
        for (int i = 0; i < PixelData.GetLength(0); i++) // voor iedere gegeven
        {
            for (int j = 0; j < PixelData.GetLength(1); j++) // uit de gegevens pak je iedere getal
            {
                PixelData[i, j] = (int)(PixelData[i, j] * factor);// en doe je het keer
            }
        }
    }
}
