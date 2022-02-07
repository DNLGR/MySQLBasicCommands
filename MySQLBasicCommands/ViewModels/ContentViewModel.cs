namespace MySQLBasicCommands.ViewModels
{
    public class ContentViewModel : ViewModelBase
    {
        #region Ctor
        public ContentViewModel()
        {

        }
        #endregion

        #region Commands
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

        public ICommand MaximizeCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                });
            }
        }

        public ICommand MinimizeCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                });
            }
        }


        #endregion
    }
}
