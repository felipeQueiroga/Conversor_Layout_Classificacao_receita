
namespace Converte_SIAxCTBLT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHist = new System.Windows.Forms.TabPage();
            this.dataGridViewHist = new System.Windows.Forms.DataGridView();
            this.tabPageSia = new System.Windows.Forms.TabPage();
            this.dataGridViewSia = new System.Windows.Forms.DataGridView();
            this.tabPageNeA = new System.Windows.Forms.TabPage();
            this.dataGridViewFinal = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHist)).BeginInit();
            this.tabPageSia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSia)).BeginInit();
            this.tabPageNeA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(477, 43);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 24);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar Arquivo ";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonGerar
            // 
            this.buttonGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonGerar.FlatAppearance.BorderSize = 0;
            this.buttonGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGerar.Location = new System.Drawing.Point(118, 441);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(604, 54);
            this.buttonGerar.TabIndex = 1;
            this.buttonGerar.Text = "Carregar e Gerar Layout Final";
            this.buttonGerar.UseVisualStyleBackColor = false;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(60, 25);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(208, 15);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Arquivo de Origem / Diretório Destino";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(60, 43);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(411, 23);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.Text = "C:\\Fiorilli\\ArqIntegração.txt";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHist);
            this.tabControl.Controls.Add(this.tabPageSia);
            this.tabControl.Controls.Add(this.tabPageNeA);
            this.tabControl.Location = new System.Drawing.Point(35, 83);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 352);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageHist
            // 
            this.tabPageHist.Controls.Add(this.dataGridViewHist);
            this.tabPageHist.Location = new System.Drawing.Point(4, 24);
            this.tabPageHist.Name = "tabPageHist";
            this.tabPageHist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHist.Size = new System.Drawing.Size(782, 324);
            this.tabPageHist.TabIndex = 0;
            this.tabPageHist.Text = "Historico";
            this.tabPageHist.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHist
            // 
            this.dataGridViewHist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHist.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewHist.Name = "dataGridViewHist";
            this.dataGridViewHist.RowTemplate.Height = 25;
            this.dataGridViewHist.Size = new System.Drawing.Size(772, 314);
            this.dataGridViewHist.TabIndex = 0;
            // 
            // tabPageSia
            // 
            this.tabPageSia.Controls.Add(this.dataGridViewSia);
            this.tabPageSia.Location = new System.Drawing.Point(4, 24);
            this.tabPageSia.Name = "tabPageSia";
            this.tabPageSia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSia.Size = new System.Drawing.Size(782, 324);
            this.tabPageSia.TabIndex = 1;
            this.tabPageSia.Text = "Arquivo Origem";
            this.tabPageSia.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSia
            // 
            this.dataGridViewSia.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSia.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSia.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewSia.Name = "dataGridViewSia";
            this.dataGridViewSia.RowTemplate.Height = 25;
            this.dataGridViewSia.Size = new System.Drawing.Size(769, 311);
            this.dataGridViewSia.TabIndex = 0;
            // 
            // tabPageNeA
            // 
            this.tabPageNeA.Controls.Add(this.dataGridViewFinal);
            this.tabPageNeA.Location = new System.Drawing.Point(4, 24);
            this.tabPageNeA.Name = "tabPageNeA";
            this.tabPageNeA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNeA.Size = new System.Drawing.Size(782, 324);
            this.tabPageNeA.TabIndex = 2;
            this.tabPageNeA.Text = "ArquivoFinal";
            this.tabPageNeA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFinal
            // 
            this.dataGridViewFinal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinal.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFinal.Name = "dataGridViewFinal";
            this.dataGridViewFinal.RowTemplate.Height = 25;
            this.dataGridViewFinal.Size = new System.Drawing.Size(769, 311);
            this.dataGridViewFinal.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(861, 527);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.buttonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Carrega e transforma CTBLT - Ribas MS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageHist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHist)).EndInit();
            this.tabPageSia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSia)).EndInit();
            this.tabPageNeA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHist;
        private System.Windows.Forms.TabPage tabPageSia;
        private System.Windows.Forms.TabPage tabPageNeA;
        private System.Windows.Forms.DataGridView dataGridViewHist;
        private System.Windows.Forms.DataGridView dataGridViewSia;
        private System.Windows.Forms.DataGridView dataGridViewFinal;
    }
}

