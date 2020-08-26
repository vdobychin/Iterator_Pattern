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
        IVideoContent aggregate;
        int index = 0;
        
        public ConcreteVideoIterator(IVideoContent a)
        {
            aggregate = a;
        }

        public bool HasNext()
        {
            return index < aggregate.CountVideo;
        }

        public Video Next()
        {
            return aggregate[index++];
        }
    }
}
