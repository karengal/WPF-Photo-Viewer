using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace SDKSamples.ImageSample
{

    public partial class PhotoView : Window
    {
        Photo _photo;

        public PhotoView()
        {
            InitializeComponent();            
        }

        public Photo SelectedPhoto
        {
            get { return _photo; }
            set { _photo = value; }
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ViewedPhoto.Source = _photo.Image;
            ViewedCaption.Content = _photo.Source;
        }

        private void Rotate(object sender, RoutedEventArgs e)
        {

            BitmapSource img = (BitmapSource)(_photo.Image);

            CachedBitmap cache = new CachedBitmap(img, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            _photo.Image = BitmapFrame.Create(new TransformedBitmap(cache, new RotateTransform(90.0)));

            ViewedPhoto.Source = _photo.Image;
        }

        private void Crop(object sender, RoutedEventArgs e)
        {
            BitmapSource img = (BitmapSource)(_photo.Image);

            int halfWidth = img.PixelWidth / 2;
            int halfHeight = img.PixelHeight / 2;
            _photo.Image = BitmapFrame.Create(new CroppedBitmap(img, new Int32Rect((halfWidth - (halfWidth / 2)), (halfHeight - (halfHeight / 2)), halfWidth, halfHeight)));

            ViewedPhoto.Source = _photo.Image;
        }

        private void BlackAndWhite(object sender, RoutedEventArgs e)
        {
            BitmapSource img = (BitmapSource)(_photo.Image);
            _photo.Image = BitmapFrame.Create(new FormatConvertedBitmap(img, PixelFormats.Gray8, BitmapPalettes.Gray256, 1.0));

            ViewedPhoto.Source = _photo.Image;
        }

        private void aPicture_MouseDown(object sender, MouseEventArgs e)
        {
            Point clickPoint = e.GetPosition(ViewedPhoto);
            Console.Write("YAY");
            Rectangle myRgbRectangle = new Rectangle();
            myRgbRectangle.Width = 1;
            myRgbRectangle.Height = 1;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, (byte)10);
            myRgbRectangle.Fill = mySolidColorBrush;

        }
    }
}