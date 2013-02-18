using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WindowsPhone_Task.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace WindowsPhone_Task
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            // 用于本地化 ApplicationBar 的示例代码
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebBrowserTask browser = new WebBrowserTask();
            browser.URL = "http://haozi.freetzi.com";
            browser.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PhoneCallTask call = new PhoneCallTask();
            call.DisplayName = "haozi";//名字
            call.PhoneNumber = "123451354566";//号码
            call.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SmsComposeTask sms = new SmsComposeTask();
            sms.To = "haozi";//列表中的名字
            sms.Body = "Hi ,happy new year";//短信内容
            sms.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CameraCaptureTask camera = new CameraCaptureTask();
            camera.Completed += camera_Completed;
            camera.Show();
        }

        void camera_Completed(object sender, PhotoResult e)
        {
            BitmapImage img = new BitmapImage();
            img.SetSource(e.ChosenPhoto);//接受照片流
            image.Source = img;
            //throw new NotImplementedException();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EmailComposeTask email = new EmailComposeTask();
            email.To = "haozzzzzzzz@gmail.com";
            email.Subject = "Say Hello To Haozi";
            email.Body = "Hi haozi !";
            email.Show();
        }
        private PhotoChooserTask photo = new PhotoChooserTask();
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            photo.Completed += photo_Completed;

            photo.ShowCamera = true;//允许使用相机
            //获取photo的尺寸
            photo.PixelHeight = 100;
            photo.PixelWidth = 100;
            photo.Show();
        }

        void photo_Completed(object sender, PhotoResult e)
        {
            //throw new NotImplementedException();
            BitmapImage img = new BitmapImage();
            img.SetSource(e.ChosenPhoto);
            image.Source = img;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher media = new MediaPlayerLauncher();
            media.Controls = MediaPlaybackControls.All;
            media.Location = MediaLocationType.Install;
            media.Media = new Uri("http://www.w3school.com.cn/i/song.mp3", UriKind.Absolute);
            media.Show();
        }

        // 用于生成本地化 ApplicationBar 的示例代码
        //private void BuildLocalizedApplicationBar()
        //{
        //    // 将页面的 ApplicationBar 设置为 ApplicationBar 的新实例。
        //    ApplicationBar = new ApplicationBar();

        //    // 创建新按钮并将文本值设置为 AppResources 中的本地化字符串。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // 使用 AppResources 中的本地化字符串创建新菜单项。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}