using SixLabors.ImageSharp;

namespace Fundamentals.Helpers
{
    public class AspectRatio
    {
        public static async Task Calculate(string imageUrl)
        {
            try
            {
                HttpClient client = new();
                var stream = await client.GetStreamAsync(imageUrl);
                Image image = await Image.LoadAsync(stream);
                double width = image.Width;
                double height = image.Height;
                Console.WriteLine($"Width: {width} Height:{height}");
                if (width == height)
                {
                    Console.WriteLine("The aspect ratio is 1:1");
                }
                if (16 / 9 == width / height)
                {
                    Console.WriteLine("The aspect ratio is 16:9");
                }
                if (3 / 2 == width / height)
                {
                    Console.WriteLine("The aspect ratio is 3:2");
                }
                if (16 / 10 == width / height)
                {
                    Console.WriteLine("The aspect ratio is 16:10");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}