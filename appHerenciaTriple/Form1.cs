using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appHerenciaTriple
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalcularDistancia_Click(object sender, EventArgs e)
    {
      Punto3D a = new Punto3D ();
      a.X = Int32.Parse(txtX1.Text);
      a.Y = Int32.Parse(txtY1.Text);
      a.Z = Int32.Parse(txtZ1.Text);

      Punto3D b = new Punto3D();
      b.X = Int32.Parse(txtX2.Text);
      b.Y = Int32.Parse(txtY2.Text);
      b.Z = Int32.Parse(txtZ2.Text);

      double distancia = a.CalcularDistancia(b);

      MessageBox.Show("LA dist es " + distancia);

    }
  }
}
