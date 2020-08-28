using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    //Счетчик
    class ConcreteVideoIterator : IVideoIterator
    {
        private readonly IVideoContent videoContent; // Экземпляр конктретного итератора будет хранить ссылку на экземпляр конкретного видео контента
        private int index = 0;  // Указатель на элемент моего хранилища
        
        public ConcreteVideoIterator(IVideoContent videoContent)
        {
            this.videoContent = videoContent;
        }

        public bool HasNext()
        {
            return index < videoContent.CountVideo;
        }

        public Video Next()
        {
            return videoContent[index++];
        }
    }
}
