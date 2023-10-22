using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;
using MyToolkit;

namespace WrapperViewModel
{
    public class BookViewModel : ObervableObject
    {
        private Book _book;
        public string Name
        {
            get => _book.Title;
            set => MyOnPropertyChanged(_book.Title, value, v => _book.Title = v);
        }

        public string Id
        {
            get => _book.Id;
            set => MyOnPropertyChanged(_book.Id, value, v => _book.Id = v);
        }

        public Status Status
        {
            get => _book.Status;
            set => MyOnPropertyChanged(_book.Status, value, v => _book.Status = v);
        }

        public ICommand ChangeBookStatusCommand { get; private set; }

        private ILibManager LibManager;

        public BookViewModel(ILibManager libManager)
        {
            this.LibManager = libManager;

            ChangeBookStatusCommand = new ChangeBookStatusCommand(ChangeBookStatus);
        }

        public void GetBookById(string id)
        {
            _book = LibManager.GetBookById(id);
        }

        private void ChangeBookStatus()
        {
            if (this.Status == Status.Unread)
            {
                this.Status = Status.Read;
            }
            else
            {
                this.Status = Status.Unread;
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