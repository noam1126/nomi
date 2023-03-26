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
    public partial class Enter : Form
    {
        public static string lastClick;
        private static Item t1;
        private static Item t2;
        private static Item t3;
        public Enter()
        {
            InitializeComponent();
            //StartButton2();
            //StartButton4();
            StartButtonTops();
            StartButtonBottoms();
            StartButtonBags();
            StartButtonJewellery();
            //StartButton8();
            //StartPictureBox2();
            //StartPictureBox3();
            //StartPictureBox4();
            CreateItems();
        }
        private void CreateItems()
        {
            t1 = new Bags("300", "תיק צד שחור קטן", 150, Properties.Resources.Capture1, true,"צד","שחור");
            label1.Text = t1.GetPrice() + "$";
            labelprice1.Text = "200$";
            t2 = new Tops("100", "חולצת אוברסייז קצרה", 36, Properties.Resources.Capture, "בטן");
            label2.Text = t2.GetPrice() + "$";
            labelprice2.Text = "60$";
            t3 = new Bottoms("200", "מכנס קצר חום",59.40 , Properties.Resources.Capture3, "מכנס","קצר");
            label4.Text = t3.GetPrice() + "$";
            labelprice3.Text = "90$";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //button hover color:
        #region 
        private void OnMouseEnterButtonTops(object sender, EventArgs e)
        {
            buttonTops.BackColor = Color.FromArgb(208, 202, 178);
        }
        private void OnMouseLeaveButtonTops(object sender, EventArgs e)
        {
            buttonTops.BackColor = Color.FromArgb(222, 217, 196);
        }
        private void OnMouseEnterButtonBottoms(object sender, EventArgs e)
        {
            buttonBottoms.BackColor = Color.FromArgb(208, 202, 178);
        }
        private void OnMouseLeaveButtonBottoms(object sender, EventArgs e)
        {
            buttonBottoms.BackColor = Color.FromArgb(222, 217, 196);
        }
        private void OnMouseEnterButtonBags(object sender, EventArgs e)
        {
            buttonBags.BackColor = Color.FromArgb(208, 202, 178);
        }
        private void OnMouseLeaveButtonBags(object sender, EventArgs e)
        {
            buttonBags.BackColor = Color.FromArgb(222, 217, 196);
        }
        private void OnMouseEnterButtonJewellery(object sender, EventArgs e)
        {
            buttonJewellery.BackColor = Color.FromArgb(208, 202, 178);
        }
        private void OnMouseLeaveButtonJewellery(object sender, EventArgs e)
        {
            buttonJewellery.BackColor = Color.FromArgb(222, 217, 196);
        }
        #endregion

        //start buttons
        #region
        //private void StartButton2()
        //{
        //    button2.TabStop = false;
        //    button2.FlatStyle = FlatStyle.Flat;
        //    button2.FlatAppearance.BorderSize = 0;
        //    // button2.FlatAppearance.BorderColor = Color.FromArgb(137, 181, 175);
        //}
        //private void StartButton4()
        //{
        //    button4.TabStop = false;
        //    button4.FlatStyle = FlatStyle.Flat;
        //    button4.FlatAppearance.BorderSize = 0;
        //}
        //private void StartButton8()
        //{
        //    button8.TabStop = false;
        //    button8.FlatStyle = FlatStyle.Flat;
        //    button8.FlatAppearance.BorderSize = 0;
        //}
        
        private void StartButtonTops()
        {
            buttonTops.TabStop = false;
            buttonTops.FlatStyle = FlatStyle.Flat;
            buttonTops.FlatAppearance.BorderSize = 0;
            buttonTops.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
            buttonTops.MouseEnter += OnMouseEnterButtonTops;
            buttonTops.MouseLeave += OnMouseLeaveButtonTops;
        }

        private void StartButtonBottoms()
        {
            buttonBottoms.TabStop = false;
            buttonBottoms.FlatStyle = FlatStyle.Flat;
            buttonBottoms.FlatAppearance.BorderSize = 0;
            buttonBottoms.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
            buttonBottoms.MouseEnter += OnMouseEnterButtonBottoms;
            buttonBottoms.MouseLeave += OnMouseLeaveButtonBottoms;
        }
        private void StartButtonBags()
        {
            buttonBags.TabStop = false;
            buttonBags.FlatStyle = FlatStyle.Flat;
            buttonBags.FlatAppearance.BorderSize = 0;
            buttonBags.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
            buttonBags.MouseEnter += OnMouseEnterButtonBags;
            buttonBags.MouseLeave += OnMouseLeaveButtonBags;
        }
        private void StartButtonJewellery()
        {
            buttonJewellery.TabStop = false;
            buttonJewellery.FlatStyle = FlatStyle.Flat;
            buttonJewellery.FlatAppearance.BorderSize = 0;
            buttonJewellery.FlatAppearance.BorderColor = Color.FromArgb(255, 190, 216);
            buttonJewellery.MouseEnter += OnMouseEnterButtonJewellery;
            buttonJewellery.MouseLeave += OnMouseLeaveButtonJewellery;
        }
        #endregion

        //private void OnMouseEnterPictureBox4(object sender, EventArgs e)
        //{
        //    button2.Visible = true;
        //}
        //private void OnMouseLeavePictureBox4(object sender, EventArgs e)
        //{
        //    button2.Visible = false;

        //}
        //private void StartPictureBox4()
        //{
        //    pictureBox4.MouseEnter += OnMouseEnterPictureBox4;
        //    pictureBox4.MouseLeave += OnMouseLeavePictureBox4;
        //}
        //private void OnMouseEnterPictureBox2(object sender, EventArgs e)
        //{
        //    button4.Visible = true;
        //}
        //private void OnMouseLeavePictureBox2(object sender, EventArgs e)
        //{
        //    button4.Visible = false;

        //}
        //private void OnMouseEnterPictureBox3(object sender, EventArgs e)
        //{
        //    button8.Visible = true;
        //}
        //private void OnMouseLeavePictureBox3(object sender, EventArgs e)
        //{
        //    button8.Visible = false;

        //}

        //private void StartPictureBox2()
        //{
        //    pictureBox2.MouseEnter += OnMouseEnterPictureBox2;
        //    pictureBox2.MouseLeave += OnMouseLeavePictureBox2;
        //}
        //private void StartPictureBox3()
        //{
        //    pictureBox3.MouseEnter += OnMouseEnterPictureBox3;
        //    pictureBox3.MouseLeave += OnMouseLeavePictureBox3;
        //}
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t1);
            vi.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t2);
            vi.Show();
            Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonTops_Click(object sender, EventArgs e)
        {
            lastClick = "buttonTops_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonBottoms_Click_1(object sender, EventArgs e)
        {
            lastClick = "buttonBottoms_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void buttonBags_Click_1(object sender, EventArgs e)
        {
            lastClick = "buttonBags_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void buttonJewellery_Click_1(object sender, EventArgs e)
        {
            lastClick = "buttonJewellery_Click";
            TopsPage tf = new TopsPage(lastClick);
            tf.Show();
            Visible = false;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            sc.Show();
            Visible = false;
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t3);
            vi.Show();
            Visible = false;
        }
    }
}
