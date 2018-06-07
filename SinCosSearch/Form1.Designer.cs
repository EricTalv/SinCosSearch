namespace SinCosSearch
{
    partial class Form1
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
            this.TABSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TATBxCOS = new System.Windows.Forms.TextBox();
            this.SINCOSTANCTG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstPlus = new System.Windows.Forms.Label();
            this.secondPlus = new System.Windows.Forms.Label();
            this.TABTeljed = new System.Windows.Forms.Button();
            this.TABJoonista = new System.Windows.Forms.Button();
            this.ColorL = new System.Windows.Forms.Label();
            this.TABClear = new System.Windows.Forms.Button();
            this.TABColor = new System.Windows.Forms.Button();
            this.TAPBxCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAPBxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // TABSave
            // 
            this.TABSave.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABSave.Location = new System.Drawing.Point(12, 273);
            this.TABSave.Name = "TABSave";
            this.TABSave.Size = new System.Drawing.Size(135, 38);
            this.TABSave.TabIndex = 23;
            this.TABSave.Text = "&Salvesta";
            this.TABSave.UseVisualStyleBackColor = true;
            this.TABSave.Click += new System.EventHandler(this.TABSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TATBxCOS);
            this.groupBox1.Controls.Add(this.SINCOSTANCTG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstPlus);
            this.groupBox1.Controls.Add(this.secondPlus);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 209);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Andmed";
            // 
            // TATBxCOS
            // 
            this.TATBxCOS.Location = new System.Drawing.Point(55, 147);
            this.TATBxCOS.Name = "TATBxCOS";
            this.TATBxCOS.Size = new System.Drawing.Size(42, 29);
            this.TATBxCOS.TabIndex = 12;
            this.TATBxCOS.Text = "0";
            this.TATBxCOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SINCOSTANCTG
            // 
            this.SINCOSTANCTG.Location = new System.Drawing.Point(55, 63);
            this.SINCOSTANCTG.Name = "SINCOSTANCTG";
            this.SINCOSTANCTG.Size = new System.Drawing.Size(42, 29);
            this.SINCOSTANCTG.TabIndex = 6;
            this.SINCOSTANCTG.Text = "0";
            this.SINCOSTANCTG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "SIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "COS:";
            // 
            // firstPlus
            // 
            this.firstPlus.AutoSize = true;
            this.firstPlus.Location = new System.Drawing.Point(21, 66);
            this.firstPlus.Name = "firstPlus";
            this.firstPlus.Size = new System.Drawing.Size(20, 22);
            this.firstPlus.TabIndex = 15;
            this.firstPlus.Text = "+";
            this.firstPlus.Click += new System.EventHandler(this.TALPlusMinus_Click);
            // 
            // secondPlus
            // 
            this.secondPlus.AutoSize = true;
            this.secondPlus.Location = new System.Drawing.Point(21, 150);
            this.secondPlus.Name = "secondPlus";
            this.secondPlus.Size = new System.Drawing.Size(20, 22);
            this.secondPlus.TabIndex = 16;
            this.secondPlus.Text = "+";
            this.secondPlus.Click += new System.EventHandler(this.TALPlusMinus_Click);
            // 
            // TABTeljed
            // 
            this.TABTeljed.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABTeljed.Location = new System.Drawing.Point(12, 352);
            this.TABTeljed.Name = "TABTeljed";
            this.TABTeljed.Size = new System.Drawing.Size(135, 63);
            this.TABTeljed.TabIndex = 25;
            this.TABTeljed.Text = "Lisa Teljed";
            this.TABTeljed.UseVisualStyleBackColor = true;
            this.TABTeljed.Click += new System.EventHandler(this.TABTeljed_Click);
            // 
            // TABJoonista
            // 
            this.TABJoonista.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABJoonista.Location = new System.Drawing.Point(12, 229);
            this.TABJoonista.Name = "TABJoonista";
            this.TABJoonista.Size = new System.Drawing.Size(135, 38);
            this.TABJoonista.TabIndex = 24;
            this.TABJoonista.Text = "Joonista";
            this.TABJoonista.UseVisualStyleBackColor = true;
            this.TABJoonista.Click += new System.EventHandler(this.TABJoonista_Click);
            // 
            // ColorL
            // 
            this.ColorL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColorL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorL.Location = new System.Drawing.Point(116, 424);
            this.ColorL.Name = "ColorL";
            this.ColorL.Size = new System.Drawing.Size(31, 69);
            this.ColorL.TabIndex = 22;
            // 
            // TABClear
            // 
            this.TABClear.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABClear.Location = new System.Drawing.Point(12, 512);
            this.TABClear.Name = "TABClear";
            this.TABClear.Size = new System.Drawing.Size(713, 47);
            this.TABClear.TabIndex = 20;
            this.TABClear.Text = "Puhasta";
            this.TABClear.UseVisualStyleBackColor = true;
            this.TABClear.Click += new System.EventHandler(this.TABClear_Click);
            // 
            // TABColor
            // 
            this.TABColor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABColor.Location = new System.Drawing.Point(12, 421);
            this.TABColor.Name = "TABColor";
            this.TABColor.Size = new System.Drawing.Size(97, 69);
            this.TABColor.TabIndex = 21;
            this.TABColor.Text = "Vali Värv";
            this.TABColor.UseVisualStyleBackColor = true;
            this.TABColor.Click += new System.EventHandler(this.TABColor_Click);
            // 
            // TAPBxCanvas
            // 
            this.TAPBxCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TAPBxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAPBxCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TAPBxCanvas.Location = new System.Drawing.Point(153, 12);
            this.TAPBxCanvas.Name = "TAPBxCanvas";
            this.TAPBxCanvas.Size = new System.Drawing.Size(572, 494);
            this.TAPBxCanvas.TabIndex = 19;
            this.TAPBxCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(742, 572);
            this.Controls.Add(this.TABSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TABTeljed);
            this.Controls.Add(this.TABJoonista);
            this.Controls.Add(this.ColorL);
            this.Controls.Add(this.TABClear);
            this.Controls.Add(this.TABColor);
            this.Controls.Add(this.TAPBxCanvas);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sin Cos Research";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAPBxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TABSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TATBxCOS;
        private System.Windows.Forms.TextBox SINCOSTANCTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstPlus;
        private System.Windows.Forms.Label secondPlus;
        private System.Windows.Forms.Button TABTeljed;
        private System.Windows.Forms.Button TABJoonista;
        private System.Windows.Forms.Label ColorL;
        private System.Windows.Forms.Button TABClear;
        private System.Windows.Forms.Button TABColor;
        private System.Windows.Forms.PictureBox TAPBxCanvas;
    }
}

