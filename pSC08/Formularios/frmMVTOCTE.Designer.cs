
using System;
using System.Windows.Forms;

namespace pSC08
{
    partial class frmMVTOCTE
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
            this.btnCONFACT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCOL01 = new System.Windows.Forms.Label();
            this.lblCOL02 = new System.Windows.Forms.Label();
            this.lblCOL03 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCONFACT
            // 
            this.btnCONFACT.Location = new System.Drawing.Point(282, 90);
            this.btnCONFACT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCONFACT.Name = "btnCONFACT";
            this.btnCONFACT.Size = new System.Drawing.Size(36, 23);
            this.btnCONFACT.TabIndex = 36;
            this.btnCONFACT.Text = "...";
            this.btnCONFACT.UseVisualStyleBackColor = true;
            this.btnCONFACT.Click += new System.EventHandler(this.btnCONFACT_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = " Cuenta del cliente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 156);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1008, 370);
            this.dgv.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 72);
            this.label1.TabIndex = 29;
            this.label1.Text = " Movimiento de cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::pSC08.Properties.Resources.fileprint;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnImprimir.Location = new System.Drawing.Point(732, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 72);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprime";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::pSC08.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalir.Location = new System.Drawing.Point(924, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 72);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::pSC08.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpiar.Location = new System.Drawing.Point(828, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 72);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::pSC08.Properties.Resources.contents;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBuscar.Location = new System.Drawing.Point(636, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 72);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(174, 91);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(109, 21);
            this.txtCliente.TabIndex = 38;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = " Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(174, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(456, 21);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCOL01
            // 
            this.lblCOL01.BackColor = System.Drawing.Color.LightBlue;
            this.lblCOL01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL01.ForeColor = System.Drawing.Color.Black;
            this.lblCOL01.Location = new System.Drawing.Point(654, 540);
            this.lblCOL01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOL01.Name = "lblCOL01";
            this.lblCOL01.Size = new System.Drawing.Size(168, 21);
            this.lblCOL01.TabIndex = 41;
            this.lblCOL01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCOL02
            // 
            this.lblCOL02.BackColor = System.Drawing.Color.LightBlue;
            this.lblCOL02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL02.ForeColor = System.Drawing.Color.Black;
            this.lblCOL02.Location = new System.Drawing.Point(822, 540);
            this.lblCOL02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOL02.Name = "lblCOL02";
            this.lblCOL02.Size = new System.Drawing.Size(168, 21);
            this.lblCOL02.TabIndex = 42;
            this.lblCOL02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCOL03
            // 
            this.lblCOL03.BackColor = System.Drawing.Color.LightBlue;
            this.lblCOL03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOL03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL03.ForeColor = System.Drawing.Color.Black;
            this.lblCOL03.Location = new System.Drawing.Point(486, 540);
            this.lblCOL03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOL03.Name = "lblCOL03";
            this.lblCOL03.Size = new System.Drawing.Size(168, 21);
            this.lblCOL03.TabIndex = 43;
            this.lblCOL03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMVTOCTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 580);
            this.Controls.Add(this.lblCOL03);
            this.Controls.Add(this.lblCOL02);
            this.Controls.Add(this.lblCOL01);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCONFACT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMVTOCTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMVTOCTE";
            this.Load += new System.EventHandler(this.frmMVTOCTE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMVTOCTE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   
        #endregion

        private System.Windows.Forms.Button btnCONFACT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCOL01;
        private System.Windows.Forms.Label lblCOL02;
        private Label lblCOL03;
    }
}