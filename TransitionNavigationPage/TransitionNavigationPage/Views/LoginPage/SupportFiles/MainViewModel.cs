using System.Windows.Input;
using TransitionNavigationPage.Views.LoginPage;
using Xamarin.Forms;

namespace TransitionNavigationPage.Views.LoginPage.SupportFiles
{
    public class MainViewModel : BindableObject
    {
        public ICommand ScanQRCodeCommand => new Command(ScanQRCode);
        public ICommand LoginByQRCodeCommand => new Command(LoginByQRCode);
        public ICommand LoginByPasswordCommand => new Command(LoginByPassword);

        public ICommand FadeCommand => new Command(Fade);
        public ICommand FlipCommand => new Command(Flip);
        public ICommand ScaleCommand => new Command(Scale);
        public ICommand SlideFromLeftCommand => new Command(SlideFromLeft);
        public ICommand SlideFromRightCommand => new Command(SlideFromRight);
        public ICommand SlideFromTopCommand => new Command(SlideFromTop);
        public ICommand SlideFromBottomCommand => new Command(SlideFromBottom);


        private void ScanQRCode()
        {
            LoginPage.allowClick = true;
            MessagingCenter.Send(this, AppSettings.ScanQRCode, TransitionType.SlideFromTop);
        }

        private void LoginByQRCode()
        {
            LoginPage.allowClick = true;
            MessagingCenter.Send(this, AppSettings.LoginByQRCode, TransitionType.SlideFromTop);
        }

        private void LoginByPassword()
        {
            LoginPage.allowClick = true;
            MessagingCenter.Send(this, AppSettings.LoginByPassword, TransitionType.SlideFromTop);
        }

        private void Fade()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.Fade);
        }

        private void Flip()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.Flip);
        }

        private void Scale()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.Scale);
        }

        private void SlideFromLeft()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.SlideFromLeft);
        }

        private void SlideFromRight()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.SlideFromRight);
        }

        private void SlideFromTop()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.SlideFromTop);
        }

        private void SlideFromBottom()
        {
            MessagingCenter.Send(this, AppSettings.TransitionMessage, TransitionType.SlideFromBottom);
        }
    }
}
