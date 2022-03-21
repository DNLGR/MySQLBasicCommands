namespace MySQLBasicCommands.ViewModels
{
    public class ContentViewModel : ViewModelBase
    {
        #region Properties
        private Page _currentPage;

        public Page CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;

                RaisePropertiesChanged(nameof(CurrentPage));
            }
        }
        #endregion

        #region Ctor
        public ContentViewModel()
        {
            _currentPage = new HomePage();
        }
        #endregion


        #region Navigation commands
        public ICommand WhereCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is WherePage)
                    {
                        return;
                    }

                    CurrentPage = new WherePage();
                });
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is DeletePage)
                    {
                        return;
                    }

                    CurrentPage = new DeletePage();
                });
            }
        }

        public ICommand HomeCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is HomePage)
                    {
                        return;
                    }

                    CurrentPage = new HomePage();
                });
            }
        }

        public ICommand InsertCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is InsertPage)
                    {
                        return;
                    }

                    CurrentPage = new InsertPage();
                });
            }
        }

        public ICommand SelectCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is SelectPage)
                    {
                        return;
                    }

                    CurrentPage = new SelectPage();
                });
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (_currentPage is UpdatePage)
                    {
                        return;
                    }

                    CurrentPage = new UpdatePage();
                });
            }
        }

        public ICommand ExitCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.Shutdown();
                });
            }
        }
        #endregion

    }
}
