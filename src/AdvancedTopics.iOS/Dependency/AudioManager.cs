using System;
using AdvancedTopics.Dependency;
using AVFoundation;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(AdvancedTopics.iOS.Dependency.AudioManager))]
namespace AdvancedTopics.iOS.Dependency
{
    public class AudioManager : IAudioManager
    {
        private AVAudioPlayer _mAudioPlayer;

        public AudioManager()
        {
        }

        public void PlayAudio(string file)
        {
            if (_mAudioPlayer != null)
            {
                _mAudioPlayer.Stop();
                _mAudioPlayer.Dispose();
                _mAudioPlayer = null;
            }
            var soundFile = NSBundle.MainBundle.PathForResource(file, null);
            var url = NSUrl.FromFilename(soundFile);
            _mAudioPlayer = AVAudioPlayer.FromUrl(url);
            _mAudioPlayer.Play();
        }
    }
}
