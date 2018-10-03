using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4
{
  public partial class Form1 : Form
  {


    int pirmasSk;
    int antrasSk;
    string operacija;
    int MemoryDabar;
    int MemoryRezultatas;
    

    public Form1()
    {
      InitializeComponent();
    }


    private void spaudziam(string skaicius)
    {
      if (txtbx_skaiciai.Text == "0")

        txtbx_skaiciai.Text = skaicius;

      else

        txtbx_skaiciai.Text += skaicius;
    }

    private void veiksmas(string veiksmas)
    {
      pirmasSk = Convert.ToInt32((txtbx_skaiciai.Text));
      operacija = veiksmas;
      txtbx_skaiciai.Text = "0";
      
    }

    private void BTN_1_Click(object sender, EventArgs e)
    {
      spaudziam("1");
    }

    private void BTN_2_Click(object sender, EventArgs e)
    {
      spaudziam("2");
    }

    private void BTN_3_Click(object sender, EventArgs e)
    {
      spaudziam("3");
    }

    private void BTN_4_Click(object sender, EventArgs e)
    {
      spaudziam("4");
    }

    private void BTN_5_Click(object sender, EventArgs e)
    {
      spaudziam("5");
    }

    private void BTN_6_Click(object sender, EventArgs e)
    {
      spaudziam("6");
    }

    private void BTN_7_Click(object sender, EventArgs e)
    {
      spaudziam("7");
    }

    private void BTN_8_Click(object sender, EventArgs e)
    {
      spaudziam("8");
    }

    private void BTN_9_Click(object sender, EventArgs e)
    {
      spaudziam("9");
    }

    private void BTN_0_Click(object sender, EventArgs e)
    {
      spaudziam("0");
    }

    private void BTN_plius_Click(object sender, EventArgs e)
    {
      veiksmas("+");
    }

    private void BTN_minus_Click(object sender, EventArgs e)
    {
      veiksmas("-");
    }

    private void BTN_daugyba_Click(object sender, EventArgs e)
    {
      veiksmas("*");
    }

    private void BTN_dalyba_Click(object sender, EventArgs e)
    {
      veiksmas("/");
    }

    private void BTN_saknis_Click(object sender, EventArgs e)
    {
      veiksmas("saknis");
    }

    private void BTN_laipsniu_Click(object sender, EventArgs e)
    {
      veiksmas("^");
    }

    private void BTN_clear_Click(object sender, EventArgs e)
    {
      txtbx_skaiciai.Text = "0";
      pirmasSk = 0;
      antrasSk = 0;
    }

    private void BTN_lygu_Click(object sender, EventArgs e)
    {
      antrasSk = Convert.ToInt32(txtbx_skaiciai.Text);
      if(operacija == "+") txtbx_skaiciai.Text = (pirmasSk + antrasSk).ToString();
      else if (operacija == "-") txtbx_skaiciai.Text = (pirmasSk - antrasSk).ToString();
      else if (operacija == "*") txtbx_skaiciai.Text = (pirmasSk * antrasSk).ToString();
      else if (operacija == "/")
      {
        if (antrasSk != 0)
        {
          txtbx_skaiciai.Text = (pirmasSk / antrasSk).ToString();
        }
        else
        {
          MessageBox.Show("Negalima dalinti iš 0");
        }
      }
      else if (operacija == "^") txtbx_skaiciai.Text = Math.Pow(pirmasSk, antrasSk).ToString();
      else if (operacija == "saknis") txtbx_skaiciai.Text = Math.Pow(pirmasSk, 1 / antrasSk).ToString();
      listBox1.Items.Add(pirmasSk + operacija + antrasSk + "=" + txtbx_skaiciai.Text);
    }

    private void BNT_MC_Click(object sender, EventArgs e)
    {
      MemoryDabar = 0;
      MemoryRezultatas = 0;
    }

    private void BTN_MR_Click(object sender, EventArgs e)
    {
      txtbx_skaiciai.Text = MemoryRezultatas.ToString();
    }

    private void BTN_Mplius_Click(object sender, EventArgs e)
    {
      MemoryRezultatas += Convert.ToInt32(txtbx_skaiciai.Text);
      txtbx_skaiciai.Text = "0";
    }

    private void BTN_Mminus_Click(object sender, EventArgs e)
    {
      MemoryRezultatas -= Convert.ToInt32(txtbx_skaiciai.Text);
      txtbx_skaiciai.Text = "0";
    }

    private void BTN_MS_Click(object sender, EventArgs e)
    {
      MemoryDabar = Convert.ToInt32(txtbx_skaiciai.Text);
      txtbx_skaiciai.Text = "0";
    }
  }
}
