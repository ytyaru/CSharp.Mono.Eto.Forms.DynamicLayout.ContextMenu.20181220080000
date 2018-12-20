using System;
using Eto.Forms;
using Eto.Drawing;

namespace HelloDDynamicLayoutContextMenu
{
    public partial class MainForm : Form
    {
		private TextArea textArea1;
		private ContextMenu textArea1Menu;
        public MainForm()
        {
            Title = "DynamicLayout.ContextMenu";
            ClientSize = new Size(800, 600);

			textArea1 = new TextArea() { Width=800, Height=600 };
			textArea1Menu = new ContextMenu();
			Command showDialog = new Command();
			showDialog.MenuText = "ダイアログ表示";
            showDialog.Executed += (object sender, EventArgs e) => {
				MessageBox.Show("ダイアログを表示します。");
            };
			textArea1Menu.Items.Add(showDialog);
			var layout = new DynamicLayout();
			layout.Add(textArea1);
			layout.ContextMenu = textArea1Menu;
			Content = layout;
        }
    }
}
