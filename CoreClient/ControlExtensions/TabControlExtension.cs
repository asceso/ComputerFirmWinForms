using System.Windows.Forms;

namespace CoreClient.ControlExtensions
{
    public static class TabControlExtension
    {
        public static bool HasPage(this TabControl control, string Name)
        {
            if (control.TabPages.Count.Equals(0))
            {
                return false;
            }

            foreach (TabPage page in control.TabPages)
            {
                if (page.Name.Equals(Name))
                {
                    return true;
                }
            }

            return false;
        }
        public static void SetPageByName(this TabControl control, string Name)
        {
            TabPage selectedPage = new TabPage();
            foreach (TabPage page in control.TabPages)
            {
                if (page.Name.Equals(Name))
                {
                    selectedPage = page;
                }
            }

            control.SelectedTab = selectedPage;
        }
        public static void AddAndSelectTab(this TabControl control, string Name, string Header)
        {
            TabPage newPage = new TabPage() { Name = Name, Text = Header };
            control.TabPages.Add(newPage);
            control.SelectedTab = newPage;
        }
        public static TabPage GetPageByName(this TabControl control, string Name)
        {
            foreach (TabPage page in control.TabPages)
            {
                if (page.Name.Equals(Name))
                {
                    return page;
                }
            }

            return null;
        }
    }
}
