using Xamarin.Forms;
using AdvancedTopics.Model;
using AdvancedTopics.ViewModel;

namespace AdvancedTopics.View
{
    public class CellTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ImageTemplate { get; set; }

        public DataTemplate AdTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((CardItemViewModel)item).CardType == CardType.Image ? ImageTemplate : AdTemplate;
        }
    }
}
