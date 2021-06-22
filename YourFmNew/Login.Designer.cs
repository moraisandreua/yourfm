
namespace YourFmNew
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.darkComboBox1 = new DarkUI.Controls.DarkComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkButton4 = new DarkUI.Controls.DarkButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "YourFm";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.darkButton2);
            this.panel1.Controls.Add(this.darkButton1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(277, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 413);
            this.panel1.TabIndex = 2;
            // 
            // darkButton2
            // 
            this.darkButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton2.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.darkButton2.Location = new System.Drawing.Point(12, 363);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(476, 34);
            this.darkButton2.TabIndex = 6;
            this.darkButton2.Text = "I don\'t have an account";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // darkButton1
            // 
            this.darkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton1.Location = new System.Drawing.Point(191, 290);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(117, 58);
            this.darkButton1.TabIndex = 5;
            this.darkButton1.Text = "Login";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(12, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.PlaceholderText = "Password";
            this.textBox2.Size = new System.Drawing.Size(476, 38);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Username";
            this.textBox1.Size = new System.Drawing.Size(476, 38);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.darkComboBox1);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.darkButton3);
            this.panel2.Controls.Add(this.darkButton4);
            this.panel2.Location = new System.Drawing.Point(277, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 553);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(12, 383);
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Foto (url)";
            this.textBox8.Size = new System.Drawing.Size(476, 38);
            this.textBox8.TabIndex = 17;
            // 
            // darkComboBox1
            // 
            this.darkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darkComboBox1.FormattingEnabled = true;
            this.darkComboBox1.Items.AddRange(new object[] {
            "Listener",
            "Station",
            "Broadcaster"});
            this.darkComboBox1.Location = new System.Drawing.Point(12, 339);
            this.darkComboBox1.Name = "darkComboBox1";
            this.darkComboBox1.Size = new System.Drawing.Size(476, 46);
            this.darkComboBox1.TabIndex = 16;
            this.darkComboBox1.SelectedIndexChanged += new System.EventHandler(this.darkComboBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(12, 295);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Data Nascimento";
            this.textBox7.Size = new System.Drawing.Size(476, 38);
            this.textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(12, 251);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Nome";
            this.textBox6.Size = new System.Drawing.Size(476, 38);
            this.textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(12, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Email";
            this.textBox5.Size = new System.Drawing.Size(476, 38);
            this.textBox5.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(12, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '•';
            this.textBox3.PlaceholderText = "Password";
            this.textBox3.Size = new System.Drawing.Size(476, 38);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(12, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Username";
            this.textBox4.Size = new System.Drawing.Size(476, 38);
            this.textBox4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(191, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "YourFm";
            // 
            // darkButton3
            // 
            this.darkButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton3.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.darkButton3.Location = new System.Drawing.Point(12, 507);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(476, 34);
            this.darkButton3.TabIndex = 8;
            this.darkButton3.Text = "I already have an account";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // darkButton4
            // 
            this.darkButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton4.Location = new System.Drawing.Point(191, 434);
            this.darkButton4.Name = "darkButton4";
            this.darkButton4.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton4.Size = new System.Drawing.Size(117, 58);
            this.darkButton4.TabIndex = 7;
            this.darkButton4.Text = "Signup";
            this.darkButton4.Click += new System.EventHandler(this.darkButton4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1073, 753);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.Panel panel2;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkButton darkButton4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkComboBox darkComboBox1;
        private System.Windows.Forms.TextBox textBox8;
    }
}
