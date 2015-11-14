using System;
using System.Collections.Generic;

namespace TryC1Carousel.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
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