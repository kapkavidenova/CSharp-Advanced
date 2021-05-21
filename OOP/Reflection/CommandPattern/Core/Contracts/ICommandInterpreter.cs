namespace CommandPattern.Core.Contracts
{
    public interface ICommandInterpreter
    {
        string Read(string args);
        string Read(object args);
    }
}
