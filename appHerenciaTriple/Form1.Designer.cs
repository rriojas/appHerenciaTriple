namespace appHerenciaTriple
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
      this.txtX1 = new System.Windows.Forms.TextBox();
      this.txtY1 = new System.Windows.Forms.TextBox();
      this.txtZ1 = new System.Windows.Forms.TextBox();
      this.txtZ2 = new System.Windows.Forms.TextBox();
      this.txtY2 = new System.Windows.Forms.TextBox();
      this.txtX2 = new System.Windows.Forms.TextBox();
      this.btnCalcularDistancia = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtX1
      // 
      this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtX1.Location = new System.Drawing.Point(42, 82);
      this.txtX1.Name = "txtX1";
      this.txtX1.Size = new System.Drawing.Size(100, 36);
      this.txtX1.TabIndex = 0;
      // 
      // txtY1
      // 
      this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtY1.Location = new System.Drawing.Point(42, 135);
      this.txtY1.Name = "txtY1";
      this.txtY1.Size = new System.Drawing.Size(100, 36);
      this.txtY1.TabIndex = 1;
      // 
      // txtZ1
      // 
      this.txtZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtZ1.Location = new System.Drawing.Point(42, 187);
      this.txtZ1.Name = "txtZ1";
      this.txtZ1.Size = new System.Drawing.Size(100, 36);
      this.txtZ1.TabIndex = 2;
      // 
      // txtZ2
      // 
      this.txtZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtZ2.Location = new System.Drawing.Point(383, 187);
      this.txtZ2.Name = "txtZ2";
      this.txtZ2.Size = new System.Drawing.Size(100, 36);
      this.txtZ2.TabIndex = 5;
      // 
      // txtY2
      // 
      this.txtY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtY2.Location = new System.Drawing.Point(383, 135);
      this.txtY2.Name = "txtY2";
      this.txtY2.Size = new System.Drawing.Size(100, 36);
      this.txtY2.TabIndex = 4;
      // 
      // txtX2
      // 
      this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtX2.Location = new System.Drawing.Point(383, 82);
      this.txtX2.Name = "txtX2";
      this.txtX2.Size = new System.Drawing.Size(100, 36);
      this.txtX2.TabIndex = 3;
      // 
      // btnCalcularDistancia
      // 
      this.btnCalcularDistancia.Location = new System.Drawing.Point(214, 255);
      this.btnCalcularDistancia.Name = "btnCalcularDistancia";
      this.btnCalcularDistancia.Size = new System.Drawing.Size(75, 23);
      this.btnCalcularDistancia.TabIndex = 6;
      this.btnCalcularDistancia.Text = "Calcular";
      this.btnCalcularDistancia.UseVisualStyleBackColor = true;
      this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnCalcularDistancia);
      this.Controls.Add(this.txtZ2);
      this.Controls.Add(this.txtY2);
      this.Controls.Add(this.txtX2);
      this.Controls.Add(this.txtZ1);
      this.Controls.Add(this.txtY1);
      this.Controls.Add(this.txtX1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtX1;
    private System.Windows.Forms.TextBox txtY1;
    private System.Windows.Forms.TextBox txtZ1;
    private System.Windows.Forms.TextBox txtZ2;
    private System.Windows.Forms.TextBox txtY2;
    private System.Windows.Forms.TextBox txtX2;
    private System.Windows.Forms.Button btnCalcularDistancia;
  }
}

