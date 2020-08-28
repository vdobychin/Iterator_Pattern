using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ConcreteVideoContent : IVideoContent
    {
        private readonly Video[] videos;    //Создаем хранилище для видео роликов
        
        public ConcreteVideoContent()       
        {
            videos = new Video[]
            {
                new Video {Name = "Урок по C# №1"},
                new Video {Name = "C# Интрефейсы"},
                new Video {Name = "C# Паттерны проетирования. Паттерн итератор."}
            };
        }
                                
        public IVideoIterator CreateNumerator()
        {
            return new ConcreteVideoIterator(this);
        }

        public int CountVideo    // Количество видео на канале (Открытое целочисленное свойство)
        {
            get { return videos.Length; } // get - метод аксессор
        }

        public Video this[int index]     //Индексатор для обращения к элементу массива по целочисленному индексу
        {
            get { return videos[index]; }
        }

        
        public Video this[string name]  //Индексатор для обращения к элементу массива по строчному индексу
        {
            get { return videos.FirstOrDefault(c => c.Name == name); }
        }
    }
}
