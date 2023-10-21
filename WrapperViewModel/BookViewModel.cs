using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace WrapperViewModel
{
    // All the code in this file is included in all platforms.
    public class BookViewModel : INotifyPropertyChanged
    {
        private Book book;
        public string Name
        {
            get => book.Title;
            set
            {
                if(book.Title != value)
                {
                    book.Title = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Id
        {
            get => book.Id;
            set
            {
                if(book.Id != value)
                {
                    book.Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public Status Status
        {
            get => book.Status;
            set
            {
                if(book.Status != value)
                {
                    book.Status = value;
                    OnPropertyChanged(nameof(Status));
                }
            }
        }

        public ICommand ChangeBookStatusCommand { get; private set; }

        private ILibManager LibManager;

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public BookViewModel(ILibManager libManager)
        {
            this.LibManager = libManager;

            ChangeBookStatusCommand = new ChangeBookStatusCommand(ChangeBookStatus);
        }

        public void GetBookById(string id)
        {
            book = LibManager.GetBookById(id);
        }

        private void ChangeBookStatus()
        {
            if (Status == Status.Unread)
            {
                Status = Status.Read;
            }
            else
            {
                Status = Status.Unread;
            }
        }
    }

    public class ChangeBookStatusCommand : ICommand
    {
        private readonly Action _execute;

        public event EventHandler? CanExecuteChanged;

        public ChangeBookStatusCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute();
        }
    }
}