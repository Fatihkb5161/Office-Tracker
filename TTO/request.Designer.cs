namespace TTO
{
    partial class request
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.deny_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finish_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deny_button
            // 
            this.deny_button.BackColor = System.Drawing.Color.Crimson;
            this.deny_button.FlatAppearance.BorderSize = 0;
            this.deny_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deny_button.Location = new System.Drawing.Point(174, 268);
            this.deny_button.Name = "deny_button";
            this.deny_button.Size = new System.Drawing.Size(89, 40);
            this.deny_button.TabIndex = 20;
            this.deny_button.Text = "Reddet";
            this.deny_button.UseVisualStyleBackColor = false;
            this.deny_button.Click += new System.EventHandler(this.deny_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.accept_button.FlatAppearance.BorderSize = 0;
            this.accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept_button.Location = new System.Drawing.Point(51, 268);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(89, 40);
            this.accept_button.TabIndex = 19;
            this.accept_button.Text = "Onayla";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(13, 231);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(63, 16);
            this.description.TabIndex = 18;
            this.description.Text = "Açıklama";
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ayrılma Sebebi";
            // 
            // finish_time
            // 
            this.finish_time.AutoSize = true;
            this.finish_time.Location = new System.Drawing.Point(13, 180);
            this.finish_time.Name = "finish_time";
            this.finish_time.Size = new System.Drawing.Size(103, 16);
            this.finish_time.TabIndex = 16;
            this.finish_time.Text = "25.03.2025 12.00";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Location = new System.Drawing.Point(13, 127);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(103, 16);
            this.start_time.TabIndex = 15;
            this.start_time.Text = "25.03.2025 12.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bitiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Başlangıç";
            // 
            // user_position
            // 
            this.user_position.AutoSize = true;
            this.user_position.Location = new System.Drawing.Point(13, 44);
            this.user_position.Name = "user_position";
            this.user_position.Size = new System.Drawing.Size(49, 16);
            this.user_position.TabIndex = 13;
            this.user_position.Text = "Stajyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "İstek Detayları";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(13, 16);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(103, 16);
            this.user_name.TabIndex = 10;
            this.user_name.Text = "Fatih Küçükbıyık";
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.deny_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.finish_time);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_name);
            this.Name = "request";
            this.Size = new System.Drawing.Size(327, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deny_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label description;
        public System.Windows.Forms.Label finish_time;
        public System.Windows.Forms.Label start_time;
        public System.Windows.Forms.Label user_name;
        public System.Windows.Forms.Label user_position;
    }
}
