using System;
using System.IO;
using System.Text;
//using ExifLibNet;
using ExifLibrary;

namespace GetJPGMetadata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the path to the JPEG image.
            string imagePath = @"C:\Users\admin\source\repos\ConsoleApp4\ConsoleApp4\angry_hoes.jpg";

            // Create a new ImageFile object from the image file.
            ImageFile file = ImageFile.FromFile(imagePath);



            // Get the metadata from the image.
            var metadata = file.Properties;

            file.Properties.Set(ExifTag.WindowsComment, "yeah!!!", Encoding.ASCII);

            // Print out the metadata.
            foreach (var tag in metadata)
            {
                Console.WriteLine($"{tag.Name} = {tag.Value}");
            }
        }
    }
}
