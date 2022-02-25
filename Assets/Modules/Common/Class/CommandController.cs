namespace Anipen
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public enum CommandType { Network, UI }

    public class CommandController : Singleton<CommandController>
    {
        #region Members
        private List<ICommandExcutor> excutors;
        #endregion

        #region Constructor
        public CommandController()
        {
            excutors = new List<ICommandExcutor>();
        }
        #endregion

        #region Methods
        public void Register(ICommandExcutor excutor)
        {
            if (!excutors.Contains(excutor))
                excutors.Add(excutor);
        }

        public void UnRegister(ICommandExcutor excutor)
        {
            excutors.Remove(excutor);
        }

        public void SendCommand(Command command)
        {
            foreach (var excutor in excutors)
            {
                if(command.excutableType == excutor.availableType)
                    excutor.Excute(command);
            }
        }
        #endregion
    }
}
