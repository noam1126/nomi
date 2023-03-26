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
using nomi.UserControls;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace nomi
{
    public partial class ShoppingCart : Form
    {
        public static string lastClick;
        //public static List <shoppingCart> cart = new List<shoppingCart>();
        public static List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
        //protected static List<ShoppingCartItem> cart = new List<ShoppingCartItem>();
        public static int placeItemInCart = 0;
        public ShoppingCart()
        {
            InitializeComponent();
            StartButtonBags();
            StartButtonBottoms();
            StartButtonTops();
            StartButtonJewellery();
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
        private void StartItem()
        {
            Item t = cart[0].Item;
            //pictureBoxItem.Image = t.pic;
            //labelName.Text = "שם הפריט: " + t.GetName();
        }

        public void AddToCart(Item item, string amount)
        {
            ShoppingCartItem sc = new ShoppingCartItem();
            sc.Item = item;
            sc.Amount = amount;

            cart.Add(sc);
        }
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            this.cartItemsPanel.FlowDirection = FlowDirection.TopDown;
            this.cartItemsPanel.AutoScrollMinSize = new Size(0, 1200);
            this.cartItemsPanel.Controls.Clear();
            foreach (ShoppingCartItem item in cart)
            {
                var cartItem = new ShoppingCartItemControl(item);
                this.cartItemsPanel.Controls.Add(cartItem);
            }

            //pictureBoxItem.Image = sc.item.pic;
            //if (sc.item is Bags){ }
            //else
            //    label7.Text = sc.item.GetSize().ToString();
            //comboBoxAmount.Text = sc.amount.ToString();
            //labelName.Text = sc.item.GetName();
            //labelSum.Text = Int32.Parse(sc.amount) * sc.item.GetPrice() + "$";
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Width = 282;
            //pictureBox.Height = 253;
            //pictureBox.Image = sc.item.pic;
            //pictureBox.Location = new Point(747, 0);
            //pictureBox.Visible = true;
            //panel1.Controls.Add(pictureBox);
            //}
        }

        public void DeleteCartItem(ShoppingCartItem cartItem)
        {
            foreach (ShoppingCartItem item in cart)
            {
                if (item != cartItem)
                    placeItemInCart++;
                else
                    break;
            }

            cart.RemoveAt(placeItemInCart);
            placeItemInCart = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Enter en = new Enter();
            en.Show();
            Visible = false;
        }

        private void buttonTops_Click(object sender, EventArgs e)
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

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxItem_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //amount = comboBoxAmount.SelectedItem.ToString();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelSum_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Enter enter = new Enter();
            enter.Show();
            Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            SaveScreenshot(this);
            //    ShoppingCart sc = new ShoppingCart();
            //    Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //    Graphics g = Graphics.FromImage(img);
            //    g.CopyFromScreen(0, 0, 0, 0, img.Size);

            //    using (var bmp = new Bitmap(cartItemsPanel.Width, cartItemsPanel.Height))
            //    {
            //        cartItemsPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //        bmp.Save("C:\\Users\\noam1\\Desktop\\clothing");
            //    }
            //SendKeys.Send("%{prtsc}");
            //Image myImg = Clipboard.GetImage();
            //// Image img = Clipboard.GetImage();
            ////pictureBox1.Image = img;
            //myImg.Save("C:\\Users\\noam1\\Desktop\\clothing");
            //this.Show();
            //var frm = ShoppingCart.ActiveForm;
            //using (var bmp = new Bitmap(frm.Width, frm.Height))
            //{
            //    frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //    bmp.Save(@"C:\Users\noam1\Desktop\clothing");
            //}
        }

        private void cartItemsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private static void SaveScreenshot(ShoppingCart shopping)
        {
            string ImagePath = string.Format(@"C:\Users\noam1\Desktop\clothing\noam.png", DateTime.Now.Ticks);
            Bitmap Image = new Bitmap(shopping.Width, shopping.Height);
            shopping.DrawToBitmap(Image, new Rectangle(0, 0, shopping.Width, shopping.Height));
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingCartItem sc = new ShoppingCartItem();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // IFormatter formatter = new BinaryFormatter();
                //using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                //{
                //    formatter.Serialize(stream, cart);
                //}
                using (Stream stream = File.Open(@"C:\Users\noam1\Desktop\clothing\hello.mdl", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, cart);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                cart = (List<ShoppingCartItem>)binaryFormatter.Deserialize(stream);
                cartItemsPanel.Invalidate();
            }
        }
    }
}
