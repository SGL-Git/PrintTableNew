namespace PrintTableNew
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
            this.btnGroupes = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDebitors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnBarCodeScaner = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGroupes
            // 
            this.btnGroupes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupes.Location = new System.Drawing.Point(38, 37);
            this.btnGroupes.Name = "btnGroupes";
            this.btnGroupes.Size = new System.Drawing.Size(133, 59);
            this.btnGroupes.TabIndex = 0;
            this.btnGroupes.Text = "PRINT\r\nGROUPES";
            this.btnGroupes.UseVisualStyleBackColor = false;
            this.btnGroupes.Click += new System.EventHandler(this.btnGroupes_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(198, 37);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(148, 59);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "PRINT\r\nPRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnDebitors
            // 
            this.btnDebitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDebitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebitors.Location = new System.Drawing.Point(38, 118);
            this.btnDebitors.Name = "btnDebitors";
            this.btnDebitors.Size = new System.Drawing.Size(133, 59);
            this.btnDebitors.TabIndex = 2;
            this.btnDebitors.Text = "PRINT\r\nDEBITORS";
            this.btnDebitors.UseVisualStyleBackColor = false;
            this.btnDebitors.Click += new System.EventHandler(this.btnDebitors_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Fuchsia;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(198, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(198, 118);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(148, 59);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "PRINT\r\nSUPPLIERS";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnBarCodeScaner
            // 
            this.btnBarCodeScaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBarCodeScaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarCodeScaner.Location = new System.Drawing.Point(373, 37);
            this.btnBarCodeScaner.Name = "btnBarCodeScaner";
            this.btnBarCodeScaner.Size = new System.Drawing.Size(118, 59);
            this.btnBarCodeScaner.TabIndex = 5;
            this.btnBarCodeScaner.Text = "ENTER  PRODUCT\r\nWITH  BAR CODE\r\nSCANER";
            this.btnBarCodeScaner.UseVisualStyleBackColor = false;
            this.btnBarCodeScaner.Click += new System.EventHandler(this.btnBarCodeScaner_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(373, 118);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(118, 59);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "STOCK";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(540, 354);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBarCodeScaner);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDebitors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnGroupes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroupes;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDebitors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnBarCodeScaner;
        private System.Windows.Forms.Button btnStock;
    }
}

