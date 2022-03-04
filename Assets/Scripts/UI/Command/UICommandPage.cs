namespace Anipen.MetaPubs
{
    using Anipen.UI;

    public class UICommandPage : UICommand
    {
        public PageOpenMode _PageOpenMode { get; private set; }

        public UICommandPage(PageType type, PageOpenMode mode = PageOpenMode.Convert) : base()
        {
            _UIType = type;
            _PageOpenMode = mode;
        }
    }
}
