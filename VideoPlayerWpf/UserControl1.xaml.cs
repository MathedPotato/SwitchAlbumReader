using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoPlayerWpf
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        bool isMediaPlaying = false;
        bool userControlTimeline = false;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void OnClickPlay(object sender, RoutedEventArgs e)
        {
            //mediaElement1.Play();
            //btnPlay.Content = mediaElement1.ActualHeight.ToString();
            ToggleMediaPlay();
        }

        private void OnClickPause(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void OnClickStop(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        public void ChangeSource(string newSrc)
        {
            StopMedia();
            mediaElement1.Source = new Uri(newSrc);
        }

        public void StopMedia()
        {
            mediaElement1.Stop();
            btnPlay.Content = "Play";
            isMediaPlaying = false;
        }

        public void ToggleMediaPlay()
        {
            if(isMediaPlaying)
            {
                mediaElement1.Pause();
                btnPlay.Content = "Play";
                isMediaPlaying = false;
            }
            else
            {
                mediaElement1.Play();
                btnPlay.Content = "Pause";
                isMediaPlaying = true;
            }
        }

        private void timelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            /*int sliderValue = (int)timelineSlider.Value;

            TimeSpan seekTime = new TimeSpan(0, 0, 0, 0, sliderValue);
            mediaElement1.Position = seekTime;*/
        }

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            timelineSlider.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
            ToggleMediaPlay();
        }

        private void mediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            StopMedia();
        }

        private void timelineSlider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            /*int sliderValue = (int)timelineSlider.Value;

            TimeSpan seekTime = new TimeSpan(0, 0, 0, 0, sliderValue);
            mediaElement1.Position = seekTime;
            userControlTimeline = false;*/
        }

        private void timelineSlider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //userControlTimeline = true;
        }

        private void mediaElement1_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            timelineSlider.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void timelineSlider_MouseMove(object sender, MouseEventArgs e)
        {
            /*timelineSlider.ToolTip = (timelineSlider.Value/1000).ToString("0.00") + "/" + (mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds/1000).ToString("0.00");
            if (!userControlTimeline)
            {
                timelineSlider.Value = mediaElement1.Position.TotalMilliseconds;
            }
            else
            {
                timelineSlider.Value = (e.GetPosition(timelineSlider).X/timelineSlider.Width) * timelineSlider.Maximum;
            }*/
        }

        private void timelineSlider_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            userControlTimeline = true;
        }

        private void timelineSlider_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            int sliderValue = (int)timelineSlider.Value;

            TimeSpan seekTime = new TimeSpan(0, 0, 0, 0, sliderValue);
            mediaElement1.Position = seekTime;
            userControlTimeline = false;
        }

        private void timelineSlider_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (!userControlTimeline)
            {
                timelineSlider.Value = mediaElement1.Position.TotalMilliseconds;
            }
            else
            {
                timelineSlider.Value = (e.GetPosition(timelineSlider).X / timelineSlider.Width) * timelineSlider.Maximum;
            }

            timelineSlider.ToolTip = (timelineSlider.Value / 1000).ToString("0.00") + "/" + (mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds / 1000).ToString("0.00");
            mediaDuration.Text = "0:" + (timelineSlider.Value / 1000).ToString("00") + " / 0:" + (mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds / 1000).ToString("00");
        }

        private void mediaElement1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //ToggleMediaPlay();
        }

        private void mediaElement1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ToggleMediaPlay();
        }

        private void StackPanel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            /*if(e.Key == Key.Space)
            {
                ToggleMediaPlay();
            }*/

            switch (e.Key)
            {
                case Key.Space:
                    ToggleMediaPlay();
                    break;
                case Key.J:
                    mediaElement1.Position = new TimeSpan(0, 0, 0, 0, (int)(mediaElement1.Position.TotalMilliseconds - 5000.00));
                    break;
                case Key.L:
                    mediaElement1.Position = new TimeSpan(0, 0, 0, 0, (int)(mediaElement1.Position.TotalMilliseconds + 5000.00));
                    break;
            }
        }
    }
}
