using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileManager.View
{
    public partial class AddElementView : Form
    {
        public string NazwaKatalogu { get; set; }

        public AddElementView()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaKatalogu.Text))
            {
                MessageBox.Show(
                    "Nazwa katalogu nie może być pusta!", "Uwaga!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            NazwaKatalogu = txtNazwaKatalogu.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
