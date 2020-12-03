using System.Windows.Forms;

namespace CoreClient.InjectingCores.MessagingCore.AskBox
{
    public interface IAskInject
    {
        DialogResult ShowQuestion(string message, string caption = null);
    }
}
