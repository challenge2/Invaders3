using System.Windows;
using System.Windows.Input;

namespace Invaders3.View
{
    public partial class InvadersWindow : Window
    {
        ViewModel.InvadersViewModel viewModel;  // *
        public InvadersWindow()
        {
            InitializeComponent();
        }
        private void StartButtonClick(object sender, RoutedEventArgs e)
        {
            viewModel = FindResource("viewModel") as ViewModel.InvadersViewModel;
            viewModel.StartGame();
        }


        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            viewModel.KeyDown(e.Key);
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            viewModel.KeyUp(e.Key);
        }

        private void playArea_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePlayAreaSize(playArea.RenderSize);  // ?
        }

        private void pageRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdatePlayAreaSize(new Size(e.NewSize.Width, e.NewSize.Height ));  // *
        }

        private void UpdatePlayAreaSize(Size newPlayAreaSize)
        {
            double targetWidth;
            double targetHeight;
            if (newPlayAreaSize.Width > newPlayAreaSize.Height)
            {
                targetWidth = newPlayAreaSize.Height * 4 / 3;
                targetHeight = newPlayAreaSize.Height;
                double leftRightMargin = (newPlayAreaSize.Width - targetWidth) / 2;
                playArea.Margin = new Thickness(leftRightMargin, 0, leftRightMargin, 0);
            }
            else
            {
                targetHeight = newPlayAreaSize.Width * 3 / 4;
                targetWidth = newPlayAreaSize.Width;
                double topBottomMargin = (newPlayAreaSize.Height - targetHeight) / 2;
                playArea.Margin = new Thickness(0, topBottomMargin, 0, topBottomMargin);
            }
            playArea.Width = targetWidth;
            playArea.Height = targetHeight;
            viewModel.PlayAreaSize = new Size(targetWidth, targetHeight);  // *
        }
    }
}
