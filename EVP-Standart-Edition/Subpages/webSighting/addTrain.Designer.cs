namespace EVP.Subpages.webSighting
{
	partial class addTrain
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			throughBox = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			toComboBox = new ComboBox();
			label4 = new Label();
			BRBox = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// throughBox
			// 
			throughBox.FormattingEnabled = true;
			throughBox.Location = new Point(3, 107);
			throughBox.Name = "throughBox";
			throughBox.Size = new Size(275, 23);
			throughBox.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 2);
			label1.Name = "label1";
			label1.Size = new Size(272, 27);
			label1.TabIndex = 1;
			label1.Text = "Neue Sichtung Hinzufügen";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 89);
			label2.Name = "label2";
			label2.Size = new Size(129, 15);
			label2.TabIndex = 2;
			label2.Text = "Dieser zug fuhr durch...";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 130);
			label3.Name = "label3";
			label3.Size = new Size(124, 15);
			label3.TabIndex = 4;
			label3.Text = "Dieser zug fuhr nach...";
			// 
			// toComboBox
			// 
			toComboBox.FormattingEnabled = true;
			toComboBox.Location = new Point(3, 148);
			toComboBox.Name = "toComboBox";
			toComboBox.Size = new Size(275, 23);
			toComboBox.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 174);
			label4.Name = "label4";
			label4.Size = new Size(104, 15);
			label4.TabIndex = 6;
			label4.Text = "Die Baureihe war...";
			// 
			// BRBox
			// 
			BRBox.Location = new Point(3, 192);
			BRBox.Name = "BRBox";
			BRBox.Size = new Size(275, 23);
			BRBox.TabIndex = 7;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Location = new Point(631, 8);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 8;
			button1.Text = "Zurück";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// addTrain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button1);
			Controls.Add(BRBox);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(toComboBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(throughBox);
			Name = "addTrain";
			Size = new Size(716, 382);
			Load += addTrain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox throughBox;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox toComboBox;
		private Label label4;
		private TextBox BRBox;
		private Button button1;
	}
}
