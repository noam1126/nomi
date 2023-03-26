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
    public partial class TopsPage : Form
    {
        private static Item t1;
        private static Item t2;
        private static Item t3;
        private static Item t4;
        private static Item t5;
        private static Item t6;
        public TopsPage(string lastClick)
        {
            InitializeComponent();
            StartButtonTops();
            StartButtonBottoms();
            StartButtonBags();
            StartButtonJewellery();
            WhichClick(lastClick);
        }
        public TopsPage()
        {
            InitializeComponent();
            StartButtonTops();
            StartButtonBottoms();
            StartButtonBags();
            StartButtonJewellery();
        }

        private void WhichClick(string lastClick)
        {
            if (lastClick == "buttonBottoms_Click")
            {
                CreateBottoms();
            }
            else if(lastClick== "buttonBags_Click")
            {
                CreateBags();
            }
            else if (lastClick == "buttonTops_Click")
            {
                CreateTops();
            }
            else if (lastClick == "buttonJewellery_Click")
            {
                CreateJewellery();
            }
        }
        private void CreateTops()
        {
            pictureBox7.Visible = true;
            labelprice4.Visible = true;
            pictureBox6.Visible = true;
            labelprice5.Visible = true;
            t1 = new Tops("101", "חולצה בטן פרחונית קשירה", 49.90, Properties.Resources.top52, "בטן");
            startPicBox3(t1);
            labelprice1.Text = t1.GetPrice() + "$";
            t2 = new Tops("102", "חולצה בטן לבנה קצרה", 39.90, Properties.Resources.top41, "בטן");
            startPicBox4(t2);
            labelprice2.Text = t2.GetPrice() + "$";
            t3 = new Tops("103", "גופייה כתף אחת שחורה", 29, Properties.Resources.top31, "גופייה");
            startPicBox5(t3);
            labelprice3.Text = t3.GetPrice() + "$";
            t4 = new Tops("104", "חולצה תחרה ארוכה לבנה", 49.90, Properties.Resources.top22, "חולצה");
            startPicBox7(t4);
            labelprice4.Text = t4.GetPrice() + "$";
            t5 = new Tops("105", "חולצה  קצרה כחולה", 19, Properties.Resources.top11, "חולצה");
            startPicBox6(t5);
            labelprice5.Text = t5.GetPrice() + "$";
            pictureBox8.Visible = false;
            labelprice6.Visible = false;
        }
        private void CreateBottoms()
        {
            pictureBox7.Visible = true;
            labelprice4.Visible = true;
            t1 = new Bottoms("201", "גינס פדלפון", 55.40, Properties.Resources.b2, "מכנס", "ארוך");
            startPicBox3(t1);
            labelprice1.Text = t1.GetPrice() + "$";
            t2 = new Bottoms("202", "פוטר שחור פסים", 25, Properties.Resources.b3, "פוטר", "ארוך");
            startPicBox4(t2);
            labelprice2.Text = t2.GetPrice() + "$";
            t3 = new Bottoms("203", "טייץ חום", 19.90, Properties.Resources.b4, "טייץ", "ארוך");
            startPicBox5(t3);
            labelprice3.Text = t3.GetPrice() + "$";
            t4 = new Bottoms("204", "מכנס קצר חום", 49.90, Properties.Resources.b5, "מכנס", "קצר");
            startPicBox7(t4);
            labelprice4.Text = t4.GetPrice() + "$";
            pictureBox6.Visible = false;
            labelprice5.Visible = false;
            pictureBox8.Visible = false;
            labelprice6.Visible = false;
        }
        private void CreateBags()
        {
            t1 = new Bags("301", "תיק צד קטן ירוק", 45.90, Properties.Resources.bag1, true, "צד", "ירוק");
            startPicBox3(t1);
            labelprice1.Text = t1.GetPrice() + "$";
            t2 = new Bags("302", "תיק צד גדול שחור", 67, Properties.Resources.bag2, true, "צד", "שחור");
            startPicBox4(t2);
            labelprice2.Text = t2.GetPrice() + "$";
            t3 = new Bags("303", "תיק גב בד תכלת לבן", 39.50, Properties.Resources.bag3, false, "גב", "תכלת");
            startPicBox5(t3);
            labelprice3.Text = t3.GetPrice() + "$";
            pictureBox7.Visible = false;
            labelprice4.Visible = false;
            pictureBox6.Visible = false;
            labelprice5.Visible = false;
            pictureBox8.Visible = false;
            labelprice6.Visible = false;
        }
        private void CreateJewellery()
        {
            pictureBox7.Visible = true;
            labelprice4.Visible = true;
            pictureBox6.Visible = true;
            labelprice5.Visible = true;
            pictureBox8.Visible = true;
            labelprice6.Visible = true;
            t1 = new Jewellery("401", "עגילי פנינה זהב", 12.90, Properties.Resources.j1, "עגילים", "זהב");
            startPicBox3(t1);
            labelprice1.Text = t1.GetPrice() + "$";
            t2 = new Jewellery("402", "סט שרשראות כסף", 29, Properties.Resources.j2, "שרשרת", "כסף");
            startPicBox4(t2);
            labelprice2.Text = t2.GetPrice() + "$";
            t3 = new Jewellery("403", "סט טבעות זהב", 9.40, Properties.Resources.j3, "טבעות", "זהב");
            startPicBox5(t3);
            labelprice3.Text = t3.GetPrice() + "$";
            t4 = new Jewellery("404", "סט טבעות כסף", 35, Properties.Resources.j4, "טבעות", "כסף");
            startPicBox7(t4);
            labelprice4.Text = t4.GetPrice() + "$";
            t5 = new Jewellery("405", "סט שרשראות זהב", 22.90, Properties.Resources.j5, "שרשרת", "זהב");
            startPicBox6(t5);
            labelprice5.Text = t5.GetPrice() + "$";
            t6 = new Jewellery("406", "סט עגילי חישוק כסף", 39.50, Properties.Resources.j6, "עגילים", "כסף");
            startPicBox8(t6);
            labelprice6.Text = t6.GetPrice() + "$";
        }
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
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TopsPage_Load(object sender, EventArgs e)
        {

        }
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
        private void startPicBox3(Item t)
        {
            pictureBox3.Image = t.pic;
           
        }

        private void startPicBox4(Item t)
        {
            pictureBox4.Image = t.pic;
        }

        private void startPicBox5(Item t)
        {
            pictureBox5.Image = t.pic;
        }

        private void startPicBox6(Item t)
        {
            pictureBox6.Image = t.pic;
        }

        private void startPicBox7(Item t)
        {
            pictureBox7.Image = t.pic;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t1);
            vi.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Enter enterp = new Enter();
            enterp.Show();
            Visible = false;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t6);
            vi.Show();
            Visible = false;
        }

        private void startPicBox8(Item t)
        {
            pictureBox8.Image = t.pic;
        }
        private void buttonTops_Click_1(object sender, EventArgs e)
        {
            CreateTops();
        }
        private void buttonBottoms_Click(object sender, EventArgs e)
        {
            CreateBottoms();
        }

        private void buttonBags_Click(object sender, EventArgs e)
        {
            CreateBags();
        }

        private void buttonJewellery_Click(object sender, EventArgs e)
        {
            CreateJewellery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelprice3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t2);
            vi.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t3);
            vi.Show();
            Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t4);
            vi.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ViewItems vi = new ViewItems(t5);
            vi.Show();
            Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ShoppingCart sc = new ShoppingCart();
            sc.Show();
            Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Enter enter = new Enter();
            enter.Show();
            Visible = false;
        }
    }
}
