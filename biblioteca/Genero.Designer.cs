
namespace biblioteca
{
    partial class Genero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            this.label1 = new System.Windows.Forms.Label();
            this.terror = new System.Windows.Forms.Button();
            this.accion = new System.Windows.Forms.Button();
            this.infantil = new System.Windows.Forms.Button();
            this.atras_gen = new System.Windows.Forms.Button();
            this.atras1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generos";
            // 
            // terror
            // 
            this.terror.BackColor = System.Drawing.Color.Red;
            this.terror.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terror.ForeColor = System.Drawing.Color.Black;
            this.terror.Location = new System.Drawing.Point(12, 231);
            this.terror.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.terror.Name = "terror";
            this.terror.Size = new System.Drawing.Size(236, 85);
            this.terror.TabIndex = 1;
            this.terror.Text = "Terror";
            this.terror.UseVisualStyleBackColor = false;
            this.terror.Click += new System.EventHandler(this.terror_Click);
            // 
            // accion
            // 
            this.accion.BackColor = System.Drawing.Color.Red;
            this.accion.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion.Location = new System.Drawing.Point(275, 231);
            this.accion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(236, 88);
            this.accion.TabIndex = 2;
            this.accion.Text = "Accion";
            this.accion.UseVisualStyleBackColor = false;
            this.accion.Click += new System.EventHandler(this.button2_Click);
            // 
            // infantil
            // 
            this.infantil.BackColor = System.Drawing.Color.Red;
            this.infantil.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infantil.Location = new System.Drawing.Point(530, 231);
            this.infantil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infantil.Name = "infantil";
            this.infantil.Size = new System.Drawing.Size(236, 88);
            this.infantil.TabIndex = 3;
            this.infantil.Text = "Infantil";
            this.infantil.UseVisualStyleBackColor = false;
            this.infantil.Click += new System.EventHandler(this.infantil_Click);
            // 
            // atras_gen
            // 
            this.atras_gen.Location = new System.Drawing.Point(55, 496);
            this.atras_gen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.atras_gen.Name = "atras_gen";
            this.atras_gen.Size = new System.Drawing.Size(107, 43);
            this.atras_gen.TabIndex = 4;
            this.atras_gen.Text = "atras";
            this.atras_gen.UseVisualStyleBackColor = true;
            // 
            // atras1
            // 
            this.atras1.BackColor = System.Drawing.Color.Red;
            this.atras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras1.Location = new System.Drawing.Point(25, 361);
            this.atras1.Name = "atras1";
            this.atras1.Size = new System.Drawing.Size(92, 49);
            this.atras1.TabIndex = 26;
            this.atras1.Text = "atras";
            this.atras1.UseVisualStyleBackColor = false;
            this.atras1.Click += new System.EventHandler(this.atras1_Click);
            // 
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.atras1);
            this.Controls.Add(this.atras_gen);
            this.Controls.Add(this.infantil);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.terror);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Genero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button terror;
        private System.Windows.Forms.Button accion;
        private System.Windows.Forms.Button infantil;
        private System.Windows.Forms.Button atras_gen;
        private System.Windows.Forms.Button atras1;
    }
}