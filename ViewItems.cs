using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nomi.classes;

namespace nomi
{
    public partial class ViewItems : Form
    {
        public static string lastClick;
        public static Item t;
        public static string amount = "1";
        public ViewItems(Item item)
        {
            InitializeComponent();
            startItem(item);
            StartButtonBags();
            StartButtonBottoms();
            StartButtonTops();
            StartButtonJewellery();
            t = item;
        }
        public ViewItems()
        {
            InitializeComponent();
            StartButtonBags();
            StartButtonBottoms();
            StartButtonTops();
            StartButtonJewellery();
        }
        private void startItem(Item t)
        {
            pictureBoxItem.Image = t.pic;
            labelName.Text = "פריט: " + t.GetName();
            labelPrice.Text = "מחיר: " + t.GetPrice() + "$";
        }
        private void StartButtonTops()
        {
            buttonTops.TabStop = false;
            buttonTops.FlatStyle = FlatStyle.Flat;
            buttonTops.FlatAppearance.BorderSize = 0;
            buttonTops.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
        }
        private void StartButtonBottoms()
        {
            buttonBottoms.TabStop = false;
            buttonBottoms.FlatStyle = FlatStyle.Flat;
            buttonBottoms.FlatAppearance.BorderSize = 0;
            buttonBottoms.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
        }
        private void StartButtonBags()
        {
            buttonBags.TabStop = false;
            buttonBags.FlatStyle = FlatStyle.Flat;
            buttonBags.FlatAppearance.BorderSize = 0;
            buttonBags.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
        }
        private void StartButtonJewellery()
        {
            buttonJewellery.TabStop = false;
            buttonJewellery.FlatStyle = FlatStyle.Flat;
            buttonJewellery.FlatAppearance.BorderSize = 0;
            buttonJewellery.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    checkedListBox1.SetItemChecked(x, false);
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Enter en = new Enter();
            en.Show();
            Visible = false;
        }
        private void buttonTops_Click_1(object sender, EventArgs e)
        {
            lastClick = "buttonTops_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void buttonBottoms_Click(object sender, EventArgs e)
        {
            lastClick = "buttonBottoms_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void buttonBags_Click(object sender, EventArgs e)
        {
            lastClick = "buttonBags_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void buttonJewellery_Click(object sender, EventArgs e)
        {
            lastClick = "buttonJewellery_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void labelName_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            bool flag = false;
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.CheckedItems.Count == 0 && t is Clothing)
                {
                    flag = true;
                    label1.Visible = true;
                }
                else if (checkedListBox1.GetItemChecked(i))
                {
                    string size = checkedListBox1.Items[i].ToString();
                    t.SetSize(size);
                    label1.Visible = false;
                }
            }
            if (flag == false)
            {
                sc.AddToCart(t, amount);
                PopUp pup = new PopUp();
                pup.Show();
            }
        }
        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            amount = comboBoxAmount.SelectedItem.ToString();
        }

        private void ViewItems_Load(object sender, EventArgs e)
        {
            comboBoxAmount.Text = "1";
            if (t is Accessories)
            {
                sizeLabel.Visible = false;
                checkedListBox1.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            sc.Show();
            Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Enter enter = new Enter();
            enter.Show();
            Visible = false;
        }
    }
}
