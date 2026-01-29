namespace Kronometre_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelKronometre = new System.Windows.Forms.Label();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonBekle = new System.Windows.Forms.Button();
            this.buttonTekrar = new System.Windows.Forms.Button();
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.listBoxKayitlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelKronometre
            // 
            this.labelKronometre.AutoSize = true;
            this.labelKronometre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKronometre.Location = new System.Drawing.Point(31, 28);
            this.labelKronometre.Name = "labelKronometre";
            this.labelKronometre.Size = new System.Drawing.Size(626, 91);
            this.labelKronometre.TabIndex = 0;
            this.labelKronometre.Text = "00:00:00:00:000";
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.Color.Lime;
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(12, 146);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(137, 106);
            this.buttonBasla.TabIndex = 1;
            this.buttonBasla.Text = "Başlat";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonBekle
            // 
            this.buttonBekle.BackColor = System.Drawing.Color.Yellow;
            this.buttonBekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBekle.Location = new System.Drawing.Point(187, 146);
            this.buttonBekle.Name = "buttonBekle";
            this.buttonBekle.Size = new System.Drawing.Size(137, 106);
            this.buttonBekle.TabIndex = 2;
            this.buttonBekle.Text = "Bekle";
            this.buttonBekle.UseVisualStyleBackColor = false;
            this.buttonBekle.Click += new System.EventHandler(this.buttonBekle_Click);
            // 
            // buttonTekrar
            // 
            this.buttonTekrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrar.Location = new System.Drawing.Point(369, 146);
            this.buttonTekrar.Name = "buttonTekrar";
            this.buttonTekrar.Size = new System.Drawing.Size(137, 106);
            this.buttonTekrar.TabIndex = 3;
            this.buttonTekrar.Text = "Tekrar";
            this.buttonTekrar.UseVisualStyleBackColor = false;
            this.buttonTekrar.Click += new System.EventHandler(this.buttonTekrar_Click);
            // 
            // timerKronometre
            // 
            this.timerKronometre.Enabled = true;
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Orchid;
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(551, 146);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(137, 106);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // listBoxKayitlar
            // 
            this.listBoxKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxKayitlar.FormattingEnabled = true;
            this.listBoxKayitlar.ItemHeight = 38;
            this.listBoxKayitlar.Location = new System.Drawing.Point(12, 276);
            this.listBoxKayitlar.Name = "listBoxKayitlar";
            this.listBoxKayitlar.Size = new System.Drawing.Size(676, 118);
            this.listBoxKayitlar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxKayitlar);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonTekrar);
            this.Controls.Add(this.buttonBekle);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelKronometre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKronometre;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonBekle;
        private System.Windows.Forms.Button buttonTekrar;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ListBox listBoxKayitlar;
    }
}

