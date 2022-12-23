namespace Cotizador
{
    partial class Form2
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
            this.listaHistorialModal = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaHistorialModal
            // 
            this.listaHistorialModal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listaHistorialModal.FullRowSelect = true;
            this.listaHistorialModal.GridLines = true;
            this.listaHistorialModal.HideSelection = false;
            this.listaHistorialModal.Location = new System.Drawing.Point(12, 67);
            this.listaHistorialModal.MultiSelect = false;
            this.listaHistorialModal.Name = "listaHistorialModal";
            this.listaHistorialModal.Size = new System.Drawing.Size(545, 334);
            this.listaHistorialModal.TabIndex = 18;
            this.listaHistorialModal.UseCompatibleStateImageBehavior = false;
            this.listaHistorialModal.View = System.Windows.Forms.View.List;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Items";
            this.columnHeader2.Width = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "HISTORIAL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaHistorialModal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaHistorialModal;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}