using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Appvidoe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            MediaPlay.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            MediaPlay.Pause();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            MediaPlay.Stop();
        }

        private void forword_Click(object sender, RoutedEventArgs e)
        {
            MediaPlay.DefaultPlaybackRate = 2.0;
            MediaPlay.Play();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MediaPlay.DefaultPlaybackRate = -2.0;
            MediaPlay.Play();
        }

        private async void choose_Click(object sender, RoutedEventArgs e)
        {
            //FileOpenPicker fopvideo = new FileOpenPicker();
            //fopvideo.SuggestedStartLocation = PickerLocationId.Desktop;
            //fopvideo.FileTypeFilter.Add(".mp4");
            //fopvideo.FileTypeFilter.Add(".ogg");
            //fopvideo.FileTypeFilter.Add(".wmv");
            //StorageFile file = await fopvideo.PickSingleFileAsync();
            //IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read);
            //MediaPlay.SetSource(stream, file.ContentType);
            //MediaPlay.Play();

        }

        private async void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            FileOpenPicker fopvideo = new FileOpenPicker();
            fopvideo.SuggestedStartLocation = PickerLocationId.Desktop;
            fopvideo.FileTypeFilter.Add(".mp4");
            fopvideo.FileTypeFilter.Add(".ogg");
            fopvideo.FileTypeFilter.Add(".wmv");
            StorageFile file = await fopvideo.PickSingleFileAsync();
            IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read);
            MediaPlay.SetSource(stream, file.ContentType);
            MediaPlay.Play();
        }
    }
}
