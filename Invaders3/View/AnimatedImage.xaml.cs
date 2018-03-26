using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Invaders3.View
{
    /// <summary>
    /// Interaction logic for AnimatedImage.xaml
    /// </summary>
    public partial class AnimatedImage : UserControl
    {
        public AnimatedImage()
        {
            InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval)
            : this()
        {
            StartAnimation(imageNames, interval);
        }

        public void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval)
        {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.SourceProperty));

            TimeSpan currentInteval = TimeSpan.FromMilliseconds(0);  
            foreach (string imageName in imageNames)
            {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                keyFrame.Value = InvadersHelper.CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currentInteval;
                animation.KeyFrames.Add(keyFrame);
                currentInteval = currentInteval.Add(interval);
            }

            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        public void InvaderShot()
        {
            Storyboard invaderShotStoryboard = FindResource("invaderShotStoryboard") as Storyboard;
            invaderShotStoryboard.Begin();
        }

        public void StartFlashing()
        {
            Storyboard flashStoryboard = FindResource("flashStoryboard") as Storyboard;
            flashStoryboard.Begin();
        }

        public void StopFlashing()
        {
            Storyboard flashStoryboard = FindResource("flashStoryboard") as Storyboard;
            flashStoryboard.Stop();
        }
    }
}
