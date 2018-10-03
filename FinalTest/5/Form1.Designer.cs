namespace _5
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TXTBX_nesifruotas = new System.Windows.Forms.TextBox();
      this.TXTBX_uzsifruotas = new System.Windows.Forms.TextBox();
      this.BTN_uzsifruoti = new System.Windows.Forms.Button();
      this.BTN_atsifruoti = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.ROT_metodas = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ROT_metodas)).BeginInit();
      this.SuspendLayout();
      // 
      // TXTBX_nesifruotas
      // 
      this.TXTBX_nesifruotas.Location = new System.Drawing.Point(9, 27);
      this.TXTBX_nesifruotas.Multiline = true;
      this.TXTBX_nesifruotas.Name = "TXTBX_nesifruotas";
      this.TXTBX_nesifruotas.Size = new System.Drawing.Size(451, 58);
      this.TXTBX_nesifruotas.TabIndex = 0;
      // 
      // TXTBX_uzsifruotas
      // 
      this.TXTBX_uzsifruotas.Location = new System.Drawing.Point(9, 247);
      this.TXTBX_uzsifruotas.Multiline = true;
      this.TXTBX_uzsifruotas.Name = "TXTBX_uzsifruotas";
      this.TXTBX_uzsifruotas.Size = new System.Drawing.Size(451, 58);
      this.TXTBX_uzsifruotas.TabIndex = 1;
      // 
      // BTN_uzsifruoti
      // 
      this.BTN_uzsifruoti.Location = new System.Drawing.Point(9, 137);
      this.BTN_uzsifruoti.Name = "BTN_uzsifruoti";
      this.BTN_uzsifruoti.Size = new System.Drawing.Size(126, 38);
      this.BTN_uzsifruoti.TabIndex = 2;
      this.BTN_uzsifruoti.Text = "Užšifruoti";
      this.BTN_uzsifruoti.UseVisualStyleBackColor = true;
      this.BTN_uzsifruoti.Click += new System.EventHandler(this.BTN_uzsifruoti_Click);
      // 
      // BTN_atsifruoti
      // 
      this.BTN_atsifruoti.Location = new System.Drawing.Point(334, 139);
      this.BTN_atsifruoti.Name = "BTN_atsifruoti";
      this.BTN_atsifruoti.Size = new System.Drawing.Size(126, 38);
      this.BTN_atsifruoti.TabIndex = 3;
      this.BTN_atsifruoti.Text = "Atšifruoti";
      this.BTN_atsifruoti.UseVisualStyleBackColor = true;
      this.BTN_atsifruoti.Click += new System.EventHandler(this.BTN_atsifruoti_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(159, 150);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "ROT metodas";
      // 
      // ROT_metodas
      // 
      this.ROT_metodas.Location = new System.Drawing.Point(238, 148);
      this.ROT_metodas.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
      this.ROT_metodas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.ROT_metodas.Name = "ROT_metodas";
      this.ROT_metodas.Size = new System.Drawing.Size(39, 20);
      this.ROT_metodas.TabIndex = 5;
      this.ROT_metodas.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(197, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Nešifruotas";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(197, 231);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Užšifruotas";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(477, 317);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ROT_metodas);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BTN_atsifruoti);
      this.Controls.Add(this.BTN_uzsifruoti);
      this.Controls.Add(this.TXTBX_uzsifruotas);
      this.Controls.Add(this.TXTBX_nesifruotas);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.ROT_metodas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TXTBX_nesifruotas;
    private System.Windows.Forms.TextBox TXTBX_uzsifruotas;
    private System.Windows.Forms.Button BTN_uzsifruoti;
    private System.Windows.Forms.Button BTN_atsifruoti;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown ROT_metodas;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

