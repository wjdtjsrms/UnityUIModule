namespace Anipen.MetaPubs.UI
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Slash.Unity.DataBind.Core.Data;
    using Anipen.UI;

    public class InfoPageContext : Context
    {
        private readonly Property<bool> isPageActiveProperty = new Property<bool>();

        public bool IsPageActive
        {
            get => isPageActiveProperty.Value;
            set => isPageActiveProperty.Value = value;
        }

        public InfoPageContext()
        {
            UIContextController.Instance.RegisterPage(PageType.Info, ExcuteCommand);
        }

        ~InfoPageContext()
        {
            UIContextController.Instance.UnRegisterPage(PageType.Info);
        }

        public void ExcuteCommand(UICommand command)
        {
            IsPageActive = true;
        }
    }

}

