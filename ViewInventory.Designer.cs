
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PartIDInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ViewInventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityinStock = new System.Windows.Forms.Label();
            this.labe11 = new System.Windows.Forms.Label();
            this.OrderStatus = new System.Windows.Forms.Label();
            this.ViewErrorOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewPartName = new System.Windows.Forms.TextBox();
            this.PartUnit = new System.Windows.Forms.Label();
            this.ViewPartUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewUnitCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewSupplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ViewSupplierID = new System.Windows.Forms.TextBox();
            this.ViewUpdateButton = new System.Windows.Forms.Button();
            this.ViewDeleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewEntryTime = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewInventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ViewInventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewInventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.ViewInventoryDataGrid.Location = new System.Drawing.Point(6, 101);
            this.ViewInventoryDataGrid.Name = "ViewInventoryDataGrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewInventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ViewInventoryDataGrid.Size = new System.Drawing.Size(638, 82);
            this.ViewInventoryDataGrid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity";
            // 
            // QuantityinStock
            // 
            this.QuantityinStock.AutoSize = true;
            this.QuantityinStock.Location = new System.Drawing.Point(559, 325);
            this.QuantityinStock.Name = "QuantityinStock";
            this.QuantityinStock.Size = new System.Drawing.Size(13, 13);
            this.QuantityinStock.TabIndex = 23;
            this.QuantityinStock.Text = "0";
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
            this.OrderStatus.Location = new System.Drawing.Point(561, 358);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(22, 13);
            this.OrderStatus.TabIndex = 25;
            this.OrderStatus.Text = "NA";
            // 
            // ViewErrorOut
            // 
            this.ViewErrorOut.AutoSize = true;
            this.ViewErrorOut.Location = new System.Drawing.Point(323, 70);
            this.ViewErrorOut.Name = "ViewErrorOut";
            this.ViewErrorOut.Size = new System.Drawing.Size(0, 13);
            this.ViewErrorOut.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "PartName";
            // 
            // ViewPartName
            // 
            this.ViewPartName.Location = new System.Drawing.Point(67, 205);
            this.ViewPartName.Name = "ViewPartName";
            this.ViewPartName.Size = new System.Drawing.Size(100, 20);
            this.ViewPartName.TabIndex = 28;
            // 
            // PartUnit
            // 
            this.PartUnit.AutoSize = true;
            this.PartUnit.Location = new System.Drawing.Point(215, 208);
            this.PartUnit.Name = "PartUnit";
            this.PartUnit.Size = new System.Drawing.Size(45, 13);
            this.PartUnit.TabIndex = 29;
            this.PartUnit.Text = "PartUnit";
            // 
            // ViewPartUnit
            // 
            this.ViewPartUnit.Location = new System.Drawing.Point(266, 205);
            this.ViewPartUnit.Name = "ViewPartUnit";
            this.ViewPartUnit.Size = new System.Drawing.Size(100, 20);
            this.ViewPartUnit.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Quantity";
            // 
            // ViewQuantity
            // 
            this.ViewQuantity.Location = new System.Drawing.Point(469, 205);
            this.ViewQuantity.Name = "ViewQuantity";
            this.ViewQuantity.Size = new System.Drawing.Size(100, 20);
            this.ViewQuantity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "UnitCost";
            // 
            // ViewUnitCost
            // 
            this.ViewUnitCost.Location = new System.Drawing.Point(67, 261);
            this.ViewUnitCost.Name = "ViewUnitCost";
            this.ViewUnitCost.Size = new System.Drawing.Size(100, 20);
            this.ViewUnitCost.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Supplier";
            // 
            // ViewSupplier
            // 
            this.ViewSupplier.Location = new System.Drawing.Point(266, 263);
            this.ViewSupplier.Name = "ViewSupplier";
            this.ViewSupplier.Size = new System.Drawing.Size(100, 20);
            this.ViewSupplier.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "SupplierID";
            // 
            // ViewSupplierID
            // 
            this.ViewSupplierID.Location = new System.Drawing.Point(469, 265);
            this.ViewSupplierID.Name = "ViewSupplierID";
            this.ViewSupplierID.Size = new System.Drawing.Size(100, 20);
            this.ViewSupplierID.TabIndex = 38;
            // 
            // ViewUpdateButton
            // 
            this.ViewUpdateButton.Location = new System.Drawing.Point(9, 327);
            this.ViewUpdateButton.Name = "ViewUpdateButton";
            this.ViewUpdateButton.Size = new System.Drawing.Size(61, 23);
            this.ViewUpdateButton.TabIndex = 39;
            this.ViewUpdateButton.Text = "Update";
            this.ViewUpdateButton.UseVisualStyleBackColor = true;
            // 
            // ViewDeleteButton
            // 
            this.ViewDeleteButton.Location = new System.Drawing.Point(106, 327);
            this.ViewDeleteButton.Name = "ViewDeleteButton";
            this.ViewDeleteButton.Size = new System.Drawing.Size(61, 23);
            this.ViewDeleteButton.TabIndex = 40;
            this.ViewDeleteButton.Text = "Delete";
            this.ViewDeleteButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "EntryDate";
            // 
            // ViewEntryTime
            // 
            this.ViewEntryTime.AutoSize = true;
            this.ViewEntryTime.Location = new System.Drawing.Point(296, 325);
            this.ViewEntryTime.Name = "ViewEntryTime";
            this.ViewEntryTime.Size = new System.Drawing.Size(49, 13);
            this.ViewEntryTime.TabIndex = 42;
            this.ViewEntryTime.Text = "00:00:00";
            // 
            // ViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 376);
            this.Controls.Add(this.ViewEntryTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ViewDeleteButton);
            this.Controls.Add(this.ViewUpdateButton);
            this.Controls.Add(this.ViewSupplierID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViewUnitCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewPartUnit);
            this.Controls.Add(this.PartUnit);
            this.Controls.Add(this.ViewPartName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViewErrorOut);
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
        private System.Windows.Forms.Label ViewErrorOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ViewPartName;
        private System.Windows.Forms.Label PartUnit;
        private System.Windows.Forms.TextBox ViewPartUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ViewQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ViewUnitCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ViewSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ViewSupplierID;
        private System.Windows.Forms.Button ViewUpdateButton;
        private System.Windows.Forms.Button ViewDeleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ViewEntryTime;
    }
}