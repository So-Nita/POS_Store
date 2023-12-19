using POSDesignDemo.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDesignDemo.Components
{
    public partial class FormCreateCategory : Form
    {
        private readonly ProductController _service;
        public FormCreateCategory()
        {
            InitializeComponent();
            //_service = new ProductController();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           // var result = _service.
        }
    }
}
