using System;
using System.Drawing;
using System.Windows.Forms;
using CoreClient.StyleExtensions.Controls;

namespace CoreClient.ControlExtensions
{
    public static class PanelExtesions
    {
        private const string NullString = "";
        public static TextBox GetTextBoxFromPanel(this Panel panel, string Name)
        {
            foreach (Control item in panel.Controls)
            {
                if (item.Name.Equals(Name))
                {
                    return (TextBox)item;
                }
            }
            return null;
        }
        public static MaskedTextBox GetMaskBoxFromPanel(this Panel panel, string Name)
        {
            foreach (Control item in panel.Controls)
            {
                if (item.Name.Equals(Name))
                {
                    return (MaskedTextBox)item;
                }
            }
            return null;
        }
        public static ControlType GetFormControlFromPanel<ControlType>(this Panel panel, string Name)
        {
            foreach (Control item in panel.Controls)
            {
                if (item.Name.Equals(Name))
                {
                    if (item is ControlType returnedItem)
                    {
                        return returnedItem;
                    }
                }
            }
            return default;
        }

        #region creating subitems for panel

        /// <summary>
        /// Добавляет текст бокс с маской или без в панель
        /// </summary>
        /// <param name="panel">панель в которую нужно добавить</param>
        /// <param name="textBoxName">имя созданного текст бокса</param>
        /// <param name="headerValue">текст заголовка</param>
        /// <param name="tabIndex">индекс табуляции</param>
        /// <param name="Mask">маска (по умолчанию выключена, если добавить тип будет MaskedTextBox)</param>
        /// <param name="itemHeight">высота текстбокса (по умолчанию - 25)</param>
        /// <param name="labelHeight">высота заголовка (по умолчанию - 25)</param>
        /// <param name="dock">привязка к стороне, по умолчанию сверху</param>
        /// <param name="passwordCharEnabled">включить если нужно использовать парольный символ</param>
        public static void CreateTextBoxWithLabel(this Panel panel,
            string textBoxName, string headerValue, int tabIndex,
            string Mask = NullString, int itemHeight = 25, int labelHeight = 25,
            DockStyle dock = DockStyle.Top, bool passwordCharEnabled = false)
        {
            if (string.IsNullOrEmpty(Mask))
            {
                panel.Controls.Add(new TextBox()
                {
                    TabIndex = tabIndex,
                    Name = textBoxName,
                    Dock = dock,
                    Height = itemHeight,
                    UseSystemPasswordChar = passwordCharEnabled
                });
            }
            else
            {
                panel.Controls.Add(new MaskedTextBox()
                {
                    Mask = Mask,
                    TextMaskFormat = MaskFormat.ExcludePromptAndLiterals,
                    TabIndex = tabIndex,
                    Name = textBoxName,
                    Dock = dock,
                    Height = itemHeight
                });
            }

            panel.Controls.Add(new Label()
            {
                Text = headerValue,
                TextAlign = ContentAlignment.BottomCenter,
                Dock = dock,
                AutoSize = false,
                Height = labelHeight
            });
        }

        /// <summary>
        /// Добавляет комбо бокс в панель
        /// </summary>
        /// <param name="panel">панель в которую нужно добавить</param>
        /// <param name="comboBoxName">имя созданного комбо бокса</param>
        /// <param name="headerValue">текст заголовка</param>
        /// <param name="tabIndex">индекс табуляции</param>
        /// <param name="style">стиль комбобокса
        /// (по умолчанию - выпадающий список без редактирования)</param>
        /// <param name="itemHeight">высота текстбокса (по умолчанию - 25)</param>
        /// <param name="labelHeight">высота заголовка (по умолчанию - 25)</param>
        /// <param name="dock">привязка к стороне, по умолчанию сверху</param>
        public static void CreateComboBoxWithLabel(this Panel panel,
            string comboBoxName, string headerValue, int tabIndex,
            ComboBoxStyle style = ComboBoxStyle.DropDownList,
            int itemHeight = 25, int labelHeight = 25,
            DockStyle dock = DockStyle.Top)
        {
            panel.Controls.Add(new ComboBox()
            {
                TabIndex = tabIndex,
                Name = comboBoxName,
                DropDownStyle = style,
                Dock = dock,
                Height = itemHeight
            });
            panel.Controls.Add(new Label()
            {
                Text = headerValue,
                TextAlign = ContentAlignment.BottomCenter,
                Dock = dock,
                AutoSize = false,
                Height = labelHeight
            });
        }

        /// <summary>
        /// Добавляет BaseStyledButton в панель
        /// </summary>
        /// <param name="panel">панель в которую нужно добавить</param>
        /// <param name="buttonName">имя созданной кнопки</param>
        /// <param name="buttonText">текст созданной кнопки</param>
        /// <param name="tabIndex">индекс табуляции</param>
        /// <param name="handler">ивент для кнопки, если null не добавляется</param>
        /// <param name="isButtonRounded">округлость кнопки (по умолчанию выключена)</param>
        /// <param name="itemHeight">высота текстбокса (по умолчанию - 25)</param>
        /// <param name="labelHeight">высота заголовка (по умолчанию - 25)</param>
        /// <param name="dock">привязка к стороне, по умолчанию сверху</param>
        public static void CreateButtonWithLabel(this Panel panel,
            string buttonName, string buttonText,
            int tabIndex, EventHandler handler = null,
            bool isButtonRounded = false,
            int itemHeight = 20, int labelHeight = 25,
            DockStyle dock = DockStyle.Top)
        {
            BaseStyledButton button = new BaseStyledButton()
            {
                Name = buttonName,
                Text = buttonText,
                TabIndex = tabIndex,
                RoundingEnable = isButtonRounded,
                Dock = dock,
                Height = itemHeight
            };
            if (!handler.IsNull())
            {
                button.Click += handler;
            }

            panel.Controls.Add(button);
            panel.Controls.Add(new Label()
            {
                TextAlign = ContentAlignment.BottomCenter,
                Dock = dock,
                AutoSize = false,
                Height = labelHeight
            });
        }

        #endregion
    }
}
