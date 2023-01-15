using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;

namespace Car_Management_System
{
    public partial class Dashboard : KryptonForm
    {

        private IconButton activeButton;
        private Panel btnBorder;
        private Form activeForm;
        private static Color myColor = Color.FromArgb(0, 0, 0);
        public Dashboard()
        {
            InitializeComponent();
            btnBorder = new Panel();
            btnBorder.Size = new Size(7, 60);
            pnlMenu.Controls.Add(btnBorder);
        }

        public void activateButton(object activeBtn, Color color)
        {
            if(activeBtn != null)
            {
                DisableButton();

                activeButton = (IconButton)activeBtn;
                activeButton.BackColor = Color.FromArgb(224, 226, 226);
                activeButton.ForeColor = color;
                activeButton.TextAlign = ContentAlignment.MiddleCenter;
                activeButton.IconColor = color;
                activeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                activeButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                btnBorder.BackColor = color;
                btnBorder.Location = new Point(0, activeButton.Location.Y);
                btnBorder.Visible = true;
                btnBorder.BringToFront();
                //Current Child Form IconiconCurrentChildForm
                childFormIcon.IconChar = activeButton.IconChar;
                childFormIcon.IconColor = color;
                childFormLabel.Text = activeButton.Text;
            }
        }

        public void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(250, 252, 252);
                activeButton.ForeColor = Color.FromArgb(64, 64, 64);
                activeButton.TextAlign = ContentAlignment.MiddleLeft;
                activeButton.IconColor = myColor;
                activeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                activeButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(224, 226, 226);
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void Lunar_Garage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            activateButton(sender, myColor);
            OpenChildForm(new DashboardForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            activateButton(sender, myColor);
            OpenChildForm(new CarForm());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            activateButton(sender, myColor);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            activateButton(sender, myColor);

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activateButton(sender, myColor);

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
