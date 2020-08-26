using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    interface IVideoContent // Совокупность видеороликов (видеоконтент)
    {
        IVideoIterator CreateNumerator();
        int CountVideo { get; }

        // Индексатор интерфейса IVideoContent
        Video this[int index] { get; }
        Video this[string name] { get; }
    }
}
