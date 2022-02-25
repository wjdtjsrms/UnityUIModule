namespace Anipen.UI.Context
{
    using System.Collections;
    using System.Collections.Generic;
    using Slash.Unity.DataBind.Core.Data;
    using UnityEngine;

    public class LabelSetterContext : Context
    {
        private readonly Property<string> myTextProperty = new Property<string>();

        public LabelSetterContext()
        {
            MyText = "Data bind";
        }

        public string MyText
        {
            get
            {
                return myTextProperty.Value;
            }
            set
            {

                myTextProperty.Value = value;
            }
        }

        public void OnClickButton()
        {
            MyText = "Test";
        }
    }
}
