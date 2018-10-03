using System;
using System.Windows.Forms;

namespace _5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public static char sifras(char raide, int ROT)
    {
      if (!char.IsLetter(raide)) // jei ne raide, returninam ta, ka padave(nieko nekeiciam)
      {
        return raide;
      }
      char d = char.IsUpper(raide) ? 'A' : 'a';
      return (char)((((raide + ROT) - d) % 26) + d);
    }

    public static string atsifras(string uzsifruotas, int ROT)
    {
      string atsifruotas = "";
      foreach (char raide in uzsifruotas)
      {
        if (!char.IsLetter(raide))
        {
          atsifruotas += raide; // jei ne raide, grazinam ta pati
        }
        else
        {
          atsifruotas += sifras(raide, ROT);
        }
      }
      return atsifruotas;
    }


    public static string Uzsifruojam(string input, int ROT)
    {
      string uzsifruotas = "";
      foreach (char raide in input) {uzsifruotas += sifras(raide, ROT);}
      return uzsifruotas;
    }

    public static string Atsifruojam(string input, int ROT)
    {
      return atsifras(input, 26 - ROT);
    }

    private void BTN_uzsifruoti_Click(object sender, System.EventArgs e)
    {
      var done = Uzsifruojam(TXTBX_nesifruotas.Text, Convert.ToInt32(ROT_metodas.Text));

      DialogResult dialogResult = MessageBox.Show("", "Šifruojam dar kartą?", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        TXTBX_nesifruotas.Text = done;
      }
      else if (dialogResult == DialogResult.No)
      {
        TXTBX_uzsifruotas.Text = done;
        TXTBX_nesifruotas.Text = "";
      }
      
    }

    private void BTN_atsifruoti_Click(object sender, System.EventArgs e)
    {
      var done = Atsifruojam(TXTBX_uzsifruotas.Text, Convert.ToInt32(ROT_metodas.Text));

      DialogResult dialogResult = MessageBox.Show("", "Atšifruojam dar kartą?", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        TXTBX_uzsifruotas.Text = done;
      }
      else if (dialogResult == DialogResult.No)
      {
        TXTBX_uzsifruotas.Text = "";
        TXTBX_nesifruotas.Text = done;
      }
    }
  }
}
