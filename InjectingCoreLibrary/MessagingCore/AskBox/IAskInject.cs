using System.Windows.Forms;

namespace InjectingCoreLibrary.MessagingCore.AskBox
{
    public interface IAskInject
    {
        DialogResult ShowQuestion(string message, string caption = null);
    }
}
