using System;
using System.ComponentModel;
using AdvancedTopics.iOS.Effects;
using AdvancedTopics.PlatformConfiguration.iOS;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(ShadowEffectPlatform), "ShadowEffectPlatform")]
namespace AdvancedTopics.iOS.Effects
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
                Control.Layer.CornerRadius = 5;
                Control.Layer.ShadowColor = UIColor.Black.CGColor;
                Control.Layer.ShadowOffset = new CGSize(5, 5);
                Control.Layer.ShadowOpacity = 1.0f;
            }
            else if (!((Label)Element).OnThisPlatform().IsShadowed())
            {
                Control.Layer.ShadowOpacity = 0;
            }
        }
    }
}
