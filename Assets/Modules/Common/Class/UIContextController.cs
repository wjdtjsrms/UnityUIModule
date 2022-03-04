namespace Anipen
{
    using Anipen.UI;
    using System;
    using System.Collections.Generic;

    public sealed class UIContextController : Singleton<UIContextController>, ICommandExcutor
    {
        #region Member
        private readonly Dictionary<Enum, Action<UICommand>> _myPages = new Dictionary<Enum, Action<UICommand>>();
        private Stack<Enum> _pageStack = new Stack<Enum>();
        private Stack<Enum> _popupStack = new Stack<Enum>();
        #endregion

        public CommandType availableType { get; set; } = CommandType.UI;

        public UIContextController() 
        {
            CommandController.Instance.Register(this);
        }

        ~UIContextController()
        {
            Dispose();
        }

        public void Dispose()
        {
            CommandController.Instance.UnRegister(this);
            _myPages.Clear();
        }


        #region Method : Member
        public void RegisterPage(Enum key, Action<UICommand> value)
        {
            if (!_myPages.ContainsKey(key))
                _myPages.Add(key, value);
        }

        public void UnRegisterPage(Enum key)
        {
            if (_myPages.ContainsKey(key))
                _myPages.Remove(key);
        }
        #endregion

        public void Excute(ICommand command)
        {
            if (command is UICommand)
            {
                using (var uiCommand = command as UICommand)
                {
                    if (_myPages.ContainsKey(uiCommand._UIType))
                    {
                        _myPages[uiCommand._UIType](uiCommand);
                        uiCommand.Finish();
                    }
                }
            }
        }
    }
}