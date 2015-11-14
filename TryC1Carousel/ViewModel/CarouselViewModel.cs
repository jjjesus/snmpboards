using GalaSoft.MvvmLight;
using TryC1Carousel.Model;
using System.Collections.ObjectModel;

namespace TryC1Carousel.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class CarouselViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="BoardList" /> property's name.
        /// </summary>
        public const string BoardListPropertyName = "BoardList";

        ObservableCollection<Board> _boardList;

        /// <summary>
        /// Sets and gets the BoardList property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public ObservableCollection<Board> BoardList
        {
            get
            {
                return _boardList;
            }
            set
            {
                Set(BoardListPropertyName, ref _boardList, value, true);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public CarouselViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetBoards(
                (boards, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    BoardList = new ObservableCollection<Board>(boards);
                });
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}