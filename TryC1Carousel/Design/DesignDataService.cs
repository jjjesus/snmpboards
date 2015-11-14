using System;
using System.Collections.Generic;
using TryC1Carousel.Model;

namespace TryC1Carousel.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }


        public void GetBoards(Action<System.Collections.Generic.List<Board>, Exception> callback)
        {
            Exception err = null;
            List<Board> results = new List<Board>()
            {
                new Board("board1"),
                new Board("board2"),
                new Board("board3"),
                new Board("board4"),
                new Board("board5"),
                new Board("board6"),
            };
            callback(results, err);
        }
    }
}