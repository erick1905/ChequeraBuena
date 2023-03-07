using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChequeraBuena
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizadesing();
        }
        private void customizadesing()
        {
            panelMediaSubmenu.Visible = false;
            PanelConsulta.Visible = false;
            panelcrearcheque.Visible = false;
            Panelcancela.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
        }
        private void hidecrear()
        {
            if (panelcrearcheque.Visible == true)
            {
                panelcrearcheque.Visible = false;
            }
        }
        private void hidecancela()
        {
            if (Panelcancela.Visible == true)
            {
                Panelcancela.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void Btnmenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelcrearcheque);
            hidesubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(Panelcancela);
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        private void oculta()
        {
            Form f = new Form1();
            f.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelConsulta);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidecrear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hidecancela();
        }
    }
}
