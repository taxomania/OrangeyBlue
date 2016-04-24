using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace uk.co.taxomania.orangeyblue
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int guess;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            guess = 1;
        }


        private void Tapped_Black(object sender, TappedRoutedEventArgs e)
        {
            UpdateAnwersBlock(Colour.BLACK);
        }

        private void Reset()
        {
            if (guess <= 1) return;
            for (int i = guess; i>0; i--)
            {
                var view = GetView(i);
                view.Source = new BitmapImage(new Uri("ms-appx:/Assets/smalldefault.png", UriKind.Absolute));
            }
            guess = 1;
        }

        private async void UpdateAnwersBlock(Colour colour)
        {
            bool correct = GameEngine.CheckColour(colour);
            var view = GetView(guess);
            if (view == null) return;
            string uri="ms-appx:/Assets/";

            if (correct)
            {
                if (colour == Colour.BLACK)
                    uri += "smallblack.png";
                else
                    uri += "smallred.png";
               
                view.Source = new BitmapImage(new Uri(uri, UriKind.Absolute));

                guess++;
                if (guess > 20)
                {
                    // todo win game
                    var messageDialog = new MessageDialog("You won!");
                    messageDialog.Title = "Orangey Blue";
                    messageDialog.Commands.Add(new UICommand("Play again", (command) =>
                    {
                        Reset();
                    }));

                    IUICommand x = await messageDialog.ShowAsync();
                    Reset();
                }
            
            }
            else
            {

                var messageDialog = new MessageDialog("You guessed " + (guess-1) + " right!");
                messageDialog.Title = "Orangey Blue";
                messageDialog.Commands.Add(new UICommand("Try again", (command) =>
                {
                    Reset();
                }));

                IUICommand x = await messageDialog.ShowAsync();
                Reset();

                // todo lose game
            }

            
        }

        private void Tapped_Red(object sender, TappedRoutedEventArgs e)
        {
            UpdateAnwersBlock(Colour.RED);
        }

        private Image GetView(int guess)
        {
            switch (guess)
            {
                case 1:
                    return answer1;
                case 2:
                    return answer2;
                case 3:
                    return answer3;
                case 4:
                    return answer4;
                case 5:
                    return answer5;
                case 6:
                    return answer6;
                case 7:
                    return answer7;
                case 8:
                    return answer8;
                case 9:
                    return answer9;
                case 10:
                    return answer10;
                case 11:
                    return answer11;
                case 12:
                    return answer12;
                case 13:
                    return answer13;
                case 14:
                    return answer14;
                case 15:
                    return answer15;
                case 16:
                    return answer16;
                case 17:
                    return answer17;
                case 18:
                    return answer18;
                case 19:
                    return answer19;
                case 20:
                    return answer20;
                default:
                    return null;
            }
        }
    }
}
