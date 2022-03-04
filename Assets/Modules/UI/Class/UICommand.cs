namespace Anipen.UI
{
    using System;
    using System.Collections.Generic;

    public class UICommand : Command
    {
        #region Member
        public Dictionary<string, object> _DataDic { get; protected set; }
        public Dictionary<string, Action> _CallbackDic { get; protected set; }
        public Enum _UIType { get; protected set; }
        #endregion

        #region Consturctor & Dispose
        public UICommand()
        {
            _ExcutableType = CommandType.UI;
            _DataDic = new Dictionary<string, object>();
            _CallbackDic = new Dictionary<string, Action>();
        }

        ~UICommand() => Dispose();
        #endregion

        #region Method : Override
        public override void Dispose()
        {
            base.Dispose();
            _DataDic?.Clear();
            _CallbackDic?.Clear();
            _DataDic = null;
            _CallbackDic = null;
        }
        #endregion


        #region Method : Member
        public UICommand SetData(string key, object value)
        {
            if (_DataDic.ContainsKey(key))
                _DataDic[key] = value;
            else
                _DataDic.Add(key, value);

            return this;
        }

        public UICommand SetCallBack(string key, Action callBack)
        {
            if (_DataDic.ContainsKey(key))
                _CallbackDic[key] = callBack;
            else
                _CallbackDic.Add(key, callBack);

            return this;
        }

        public UICommand SetFinishCallback(Action callBack)
        {
            _onFinishCommand = callBack;
            return this;
        }

        public object GetData(string key)
        {
            return _DataDic.ContainsKey(key) ? _DataDic[key] : default;
        }
        #endregion
    }
}