namespace Anipen
{
    public interface ICommand : System.IDisposable
    {
        public void Request();
    }

    public interface ICommandExcutor : System.IDisposable
    {
        public CommandType availableType { get; set; }
        public void Excute(ICommand command);
    }
}
