using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Viewer
    {
        public void SeeVideos(ConcreteVideoContent videoContent)
        {
            IVideoIterator iterator = videoContent.CreateNumerator();
            while (iterator.HasNext())
            {
                Video video = iterator.Next();
                Console.WriteLine("Видео: " + video.Name + " посмотрел.");
            }
        }

        public void FindVideo(string name)
        {
            /*if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name is null or empty");
            }*/
            ConcreteVideoContent videoContent = new ConcreteVideoContent();
            var d = videoContent[name]?.Name;

            if (d == null)
                Console.WriteLine("Такого видео нет!!!");
            else
                Console.WriteLine("Нашлось:" + videoContent[name].Name);
        }
    }
}
