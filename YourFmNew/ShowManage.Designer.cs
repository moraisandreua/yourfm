
namespace YourFmNew
{
    partial class ShowManage
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programTitleTxt = new System.Windows.Forms.TextBox();
            this.programDescTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.programSaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.label5 = new System.Windows.Forms.Label();
            this.episodioInicioTxt = new DarkUI.Controls.DarkTextBox();
            this.episodioFimTxt = new DarkUI.Controls.DarkTextBox();
            this.episodioFotoTxt = new DarkUI.Controls.DarkTextBox();
            this.episodioNomeTxt = new DarkUI.Controls.DarkTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.programFotoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cria o teu programa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(20, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // programTitleTxt
            // 
            this.programTitleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.programTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programTitleTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programTitleTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.programTitleTxt.Location = new System.Drawing.Point(165, 84);
            this.programTitleTxt.Name = "programTitleTxt";
            this.programTitleTxt.PlaceholderText = "Titulo";
            this.programTitleTxt.Size = new System.Drawing.Size(508, 43);
            this.programTitleTxt.TabIndex = 4;
            // 
            // programDescTxt
            // 
            this.programDescTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.programDescTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programDescTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programDescTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.programDescTxt.Location = new System.Drawing.Point(165, 133);
            this.programDescTxt.Multiline = true;
            this.programDescTxt.Name = "programDescTxt";
            this.programDescTxt.PlaceholderText = "Descrição";
            this.programDescTxt.Size = new System.Drawing.Size(508, 71);
            this.programDescTxt.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(20, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 120);
            this.panel1.TabIndex = 6;
            // 
            // programSaveBtn
            // 
            this.programSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.programSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programSaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.programSaveBtn.Location = new System.Drawing.Point(881, 20);
            this.programSaveBtn.Name = "programSaveBtn";
            this.programSaveBtn.Size = new System.Drawing.Size(166, 48);
            this.programSaveBtn.TabIndex = 7;
            this.programSaveBtn.Text = "Guardar";
            this.programSaveBtn.UseVisualStyleBackColor = true;
            this.programSaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adicionar episódio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(32, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(32, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fim:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(20, 630);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(214, 64);
            this.darkButton1.TabIndex = 15;
            this.darkButton1.Text = "Adicionar Episódio";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(32, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Foto:";
            // 
            // episodioInicioTxt
            // 
            this.episodioInicioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.episodioInicioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.episodioInicioTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.episodioInicioTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.episodioInicioTxt.Location = new System.Drawing.Point(134, 459);
            this.episodioInicioTxt.Name = "episodioInicioTxt";
            this.episodioInicioTxt.PlaceholderText = "0000-00-00 00:00:00";
            this.episodioInicioTxt.Size = new System.Drawing.Size(271, 39);
            this.episodioInicioTxt.TabIndex = 17;
            // 
            // episodioFimTxt
            // 
            this.episodioFimTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.episodioFimTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.episodioFimTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.episodioFimTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.episodioFimTxt.Location = new System.Drawing.Point(134, 506);
            this.episodioFimTxt.Name = "episodioFimTxt";
            this.episodioFimTxt.PlaceholderText = "0000-00-00 00:00:00";
            this.episodioFimTxt.Size = new System.Drawing.Size(271, 39);
            this.episodioFimTxt.TabIndex = 18;
            // 
            // episodioFotoTxt
            // 
            this.episodioFotoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.episodioFotoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.episodioFotoTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.episodioFotoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.episodioFotoTxt.Location = new System.Drawing.Point(134, 553);
            this.episodioFotoTxt.Name = "episodioFotoTxt";
            this.episodioFotoTxt.PlaceholderText = "http://";
            this.episodioFotoTxt.Size = new System.Drawing.Size(271, 39);
            this.episodioFotoTxt.TabIndex = 19;
            // 
            // episodioNomeTxt
            // 
            this.episodioNomeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.episodioNomeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.episodioNomeTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.episodioNomeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.episodioNomeTxt.Location = new System.Drawing.Point(134, 412);
            this.episodioNomeTxt.Name = "episodioNomeTxt";
            this.episodioNomeTxt.PlaceholderText = "Ep. 1";
            this.episodioNomeTxt.Size = new System.Drawing.Size(271, 39);
            this.episodioNomeTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(32, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nome:";
            // 
            // programFotoTxt
            // 
            this.programFotoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.programFotoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programFotoTxt.Location = new System.Drawing.Point(20, 180);
            this.programFotoTxt.Name = "programFotoTxt";
            this.programFotoTxt.PlaceholderText = "url";
            this.programFotoTxt.Size = new System.Drawing.Size(120, 24);
            this.programFotoTxt.TabIndex = 22;
            // 
            // ShowManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.programFotoTxt);
            this.Controls.Add(this.episodioNomeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.episodioFotoTxt);
            this.Controls.Add(this.episodioFimTxt);
            this.Controls.Add(this.episodioInicioTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programSaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.programDescTxt);
            this.Controls.Add(this.programTitleTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowManage";
            this.Size = new System.Drawing.Size(1073, 753);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox programTitleTxt;
        private System.Windows.Forms.TextBox programDescTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button programSaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkTextBox episodioInicioTxt;
        private System.Windows.Forms.Label label5;
        private DarkUI.Controls.DarkTextBox episodioFotoTxt;
        private DarkUI.Controls.DarkTextBox episodioFimTxt;
        private DarkUI.Controls.DarkTextBox episodioNomeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox programFotoTxt;
    }
}
