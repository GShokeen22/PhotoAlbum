using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class CreateNewAlbum : Form
    {
        public CreateNewAlbum()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                PhotoAlbum parentForm = (PhotoAlbum)Owner;
                parentForm.SetTextInLabel(txtAlbumName.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
