namespace ChequeraBuena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizadesing();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Program.form1.Hide();
            Menu f = new Menu();
            f.Show();
        }
        private void customizadesing()
        {
            PanelRegistro.Visible= false;
        }
        private void hidesubmenu()
        {
            if (PanelRegistro.Visible == true)
            {
                PanelRegistro.Visible = false;
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



        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelRegistro);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
    }
}