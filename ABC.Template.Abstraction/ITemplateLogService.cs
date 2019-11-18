namespace ABC.Template.Abstraction
{
    public interface ITemplateLogService
    {
        string Name { get; }

        void Log(string msg);
    }
}
