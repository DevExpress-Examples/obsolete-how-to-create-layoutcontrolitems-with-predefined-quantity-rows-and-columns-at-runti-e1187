using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			int rows = 10;
			int cols = 5;
			layoutControl1.BeginInit();
			List<BaseLayoutItem> layout = new List<BaseLayoutItem>();
			for(int i = 0; i < rows; ++i) {
				for(int j = 0; j < cols; ++j) {
					LayoutControlItem labelItems = new LayoutControlItem();
					labelItems.Name = Guid.NewGuid().ToString();
					labelItems.Text = "(" + i + "," + j + ")";
                    TextEdit edit = new TextEdit();
                    edit.Name = Guid.NewGuid().ToString();
                    labelItems.Control = edit;
					layout.Add(labelItems);
					labelItems.Location = new Point(j * 200, i * 200);
					labelItems.Size = new Size(200, 200);
				}
			}
			layoutControlGroup1.Items.AddRange(layout.ToArray());
			layoutControl1.EndInit();
		}
	}
}