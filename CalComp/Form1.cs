using System.Drawing.Text;

namespace CalComp
{
	public partial class Form1 : Form
	{
		double valorAtual = 0;
		string operacao = "";
		bool novaEntrada = true;
		public Form1()
		{
			InitializeComponent();
		}
// Botão de numeros 

			private void Numero_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			if (novaEntrada)
			{
				txtTela.Text = "";
				novaEntrada = false;
			}

			txtTela.Text += btn.Text;
		}

		// Botao de operacoes

		private void Operacao_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			valorAtual = double.Parse(txtTela.Text);
			operacao = btn.Text;
			novaEntrada = true;
		}

		// Botao de igual
		private void btnIgual_Click(object sender, EventArgs e)
		{
			double valorNovo = double.Parse(txtTela.Text);
			double resultado = 0;
			switch (operacao)
			{
				case "+":
					resultado = valorAtual + valorNovo;
					break;
				case "-":
					resultado = valorAtual - valorNovo;
					break;
				case "*":
					resultado = valorAtual * valorNovo;
					break;
				case "/":
					if (valorNovo != 0)
						resultado = valorAtual / valorNovo;
					else
						MessageBox.Show("Divisão por zero não é permitida.");
					break;
			}
			txtTela.Text = resultado.ToString();
			novaEntrada = true;
		}


		}
	}

