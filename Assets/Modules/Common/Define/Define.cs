namespace Anipen.MetaPubs
{
    #region State
    public enum MainState { None = 0, Initialize, Info, Loading, Street, Pub, Table }
    public enum InitializingState { None, PermissionChecking, Login, }
    #endregion

    #region UI Type
    public enum PageType
    {
        None,

        // Common Page
        StreetSelection, Phone, Profile, Messenger, Loading,

        // Intro Page
        Initialize, Info,

        // Street Page
        Street,

        // Pub Page
    }

    public enum PopupType
    {
        None,
        AskPermission,
        SelectMap,
        SelectButton,
        PhoneMenu,
        CustomOneButton,
        CustomTwoButton,
    }

    public enum CustomPopupType
    {
        None,
        LayoutOneButton,
        LayoutTwoButton,
    }

    public enum PageOpenMode
    {
        Convert, 
        Additive
    }

    public enum ContentType
    {
        None,
        Text,
        Image,
        PermissionContent
    }
    #endregion

    public static class ResourceKeyDefine
    {
        public static string AnimationPrefix { get; } = "animations";
        public static string InfoFileLabel { get; } = "info";
        public static string AvatarInfoFileName { get; } = "avatars.json";
        public static string PropertyInfoFileName { get; } = "properties.json";
        public static string IconPrefix { get; } = "icon_";
    }

    public static class UIKeyDefine
    {
        public static string PermissionKey { get; } = "permissions";
        public static string ButtonCallback { get; } = "btnCallback";
        public static string ApplyBasicInfo { get; } = "applyMyInfo";
        public static string LoadingTypeKey { get; } = "loadingType";
    }
}