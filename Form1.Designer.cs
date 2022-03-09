
namespace CodeGenerator
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaSenhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_gerar = new System.Windows.Forms.Button();
            this.check_maiusculas = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.check_algarismos = new System.Windows.Forms.CheckBox();
            this.check_simbolos = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Select = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaSenhas
            // 
            this.ListaSenhas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ListaSenhas.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaSenhas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListaSenhas.FormattingEnabled = true;
            this.ListaSenhas.ItemHeight = 27;
            this.ListaSenhas.Location = new System.Drawing.Point(22, 36);
            this.ListaSenhas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaSenhas.Name = "ListaSenhas";
            this.ListaSenhas.Size = new System.Drawing.Size(277, 517);
            this.ListaSenhas.TabIndex = 0;
            this.ListaSenhas.SelectedIndexChanged += new System.EventHandler(this.ListaSenhas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de Caracteres";
            // 
            // cmd_gerar
            // 
            this.cmd_gerar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmd_gerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmd_gerar.Location = new System.Drawing.Point(309, 510);
            this.cmd_gerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_gerar.Name = "cmd_gerar";
            this.cmd_gerar.Size = new System.Drawing.Size(272, 52);
            this.cmd_gerar.TabIndex = 2;
            this.cmd_gerar.Text = "GERAR CODIGO";
            this.cmd_gerar.UseVisualStyleBackColor = false;
            this.cmd_gerar.Click += new System.EventHandler(this.cmd_gerar_Click);
            // 
            // check_maiusculas
            // 
            this.check_maiusculas.AutoSize = true;
            this.check_maiusculas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_maiusculas.Location = new System.Drawing.Point(309, 102);
            this.check_maiusculas.Margin = new System.Windows.Forms.Padding(4);
            this.check_maiusculas.Name = "check_maiusculas";
            this.check_maiusculas.Size = new System.Drawing.Size(142, 27);
            this.check_maiusculas.TabIndex = 3;
            this.check_maiusculas.Text = "MAIUSCULAS";
            this.check_maiusculas.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(309, 70);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 31);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // check_algarismos
            // 
            this.check_algarismos.AutoSize = true;
            this.check_algarismos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_algarismos.Location = new System.Drawing.Point(309, 130);
            this.check_algarismos.Margin = new System.Windows.Forms.Padding(4);
            this.check_algarismos.Name = "check_algarismos";
            this.check_algarismos.Size = new System.Drawing.Size(142, 27);
            this.check_algarismos.TabIndex = 3;
            this.check_algarismos.Text = "ALGARISMOS";
            this.check_algarismos.UseVisualStyleBackColor = true;
            // 
            // check_simbolos
            // 
            this.check_simbolos.AutoSize = true;
            this.check_simbolos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_simbolos.Location = new System.Drawing.Point(309, 159);
            this.check_simbolos.Margin = new System.Windows.Forms.Padding(4);
            this.check_simbolos.Name = "check_simbolos";
            this.check_simbolos.Size = new System.Drawing.Size(120, 27);
            this.check_simbolos.TabIndex = 3;
            this.check_simbolos.Text = "SIMBOLOS";
            this.check_simbolos.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // txt_Select
            // 
            this.txt_Select.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Select.Location = new System.Drawing.Point(309, 462);
            this.txt_Select.Name = "txt_Select";
            this.txt_Select.Size = new System.Drawing.Size(272, 43);
            this.txt_Select.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha Selecionada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Select);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.check_simbolos);
            this.Controls.Add(this.check_algarismos);
            this.Controls.Add(this.check_maiusculas);
            this.Controls.Add(this.cmd_gerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaSenhas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_gerar;
        private System.Windows.Forms.CheckBox check_maiusculas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox check_algarismos;
        private System.Windows.Forms.CheckBox check_simbolos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Select;
        private System.Windows.Forms.Label label2;
    }
}

