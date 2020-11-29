namespace CoreClient.InjectingCores.MessagingCore.MessageBox
{
    public interface IMessageInject
    {
        void ShowInfo(string message, string caption = null);
    }
}
