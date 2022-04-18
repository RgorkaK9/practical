
namespace Численные_методы_Задание_2_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghfd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.y,
            this.xy,
            this.xx,
            this.y2,
            this.ghfd,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 436);
            this.dataGridView1.TabIndex = 3;
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "An";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // xy
            // 
            this.xy.HeaderText = "Cn";
            this.xy.MinimumWidth = 6;
            this.xy.Name = "xy";
            this.xy.Width = 125;
            // 
            // xx
            // 
            this.xx.HeaderText = "Bn";
            this.xx.MinimumWidth = 6;
            this.xx.Name = "xx";
            this.xx.Width = 125;
            // 
            // y2
            // 
            this.y2.HeaderText = "f(a)";
            this.y2.MinimumWidth = 6;
            this.y2.Name = "y2";
            this.y2.Width = 125;
            // 
            // ghfd
            // 
            this.ghfd.HeaderText = "f(c)";
            this.ghfd.MinimumWidth = 6;
            this.ghfd.Name = "ghfd";
            this.ghfd.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "f(b)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Бамз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy;
        private System.Windows.Forms.DataGridViewTextBoxColumn xx;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghfd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

