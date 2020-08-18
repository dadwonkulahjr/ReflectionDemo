namespace ReflectionDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnDiscoverTypeInfo = new System.Windows.Forms.Button();
            this.lbMethods = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProperties = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name:";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(108, 24);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(442, 20);
            this.txtTypeName.TabIndex = 1;
            // 
            // btnDiscoverTypeInfo
            // 
            this.btnDiscoverTypeInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscoverTypeInfo.Location = new System.Drawing.Point(565, 17);
            this.btnDiscoverTypeInfo.Name = "btnDiscoverTypeInfo";
            this.btnDiscoverTypeInfo.Size = new System.Drawing.Size(259, 32);
            this.btnDiscoverTypeInfo.TabIndex = 2;
            this.btnDiscoverTypeInfo.Text = "Discover Type Information";
            this.btnDiscoverTypeInfo.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInfo.Click += new System.EventHandler(this.BtnDiscoverTypeInfo_Click);
            // 
            // lbMethods
            // 
            this.lbMethods.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMethods.FormattingEnabled = true;
            this.lbMethods.ItemHeight = 20;
            this.lbMethods.Location = new System.Drawing.Point(15, 87);
            this.lbMethods.Name = "lbMethods";
            this.lbMethods.Size = new System.Drawing.Size(353, 444);
            this.lbMethods.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Methods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Properties";
            // 
            // lbProperties
            // 
            this.lbProperties.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProperties.FormattingEnabled = true;
            this.lbProperties.ItemHeight = 20;
            this.lbProperties.Location = new System.Drawing.Point(374, 87);
            this.lbProperties.Name = "lbProperties";
            this.lbProperties.Size = new System.Drawing.Size(289, 444);
            this.lbProperties.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(773, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Constructors";
            // 
            // lbConstructors
            // 
            this.lbConstructors.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConstructors.FormattingEnabled = true;
            this.lbConstructors.ItemHeight = 20;
            this.lbConstructors.Location = new System.Drawing.Point(682, 87);
            this.lbConstructors.Name = "lbConstructors";
            this.lbConstructors.Size = new System.Drawing.Size(315, 444);
            this.lbConstructors.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbConstructors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMethods);
            this.Controls.Add(this.btnDiscoverTypeInfo);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Refelection Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnDiscoverTypeInfo;
        private System.Windows.Forms.ListBox lbMethods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbConstructors;
    }
}

