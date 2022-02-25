namespace Anipen
{
    using System;

    public class Command : ICommand
    {
        #region Members
        public CommandType excutableType;

        protected Action onFinishCommand;
        #endregion

        #region Members

        public Command(Action finishCallback = null)
        {
            onFinishCommand = finishCallback;
        }
        #endregion

        #region Implementation : ICommand
        public virtual void Request()
        {
            CommandController.Instance.SendCommand(this);
        }

        public virtual void Finish()
        {
            onFinishCommand?.Invoke();
            Dispose();
        }

        public virtual void Dispose() { onFinishCommand = null; }
        #endregion
    }
}