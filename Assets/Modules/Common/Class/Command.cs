namespace Anipen
{
    using System;

    public class Command : ICommand
    {
        #region Members
        protected Action _onFinishCommand;
        #endregion

        #region Property
        public CommandType _ExcutableType { get; protected set; }
        #endregion

        #region Dispose
        ~Command() => Dispose();
        #endregion

        #region Implementation : ICommand
        public virtual void Request()
        {
            CommandController.Instance.SendCommand(this);
        }

        public virtual void Finish()
        {
            _onFinishCommand?.Invoke();
            Dispose();
        }

        public virtual void Dispose()
        {
            _onFinishCommand = null;
        }
        #endregion
    }
}