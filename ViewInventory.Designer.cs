
namespace InventoryApp
{
    partial class ViewInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PartIDInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ViewInventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityinStock = new System.Windows.Forms.Label();
            this.labe11 = new System.Windows.Forms.Label();
            this.OrderStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewInventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Location = new System.Drawing.Point(0, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(28, 13);
            this.time.TabIndex = 17;
            this.time.Text = "date";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PartID";
            // 
            // PartIDInput
            // 
            this.PartIDInput.Location = new System.Drawing.Point(47, 33);
            this.PartIDInput.Name = "PartIDInput";
            this.PartIDInput.Size = new System.Drawing.Size(100, 20);
            this.PartIDInput.TabIndex = 19;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(173, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewInventoryDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewInventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewInventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewInventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewInventoryDataGrid.Location = new System.Drawing.Point(6, 101);
            this.ViewInventoryDataGrid.Name = "ViewInventoryDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewInventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewInventoryDataGrid.Size = new System.Drawing.Size(638, 150);
            this.ViewInventoryDataGrid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity";
            // 
            // QuantityinStock
            // 
            this.QuantityinStock.AutoSize = true;
            this.QuantityinStock.Location = new System.Drawing.Point(556, 301);
            this.QuantityinStock.Name = "QuantityinStock";
            this.QuantityinStock.Size = new System.Drawing.Size(46, 13);
            this.QuantityinStock.TabIndex = 23;
            this.QuantityinStock.Text = "Quantity";
            // 
            // labe11
            // 
            this.labe11.AutoSize = true;
            this.labe11.Location = new System.Drawing.Point(464, 358);
            this.labe11.Name = "labe11";
            this.labe11.Size = new System.Drawing.Size(63, 13);
            this.labe11.TabIndex = 24;
            this.labe11.Text = "OrderStatus";
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSize = true;
            this.OrderStatus.Location = new System.Drawing.Point(556, 358);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(35, 13);
            this.OrderStatus.TabIndex = 25;
            this.OrderStatus.Text = "label3";
            // 
            // ViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 376);
            this.Controls.Add(this.OrderStatus);
            this.Controls.Add(this.labe11);
            this.Controls.Add(this.QuantityinStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewInventoryDataGrid);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PartIDInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.MaximumSize = new System.Drawing.Size(667, 415);
            this.MinimumSize = new System.Drawing.Size(667, 415);
            this.Name = "ViewInventory";
            this.Text = "ViewInventory";
            this.Load += new System.EventHandler(this.ViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewInventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PartIDInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ViewInventoryDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuantityinStock;
        private System.Windows.Forms.Label labe11;
        private System.Windows.Forms.Label OrderStatus;
    }
}