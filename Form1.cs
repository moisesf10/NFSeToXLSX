using DocumentFormat.OpenXml;
using System.Globalization;

namespace NFSeToXLSX
{
	public partial class Form1 : Form
	{
		//private Label labelStatus;
		private string path = null;
		private string extension;
		private DateTime? inicioEmissao = null;
		private DateTime? fimEmissao = null;
		private DateTime? inicioCompetencia = null;
		private DateTime? fimCompetencia = null;


		public Form1()
		{
			InitializeComponent();
		}

		private void buttonConverter_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxFile.Text))
			{
				MessageBox.Show("O arquivo xml ou zip não foi carregado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			List<string> errorMessages = new List<string>();

			var validateInicioEmissao = validateDate(mkTextBoxInicioEmissao.Text);
			var validateFimEmissao = validateDate(mkTextBoxFimEmissao.Text);
			var validateInicioCompetencia = validateCompetencia(mkTextBoxInicioCompetencia.Text);
			var validateFimCompetencia = validateCompetencia(mkTextBoxFimCompetencia.Text);


			if (!validateInicioEmissao.Item1)
			{
				errorMessages.Add("O valor informado para a data inicial de emissão é inválida");
			}
			else
			{
				inicioEmissao = validateInicioEmissao.Item2 ?? null;
			}

			if (!validateFimEmissao.Item1)
			{
				errorMessages.Add("O valor informado para a data final de emissão é inválida");
			}
			else
			{
				fimEmissao = validateFimEmissao.Item2 ?? null;
			}


			if (!validateInicioCompetencia.Item1)
			{
				errorMessages.Add("O valor informado para o início da competência é inválido");
			}
			else
			{
				inicioCompetencia = validateInicioCompetencia.Item2 ?? null;
			}

			if (!validateFimCompetencia.Item1)
			{
				errorMessages.Add("O valor informado para o fim da competência é inválido");
			}
			else
			{
				fimCompetencia = validateFimCompetencia.Item2 ?? null;
			}

			if (errorMessages.Count > 0)
			{

			}

			if (errorMessages.Count > 0)
			{
				string messages = string.Join("\r\n", errorMessages);
				MessageBox.Show(messages, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var excel = new Excel();
			switch (extension)
			{
				case ".xml":
					ImportXml importerXml = new ImportXml();
					var row = importerXml.readFile(path);
					excel.genereteHeader(row);
					excel.addRow(row);
					break;
				case ".zip":
					ImportZip importerZip = new ImportZip();
					importerZip.loadFile(path);
					var i = 0;
					foreach(var dictionary in importerZip.readFiles())
					{
						
						if (i == 0)
						{
							excel.genereteHeader(dictionary);
						}
						if(inicioEmissao != null && fimEmissao != null)
						{
							// Especifica o formato da data e hora
							string format = "dd/MM/yyyy HH:mm:ss";
							// Converte a string para DateTime usando ParseExact
							DateTime dateValue = DateTime.ParseExact(dictionary["DtEmissao"], format, CultureInfo.InvariantCulture);
							if(dateValue < inicioEmissao.Value || dateValue > fimEmissao.Value)
							{
								continue;
							}
						}

						if(inicioCompetencia != null && fimCompetencia != null)
						{
							string format = "dd/MM/yyyy";
							// Converte a string para DateTime usando ParseExact
							DateTime dateValue = DateTime.ParseExact(dictionary["Competencia"], format, CultureInfo.InvariantCulture);
							if (dateValue < inicioCompetencia.Value || dateValue > fimCompetencia.Value)
							{
								continue;
							}
						}

						excel.addRow(dictionary);
						i++;
					}
					importerZip.dispose();
					break;
			}
			
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.RestoreDirectory = true;
			saveFileDialog1.Filter = "Excel|*.xlsx|Todos|*.*";
			saveFileDialog1.Title = "Salvar Arquivo";

			string? pathFile = null;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pathFile = saveFileDialog1.FileName;

				try
				{
					excel.save(pathFile);
					MessageBox.Show("O arquivo foi convertido com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex) {
					MessageBox.Show("ERRO: O arquivo não foi convertido \r\n" + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				
				excel.dispose();
			}



		}


		private void textBoxFile_Click(object sender, EventArgs e)
		{
			chooseFile();
		}

		private void buttonCarregar_Click(object sender, EventArgs e)
		{
			chooseFile();
		}

		private void chooseFile()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "ZIP Files (*.zip)|*.zip|XML Files (*.xml)|*.xml|Todos (*.*)|*.*",
				Title = "Selecione um XML ou Arquivo ZIP"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				string ext = Path.GetExtension(filePath).ToLower();

				path = filePath + '.' + extension;
				extension = ext;

				textBoxFile.Text = path;

			}
		}

		

		private (bool, DateTime?) validateDate(string date)
		{
			
			if (String.IsNullOrEmpty(date.Replace("/", "").Trim()))
			{
				return (true, null);
			}

			try
			{
				DateTime newDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
				return (true, newDate);
			}
			catch (Exception ex) { }

			return (false, null);
		}

		private (bool, DateTime?) validateCompetencia(string competencia)
		{

			if (String.IsNullOrEmpty(competencia.Replace("/", "").Trim()))
			{
				return (true, null);
			}

			try
			{

				DateTime newDate = DateTime.ParseExact(competencia, "MM/yyyy", CultureInfo.InvariantCulture);
				return (true, newDate);
			}
			catch (Exception ex) { }

			return (false, null);
		}

		
	}
}
