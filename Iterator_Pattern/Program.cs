using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteVideoContent videoContent = new ConcreteVideoContent();
            Viewer viewer = new Viewer();
            viewer.SeeVideos(videoContent);

            Console.WriteLine("Введите видео");
            var searchVideo = Console.ReadLine();
            viewer.FindVideo(searchVideo);
            Console.Read();
        }
    }
}
