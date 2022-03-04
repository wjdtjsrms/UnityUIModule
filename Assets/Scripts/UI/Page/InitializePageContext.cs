namespace Anipen.MetaPubs.UI
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Slash.Unity.DataBind.Core.Data;
    using Anipen.UI;

    public class InitializePageContext : Context
    {
        #region Member & Property
        private readonly Property<bool> isPageActiveProperty = new Property<bool>();
        private readonly Property<bool> isStateMainProperty = new Property<bool>();
        private readonly Property<bool> isStateLoadingProperty = new Property<bool>();

        public bool IsPageActive
        {
            get => isPageActiveProperty.Value;
            set => isPageActiveProperty.Value = value;
        }

        public bool IsStateMain
        {
            get => isStateMainProperty.Value;
            set => isStateMainProperty.Value = value;
        }

        public bool IsStateLoading
        {
            get => isStateLoadingProperty.Value;
            set => isStateLoadingProperty.Value = value;
        }
        #endregion

        #region Constuctor & Dispose
        public InitializePageContext()
        {
            UIContextController.Instance.RegisterPage(PageType.Initialize, ExcuteCommand);
            new UICommandPage(PageType.Initialize).Request();
        }

        ~InitializePageContext()
        {
            UIContextController.Instance.UnRegisterPage(PageType.Initialize);
        }
        #endregion

        #region Method
        public void ExcuteCommand(UICommand command)
        {
            IsPageActive = true;
            IsStateMain = true;

        }

        private void OpenPage()
        {

        }

        private void ClosePage()
        {

        }

        public void OnClickPage()
        {
            IsStateLoading = true;
            new UICommandPage(PageType.Info).Request();
        }
        #endregion
    }
}

