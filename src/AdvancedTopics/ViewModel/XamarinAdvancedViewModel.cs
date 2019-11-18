using System;
using MvvmHelpers;
using Xamarin.Forms;
using AdvancedTopics.Pages;

namespace AdvancedTopics.ViewModel
{
    public class XamarinAdvancedViewModel : BaseViewModel
    {
        public XamarinAdvancedViewModel()
        {
            GoToDataTemplateCommand = new Command(InvokeGoToDataTemplateCommand);
            GoToThemesCommand = new Command(InvokeGoToThemesCommand);
            GoToBehaviorsCommand = new Command(InvokeGoToBehaviorsCommand);
            GoToTriggersCommand = new Command(InvokeGoToTriggersCommand);
            GoToRenderersEffectsCommand = new Command(InvokeGoToRenderersEffectsCommand);
            GoToDependencyServiceCommand = new Command(InvokeGoToDependencyServiceCommand);
            GoToPlatformSpecificsCommand = new Command(InvokeGoToPlatformSpecificsCommand);
            GoToVisualStateManagerCommand = new Command(InvokeGoToVisualStateManagerCommand);
        }

        public Command GoToDataTemplateCommand { get; }

        public Command GoToThemesCommand { get; }

        public Command GoToBehaviorsCommand { get; }

        public Command GoToTriggersCommand { get; }

        public Command GoToRenderersEffectsCommand { get; }

        public Command GoToDependencyServiceCommand { get; }

        public Command GoToPlatformSpecificsCommand { get; }

        public Command GoToVisualStateManagerCommand { get; }

        async void InvokeGoToDataTemplateCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TemplateSelectorPage());
        }

        async void InvokeGoToThemesCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ThemesPage());
        }

        async void InvokeGoToBehaviorsCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BehaviorsPage());
        }

        async void InvokeGoToTriggersCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TriggersPage());
        }

        async void InvokeGoToRenderersEffectsCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RenderersEffectsPage());
        }

        async void InvokeGoToDependencyServiceCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DependencyServicePage());
        }

        async void InvokeGoToPlatformSpecificsCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PlatformSpecificsPage());
        }

        async void InvokeGoToVisualStateManagerCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VisualStateManagerPage());
        }
    }
}
