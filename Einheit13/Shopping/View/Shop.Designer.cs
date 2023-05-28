namespace Einheit13.Shopping.View
{
    partial class Shop
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
            ClbProducts=new CheckedListBox();
            BtnAdd=new Button();
            LbProductsInBasket=new ListBox();
            SuspendLayout();
            // 
            // ClbProducts
            // 
            ClbProducts.FormattingEnabled=true;
            ClbProducts.Location=new Point(42, 28);
            ClbProducts.Name="ClbProducts";
            ClbProducts.Size=new Size(524, 144);
            ClbProducts.TabIndex=0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location=new Point(609, 28);
            BtnAdd.Name="BtnAdd";
            BtnAdd.Size=new Size(159, 144);
            BtnAdd.TabIndex=2;
            BtnAdd.Text="Hinzufügen";
            BtnAdd.UseVisualStyleBackColor=false;
            BtnAdd.Click+=ClickOnBtnAdd;
            // 
            // LbProductsInBasket
            // 
            LbProductsInBasket.FormattingEnabled=true;
            LbProductsInBasket.ItemHeight=25;
            LbProductsInBasket.Location=new Point(42, 235);
            LbProductsInBasket.Name="LbProductsInBasket";
            LbProductsInBasket.Size=new Size(516, 229);
            LbProductsInBasket.TabIndex=3;
            // 
            // Shop
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 642);
            Controls.Add(LbProductsInBasket);
            Controls.Add(BtnAdd);
            Controls.Add(ClbProducts);
            Name="Shop";
            Text="Shop";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox ClbProducts;
        private ListView LvProductsInBasket;
        private Button BtnAdd;
        private ListBox LbProductsInBasket;
    }
}