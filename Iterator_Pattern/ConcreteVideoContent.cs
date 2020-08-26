using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ConcreteVideoContent : IVideoContent
    {
        private Video[] videos;

        public ConcreteVideoContent()
        {
            videos = new Video[]
            {
                new Video {Name = "Урок по C# №1"},
                new Video {Name = "C# Интрефейсы"},
                new Video {Name = "C# Паттерны проетирования. Паттерн итератор."}
            };
        }

        public int CountVideo    // Количество видео на канале
        {
            get { return videos.Length; }
        }
                
        public IVideoIterator CreateNumerator()
        {
            return new ConcreteVideoIterator(this);
        }

        public Video this[int index]
        {
            get { return videos[index]; }
        }

        
        public Video this[string name]
        {
            get { return videos.FirstOrDefault(c => c.Name == name); }
        }
    }
}
