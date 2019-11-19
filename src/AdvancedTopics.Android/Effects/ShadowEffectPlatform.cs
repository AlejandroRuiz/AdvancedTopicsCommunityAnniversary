using System;
using AdvancedTopics.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AdvancedTopics.PlatformConfiguration.Android;
using System.ComponentModel;

[assembly: ExportEffect(typeof(ShadowEffectPlatform), "ShadowEffectPlatform")]
namespace AdvancedTopics.Droid.Effects
{
    public class ShadowEffectPlatform : PlatformEffect
    {
        public ShadowEffectPlatform()
        {
        }

        protected override void OnAttached()
        {
            UpdateShadow();
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == Shadow.IsShadowedProperty.PropertyName)
            {
                UpdateShadow();
            }
        }

        void UpdateShadow()
        {
            if (((Label)Element).OnThisPlatform().IsShadowed())
            {
                float radius = 5;
                float distanceX = 5;
                float distanceY = 5;
                Android.Graphics.Color color = Android.Graphics.Color.Black;
                (Control as Android.Widget.TextView).SetShadowLayer(radius, distanceX, distanceY, color);
            }
            else if (!((Label)Element).OnThisPlatform().IsShadowed())
            {
                (Control as Android.Widget.TextView).SetShadowLayer(0, 0, 0, Color.Default.ToAndroid());
            }
        }
    }
}
