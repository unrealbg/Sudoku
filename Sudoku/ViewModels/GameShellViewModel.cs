using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku.ViewModels
{
    public class GameShellViewModel : BindableBase
    {
        private string title = "Sudoku WPF";

        public string Title
        {
            get => this.title;
            set => SetProperty(ref this.title, value);

        }
    }
}
