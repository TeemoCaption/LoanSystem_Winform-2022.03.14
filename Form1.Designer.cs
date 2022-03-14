
namespace Ch02_Winform
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxyear = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.miniprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款本息金額每月攤還試算表";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxprice
            // 
            this.tbxprice.Location = new System.Drawing.Point(232, 112);
            this.tbxprice.Name = "tbxprice";
            this.tbxprice.Size = new System.Drawing.Size(159, 22);
            this.tbxprice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "請輸入金額：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(63, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "請輸入年數：";
            // 
            // tbxyear
            // 
            this.tbxyear.Location = new System.Drawing.Point(232, 171);
            this.tbxyear.Name = "tbxyear";
            this.tbxyear.Size = new System.Drawing.Size(159, 22);
            this.tbxyear.TabIndex = 4;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price.Location = new System.Drawing.Point(453, 112);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(139, 27);
            this.price.TabIndex = 5;
            this.price.Text = "1. 貸款金額：";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.percent.Location = new System.Drawing.Point(453, 171);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(127, 27);
            this.percent.TabIndex = 6;
            this.percent.Text = "２. 年利率：";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year.Location = new System.Drawing.Point(465, 226);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(97, 27);
            this.year.TabIndex = 7;
            this.year.Text = "3. 年數：";
            // 
            // miniprice
            // 
            this.miniprice.AutoSize = true;
            this.miniprice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.miniprice.Location = new System.Drawing.Point(432, 275);
            this.miniprice.Name = "miniprice";
            this.miniprice.Size = new System.Drawing.Size(181, 27);
            this.miniprice.TabIndex = 8;
            this.miniprice.Text = "4. 每月應還本息：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(149, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tip.ForeColor = System.Drawing.Color.Red;
            this.tip.Location = new System.Drawing.Point(94, 265);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(0, 27);
            this.tip.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(63, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "請輸入年利率：";
            // 
            // tbxpercent
            // 
            this.tbxpercent.Location = new System.Drawing.Point(232, 218);
            this.tbxpercent.Name = "tbxpercent";
            this.tbxpercent.Size = new System.Drawing.Size(159, 22);
            this.tbxpercent.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxpercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.miniprice);
            this.Controls.Add(this.year);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.price);
            this.Controls.Add(this.tbxyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxprice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxyear;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label miniprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxpercent;
    }
}

