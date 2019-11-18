using System;
namespace AdvancedTopics.Model
{
    public class ImageCardItem : ICardItem
    {
        public ImageCardItem()
        {
        }

        public string Text { get; set; }
        public string Details { get; set; }
        public string SourceUrl { get; set; }
        public CardType CardType => CardType.Image;
    }
}
