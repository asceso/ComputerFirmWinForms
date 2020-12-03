using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreClient.ControlExtensions
{
    public partial class TextEditControl : UserControl
    {
        #region header

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Текст заголовка")]
        [Description("Задает или возвращает заголовок поля TextEdit")]
        [Browsable(true)]
        public string Header
        {
            get => TextEditHeader.Text;
            set => TextEditHeader.Text = value;
        }

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Минимальный размер заголовка")]
        [Description("Задает или возвращает минимальный размер заголовка TextEdit")]
        [Browsable(true)]
        public Size MinHeaderSize
        {
            get => TextEditHeader.MinimumSize;
            set => TextEditHeader.MinimumSize = new Size(value.Width, value.Height);
        }

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Размер заголовка")]
        [Description("Задает или возвращает размер заголовка TextEdit")]
        [Browsable(true)]
        public Size HeaderSize
        {
            get => TextEditHeader.Size;
            set => TextEditHeader.Size = new Size(value.Width, value.Height);
        }
        #endregion header
        #region value

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Значение")]
        [Description("Задает или возвращает значение поля TextEdit")]
        [Browsable(true)]
        public string Value
        {
            get => TextEditValueBox.Text;
            set => TextEditValueBox.Text = value;
        }

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Использовать PasswordChar")]
        [Description("Устанавливает свойство использовать символ пароля")]
        [Browsable(true)]
        public bool UsingPasswordChar
        {
            get => TextEditValueBox.UseSystemPasswordChar;
            set => TextEditValueBox.UseSystemPasswordChar = value;
        }

        [Category("Настраиваемые аттрибуты")]
        [DisplayName("Выравнивание текста в Value")]
        [Description("Устанавливает выравнивание поля Value TextEdit")]
        [Browsable(true)]
        public HorizontalAlignment ValueTextAlign
        {
            get => TextEditValueBox.TextAlign;
            set => TextEditValueBox.TextAlign = value;
        }
        #endregion
        #region events

        [Category("Настраиваемые ивенты")]
        [DisplayName("Поведение TextChanged")]
        [Description("Изменяет привязку Value Box'a к ивенту TextChanged")]
        public void SetTextChangedEvent(EventHandler action) => TextEditValueBox.TextChanged += action;

        [Category("Настраиваемые ивенты")]
        [DisplayName("Поведение KeyPress")]
        [Description("Изменяет привязку Value Box'a к ивенту KeyPress")]
        public void SetKeyPressEvent(KeyPressEventHandler action) => TextEditValueBox.KeyPress += action;
        #endregion

        public TextEditControl() => InitializeComponent();
    }
}
