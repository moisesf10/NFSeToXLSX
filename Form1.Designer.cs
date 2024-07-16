namespace NFSeToXLSX
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
			label1 = new Label();
			panel1 = new Panel();
			mkTextBoxFimCompetencia = new MaskedTextBox();
			mkTextBoxInicioCompetencia = new MaskedTextBox();
			label4 = new Label();
			mkTextBoxFimEmissao = new MaskedTextBox();
			mkTextBoxInicioEmissao = new MaskedTextBox();
			label5 = new Label();
			Até = new Label();
			label3 = new Label();
			buttonCarregar = new Button();
			buttonConverter = new Button();
			textBoxFile = new TextBox();
			label2 = new Label();
			panel2 = new Panel();
			label6 = new Label();
			labelStatus = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 22F);
			label1.Location = new Point(155, 19);
			label1.Name = "label1";
			label1.Size = new Size(431, 50);
			label1.TabIndex = 0;
			label1.Text = "NFS-e To XLSX Converter";
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(mkTextBoxFimCompetencia);
			panel1.Controls.Add(mkTextBoxInicioCompetencia);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(mkTextBoxFimEmissao);
			panel1.Controls.Add(mkTextBoxInicioEmissao);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(Até);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(buttonCarregar);
			panel1.Controls.Add(buttonConverter);
			panel1.Controls.Add(textBoxFile);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(12, 178);
			panel1.Name = "panel1";
			panel1.Size = new Size(776, 277);
			panel1.TabIndex = 1;
			// 
			// mkTextBoxFimCompetencia
			// 
			mkTextBoxFimCompetencia.BorderStyle = BorderStyle.FixedSingle;
			mkTextBoxFimCompetencia.Location = new Point(267, 158);
			mkTextBoxFimCompetencia.Mask = "00/0000";
			mkTextBoxFimCompetencia.Name = "mkTextBoxFimCompetencia";
			mkTextBoxFimCompetencia.Size = new Size(204, 27);
			mkTextBoxFimCompetencia.TabIndex = 25;
			// 
			// mkTextBoxInicioCompetencia
			// 
			mkTextBoxInicioCompetencia.BorderStyle = BorderStyle.FixedSingle;
			mkTextBoxInicioCompetencia.Location = new Point(15, 158);
			mkTextBoxInicioCompetencia.Mask = "00/0000";
			mkTextBoxInicioCompetencia.Name = "mkTextBoxInicioCompetencia";
			mkTextBoxInicioCompetencia.Size = new Size(195, 27);
			mkTextBoxInicioCompetencia.TabIndex = 24;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(267, 135);
			label4.Name = "label4";
			label4.Size = new Size(32, 20);
			label4.TabIndex = 23;
			label4.Text = "Até";
			// 
			// mkTextBoxFimEmissao
			// 
			mkTextBoxFimEmissao.BorderStyle = BorderStyle.FixedSingle;
			mkTextBoxFimEmissao.Location = new Point(267, 96);
			mkTextBoxFimEmissao.Mask = "00/00/0000";
			mkTextBoxFimEmissao.Name = "mkTextBoxFimEmissao";
			mkTextBoxFimEmissao.Size = new Size(204, 27);
			mkTextBoxFimEmissao.TabIndex = 22;
			mkTextBoxFimEmissao.ValidatingType = typeof(DateTime);
			// 
			// mkTextBoxInicioEmissao
			// 
			mkTextBoxInicioEmissao.BorderStyle = BorderStyle.FixedSingle;
			mkTextBoxInicioEmissao.Location = new Point(15, 96);
			mkTextBoxInicioEmissao.Mask = "00/00/0000";
			mkTextBoxInicioEmissao.Name = "mkTextBoxInicioEmissao";
			mkTextBoxInicioEmissao.Size = new Size(195, 27);
			mkTextBoxInicioEmissao.TabIndex = 21;
			mkTextBoxInicioEmissao.ValidatingType = typeof(DateTime);
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(15, 135);
			label5.Name = "label5";
			label5.Size = new Size(97, 20);
			label5.TabIndex = 20;
			label5.Text = "Competência";
			// 
			// Até
			// 
			Até.AutoSize = true;
			Até.Location = new Point(267, 73);
			Até.Name = "Até";
			Até.Size = new Size(32, 20);
			Até.TabIndex = 19;
			Até.Text = "Até";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 73);
			label3.Name = "label3";
			label3.Size = new Size(88, 20);
			label3.TabIndex = 18;
			label3.Text = "Emissão em";
			// 
			// buttonCarregar
			// 
			buttonCarregar.Location = new Point(547, 36);
			buttonCarregar.Name = "buttonCarregar";
			buttonCarregar.Size = new Size(144, 29);
			buttonCarregar.TabIndex = 17;
			buttonCarregar.Text = "Carregar Arquivo";
			buttonCarregar.UseVisualStyleBackColor = true;
			buttonCarregar.Click += buttonCarregar_Click;
			// 
			// buttonConverter
			// 
			buttonConverter.Location = new Point(15, 210);
			buttonConverter.Name = "buttonConverter";
			buttonConverter.Size = new Size(128, 36);
			buttonConverter.TabIndex = 16;
			buttonConverter.Text = "Converter";
			buttonConverter.UseVisualStyleBackColor = true;
			buttonConverter.Click += buttonConverter_Click;
			// 
			// textBoxFile
			// 
			textBoxFile.BorderStyle = BorderStyle.FixedSingle;
			textBoxFile.Location = new Point(15, 38);
			textBoxFile.Name = "textBoxFile";
			textBoxFile.Size = new Size(538, 27);
			textBoxFile.TabIndex = 15;
			textBoxFile.Click += textBoxFile_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 15);
			label2.Name = "label2";
			label2.Size = new Size(225, 20);
			label2.TabIndex = 14;
			label2.Text = "Selecione um arquivo zip ou xml";
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Info;
			panel2.Controls.Add(label6);
			panel2.Location = new Point(12, 81);
			panel2.Name = "panel2";
			panel2.Size = new Size(776, 82);
			panel2.TabIndex = 2;
			// 
			// label6
			// 
			label6.Location = new Point(16, 13);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(738, 53);
			label6.TabIndex = 27;
			label6.Text = "Utilize o formulário abaixo para importar um arquivo XML de uma nota fiscal, ou um arquivo zip contendo o XML de várias notas fiscais";
			label6.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelStatus
			// 
			labelStatus.Dock = DockStyle.Bottom;
			labelStatus.Location = new Point(0, 594);
			labelStatus.Name = "labelStatus";
			labelStatus.Padding = new Padding(4, 0, 0, 0);
			labelStatus.Size = new Size(1108, 20);
			labelStatus.TabIndex = 3;
			labelStatus.Text = "labelStatus";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1108, 614);
			Controls.Add(labelStatus);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "NFS-e To XLSX Converter";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private MaskedTextBox mkTextBoxFimCompetencia;
		private MaskedTextBox mkTextBoxInicioCompetencia;
		private Label label4;
		private MaskedTextBox mkTextBoxFimEmissao;
		private MaskedTextBox mkTextBoxInicioEmissao;
		private Label label5;
		private Label Até;
		private Label label3;
		private Button buttonCarregar;
		private Button buttonConverter;
		private TextBox textBoxFile;
		private Label label2;
		private Panel panel2;
		private Label label6;
		private Label labelStatus;
	}
}
