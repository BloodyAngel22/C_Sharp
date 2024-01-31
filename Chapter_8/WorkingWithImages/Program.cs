using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

class Program
{
	public static void Main(string[] args)
	{
		string imageFolder = Path.Combine(Environment.CurrentDirectory, "Categories");
		IEnumerable<string> images = Directory.EnumerateFiles(imageFolder);
		foreach (var imagePath in images)
		{
			string thumbnailPath = Path.Combine(Environment.CurrentDirectory, "Categories", Path.GetFileNameWithoutExtension(imagePath) + "-thumbnail" + Path.GetExtension(imagePath));

			using (Image image = Image.Load(imagePath))
			{
				image.Mutate(x => x.Resize(image.Width / 10, image.Height / 10));
				image.Mutate(x => x.Grayscale());
				image.Save(thumbnailPath);
			}
		}
		System.Console.WriteLine("Image processing complete. View the images folder.");
	}
}