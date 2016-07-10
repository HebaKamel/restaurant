using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void gelButton1_Click(object sender, EventArgs e)
        {
            var orderFormObj = new OrderForm();
            Hide();
            orderFormObj.Show();
        }
    }
}
