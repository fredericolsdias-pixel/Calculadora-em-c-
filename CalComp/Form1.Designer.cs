namespace CalComp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btn4 = new Button();
			btn5 = new Button();
			btn6 = new Button();
			btn7 = new Button();
			btn8 = new Button();
			btn9 = new Button();
			btn0 = new Button();
			btnMenos = new Button();
			btnMais = new Button();
			btnMult = new Button();
			btnIgual = new Button();
			txtTela = new TextBox();
			btnDiv = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			btn1.Location = new Point(310, 285);
			btn1.Name = "btn1";
			btn1.Size = new Size(94, 29);
			btn1.TabIndex = 0;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += Numero_Click;
			// 
			// button2
			// 
			btn2.Location = new Point(210, 250);
			btn2.Name = "btn2";
			btn2.Size = new Size(94, 29);
			btn2.TabIndex = 1;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += Numero_Click;
			// 
			// button3
			// 
			btn3.Location = new Point(310, 250);
			btn3.Name = "btn3";
			btn3.Size = new Size(94, 29);
			btn3.TabIndex = 2;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += Numero_Click;
			// 
			// button4
			// 
			btn4.Location = new Point(210, 215);
			btn4.Name = "btn4";
			btn4.Size = new Size(94, 29);
			btn4.TabIndex = 3;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += Numero_Click;
			// 
			// button5
			// 
			btn5.Location = new Point(310, 215);
			btn5.Name = "btn5";
			btn5.Size = new Size(94, 29);
			btn5.TabIndex = 4;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += Numero_Click;
			// 
			// button6
			// 
			btn6.Location = new Point(210, 180);
			btn6.Name = "btn6";
			btn6.Size = new Size(94, 29);
			btn6.TabIndex = 5;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += Numero_Click;
			// 
			// button7
			// 
			btn7.Location = new Point(310, 180);
			btn7.Name = "btn7";
			btn7.Size = new Size(94, 29);
			btn7.TabIndex = 6;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += Numero_Click;
			// 
			// button8
			// 
			btn8.Location = new Point(210, 145);
			btn8.Name = "btn8";
			btn8.Size = new Size(94, 29);
			btn8.TabIndex = 7;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += Numero_Click;
			// 
			// button9
			// 
			btn9.Location = new Point(310, 145);
			btn9.Name = "btn9";
			btn9.Size = new Size(94, 29);
			btn9.TabIndex = 8;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += Numero_Click;
			// 
			// button10
			// 
			btn0.Location = new Point(210, 285);
			btn0.Name = "btn0";
			btn0.Size = new Size(94, 29);
			btn0.TabIndex = 9;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += Numero_Click;
			// 
			// btnMenos
			// 
			btnMenos.Location = new Point(410, 145);
			btnMenos.Name = "btnMenos";
			btnMenos.Size = new Size(94, 29);
			btnMenos.TabIndex = 10;
			btnMenos.Text = "-";
			btnMenos.UseVisualStyleBackColor = true;
			btnMenos.Click += Operacao_Click;
			// 
			// btnMais
			// 
			btnMais.Location = new Point(410, 180);
			btnMais.Name = "btnMais";
			btnMais.Size = new Size(94, 29);
			btnMais.TabIndex = 11;
			btnMais.Text = "+";
			btnMais.UseVisualStyleBackColor = true;
			btnMais.Click += Operacao_Click;
			// 
			// btnMult
			// 
			btnMult.Location = new Point(410, 250);
			btnMult.Name = "btnMult";
			btnMult.Size = new Size(94, 29);
			btnMult.TabIndex = 13;
			btnMult.Text = "*";
			btnMult.UseVisualStyleBackColor = true;
			btnMult.Click += Operacao_Click;
			// 
			// btnIgual
			// 
			btnIgual.Location = new Point(410, 285);
			btnIgual.Name = "btnIgual";
			btnIgual.Size = new Size(94, 29);
			btnIgual.TabIndex = 14;
			btnIgual.Text = "=";
			btnIgual.UseVisualStyleBackColor = true;
			btnIgual.Click += btnIgual_Click;
			// 
			// txtTela
			// 
			txtTela.Location = new Point(210, 112);
			txtTela.Name = "txtTela";
			txtTela.Size = new Size(294, 27);
			txtTela.TabIndex = 15;
			// 
			// btnDiv
			// 
			btnDiv.Location = new Point(410, 215);
			btnDiv.Name = "btnDiv";
			btnDiv.Size = new Size(94, 29);
			btnDiv.TabIndex = 16;
			btnDiv.Text = "/";
			btnDiv.UseVisualStyleBackColor = true;
			btnDiv.Click += Operacao_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnDiv);
			Controls.Add(txtTela);
			Controls.Add(btnIgual);
			Controls.Add(btnMult);
			Controls.Add(btnMais);
			Controls.Add(btnMenos);
			Controls.Add(btn0);
			Controls.Add(btn9);
			Controls.Add(btn8);
			Controls.Add(btn7);
			Controls.Add(btn6);
			Controls.Add(btn5);
			Controls.Add(btn4);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Button btn4;
		private Button btn5;
		private Button btn6;
		private Button btn7;
		private Button btn8;
		private Button btn9;
		private Button btn0;
		private Button btnMenos;
		private Button btnMais;
		private Button button13;
		private Button btnMult;
		private Button btnIgual;
		private TextBox txtTela;
		private Button btnDiv;
	}
}
