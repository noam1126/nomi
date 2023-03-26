using nomi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace nomi.UserControls
{
    [Serializable]
    public partial class ShoppingCartItemControl : UserControl
    {
        private readonly ShoppingCartItem _cartItem;
        public ShoppingCartItemControl()
        {
            InitializeComponent();
        }

        public ShoppingCartItemControl(ShoppingCartItem cartItem) : this()
        {
            this._cartItem = cartItem;
            this.PopulateControls();
        }

        private void PopulateControls()
        {
            this.labelName.Text = this._cartItem?.Item?.GetName();
            this.pictureBoxItem.Image = this._cartItem?.Item?.pic;
            this.comboBoxAmount.Text = this._cartItem?.Amount?.ToString();
            if (this._cartItem.Item.GetSize() != null)
                this.labelSize.Text = this._cartItem?.Item?.GetSize();
            this.labelSum.Text = Int32.Parse(this._cartItem.Amount) * (this._cartItem.Item.GetPrice()) + "$";
        }

        private void ShoppingCartItemControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            sc.DeleteCartItem(_cartItem);
            Visible = false;
        }

        private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cartItem.Amount = comboBoxAmount.SelectedItem.ToString();
            this.labelSum.Text = Int32.Parse(this._cartItem.Amount) * (this._cartItem.Item.GetPrice()) + "$";
        }
    }
}
