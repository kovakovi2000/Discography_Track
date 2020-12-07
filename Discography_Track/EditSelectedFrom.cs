using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discography_Track
{
    public partial class EditSelectedFrom : Form
    {
        public EditSelectedFrom()
        {
            InitializeComponent();
        }
        private bool doChange = false;
        public string Title { get => tb_title.Text; set => tb_title.Text = value; }
        public string Time { get => tb_time.Text; set => tb_time.Text = value; }
        public string Url { get => tb_url.Text; set => tb_url.Text = value; }
        public bool DoChange { get => doChange; }

        private void btn_setvalue_Click(object sender, EventArgs e)
        {
            SetDoChange();
            this.Close();
        }

        private void SetDoChange()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save your changes?", "Changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doChange = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                doChange = false;
            }
        }

        public void OnlyUrl()
        {
            tb_title.ReadOnly = true;
            tb_time.ReadOnly = true;
        }
    }
}
