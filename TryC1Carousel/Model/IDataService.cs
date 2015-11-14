using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryC1Carousel.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
        void GetBoards(Action<List<Board>, Exception> callback);
    }
}
