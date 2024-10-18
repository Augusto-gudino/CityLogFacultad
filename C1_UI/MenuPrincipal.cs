using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1_UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void SubPanelVisible(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void btnBebidasSinAlcohol_Click(object sender, EventArgs e)
        {
            SubPanelVisible(panelSubmenuBebidasSinAlcohol);
        }

        private void btnCervezas_Click(object sender, EventArgs e)
        {
            SubPanelVisible(panelSubmenuCervezas);
        }

        private void btnGolosinas_Click(object sender, EventArgs e)
        {
            SubPanelVisible(panelSubmenuGolosinas);
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            SubPanelVisible(panelSubmenuSnacks);
        }

        private void btnCrearPedidoBebidaSinAlcohol_Click(object sender, EventArgs e)
        {
            panelSubmenuBebidasSinAlcohol.Visible = false; // Oculta el submenu una vez se abre el nuevo panel
            AbrirFormEnPanel(new AgregarPedidoBebidas());
        }

        private void btnConoceNuestrosProveedores_Click(object sender, EventArgs e)
        {
            panelSubmenuBebidasSinAlcohol.Visible = false; 
            AbrirFormEnPanel(new Proveedores());
        }

        private void AbrirFormEnPanel(Form formhija)
        {
            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);

            formhija.TopLevel = false; 
            formhija.Dock = DockStyle.Fill; 
            this.panelContenedorPrincipal.Controls.Add(formhija); 
            this.panelContenedorPrincipal.Tag = formhija; 
            formhija.Show(); 
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la ventana
        }

        private void pictureboxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimiza la ventana
        }
    }


}


