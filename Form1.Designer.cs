
namespace BasicCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsToButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.Number0Button = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number7Button = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.AcceptsReturn = true;
            this.UserInputText.AcceptsTab = true;
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UserInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInputText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserInputText.Location = new System.Drawing.Point(-2, -2);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(802, 26);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Location = new System.Drawing.Point(-2, 27);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(802, 71);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            this.CalculationResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPannel
            // 
            this.ButtonsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPannel.ColumnCount = 4;
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.Controls.Add(this.EqualsToButton, 3, 4);
            this.ButtonsPannel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPannel.Controls.Add(this.Number0Button, 1, 4);
            this.ButtonsPannel.Controls.Add(this.PlusMinusButton, 0, 4);
            this.ButtonsPannel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPannel.Controls.Add(this.Number3Button, 2, 3);
            this.ButtonsPannel.Controls.Add(this.Number2Button, 1, 3);
            this.ButtonsPannel.Controls.Add(this.Number1Button, 0, 3);
            this.ButtonsPannel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPannel.Controls.Add(this.Number6Button, 2, 2);
            this.ButtonsPannel.Controls.Add(this.Number5Button, 1, 2);
            this.ButtonsPannel.Controls.Add(this.Number4Button, 0, 2);
            this.ButtonsPannel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonsPannel.Controls.Add(this.Number9Button, 2, 1);
            this.ButtonsPannel.Controls.Add(this.Number8Button, 1, 1);
            this.ButtonsPannel.Controls.Add(this.Number7Button, 0, 1);
            this.ButtonsPannel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPannel.Controls.Add(this.DeleteButton, 2, 0);
            this.ButtonsPannel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPannel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPannel.Location = new System.Drawing.Point(2, 98);
            this.ButtonsPannel.Name = "ButtonsPannel";
            this.ButtonsPannel.RowCount = 5;
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.Size = new System.Drawing.Size(798, 703);
            this.ButtonsPannel.TabIndex = 2;
            // 
            // EqualsToButton
            // 
            this.EqualsToButton.AllowDrop = true;
            this.EqualsToButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsToButton.Location = new System.Drawing.Point(600, 563);
            this.EqualsToButton.Name = "EqualsToButton";
            this.EqualsToButton.Size = new System.Drawing.Size(195, 137);
            this.EqualsToButton.TabIndex = 19;
            this.EqualsToButton.Text = "=";
            this.EqualsToButton.UseVisualStyleBackColor = true;
            this.EqualsToButton.Click += new System.EventHandler(this.EqualsToButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(401, 563);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(193, 137);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // Number0Button
            // 
            this.Number0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number0Button.Location = new System.Drawing.Point(202, 563);
            this.Number0Button.Name = "Number0Button";
            this.Number0Button.Size = new System.Drawing.Size(193, 137);
            this.Number0Button.TabIndex = 17;
            this.Number0Button.Text = "0";
            this.Number0Button.UseVisualStyleBackColor = true;
            this.Number0Button.Click += new System.EventHandler(this.Number0Button_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 563);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(193, 137);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(600, 423);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(195, 134);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // Number3Button
            // 
            this.Number3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number3Button.Location = new System.Drawing.Point(401, 423);
            this.Number3Button.Name = "Number3Button";
            this.Number3Button.Size = new System.Drawing.Size(193, 134);
            this.Number3Button.TabIndex = 14;
            this.Number3Button.Text = "3";
            this.Number3Button.UseVisualStyleBackColor = true;
            this.Number3Button.Click += new System.EventHandler(this.Number3Button_Click);
            // 
            // Number2Button
            // 
            this.Number2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number2Button.Location = new System.Drawing.Point(202, 423);
            this.Number2Button.Name = "Number2Button";
            this.Number2Button.Size = new System.Drawing.Size(193, 134);
            this.Number2Button.TabIndex = 13;
            this.Number2Button.Text = "2";
            this.Number2Button.UseVisualStyleBackColor = true;
            this.Number2Button.Click += new System.EventHandler(this.Number2Button_Click);
            // 
            // Number1Button
            // 
            this.Number1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number1Button.Location = new System.Drawing.Point(3, 423);
            this.Number1Button.Name = "Number1Button";
            this.Number1Button.Size = new System.Drawing.Size(193, 134);
            this.Number1Button.TabIndex = 12;
            this.Number1Button.Text = "1";
            this.Number1Button.UseVisualStyleBackColor = true;
            this.Number1Button.Click += new System.EventHandler(this.Number1Button_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(600, 283);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(195, 134);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "_";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Number6Button
            // 
            this.Number6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number6Button.Location = new System.Drawing.Point(401, 283);
            this.Number6Button.Name = "Number6Button";
            this.Number6Button.Size = new System.Drawing.Size(193, 134);
            this.Number6Button.TabIndex = 10;
            this.Number6Button.Text = "6";
            this.Number6Button.UseVisualStyleBackColor = true;
            this.Number6Button.Click += new System.EventHandler(this.Number6Button_Click);
            // 
            // Number5Button
            // 
            this.Number5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number5Button.Location = new System.Drawing.Point(202, 283);
            this.Number5Button.Name = "Number5Button";
            this.Number5Button.Size = new System.Drawing.Size(193, 134);
            this.Number5Button.TabIndex = 9;
            this.Number5Button.Text = "5";
            this.Number5Button.UseVisualStyleBackColor = true;
            this.Number5Button.Click += new System.EventHandler(this.Number5Button_Click);
            // 
            // Number4Button
            // 
            this.Number4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number4Button.Location = new System.Drawing.Point(3, 283);
            this.Number4Button.Name = "Number4Button";
            this.Number4Button.Size = new System.Drawing.Size(193, 134);
            this.Number4Button.TabIndex = 8;
            this.Number4Button.Text = "4";
            this.Number4Button.UseVisualStyleBackColor = true;
            this.Number4Button.Click += new System.EventHandler(this.Number4Button_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Location = new System.Drawing.Point(600, 143);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(195, 134);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // Number9Button
            // 
            this.Number9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number9Button.Location = new System.Drawing.Point(401, 143);
            this.Number9Button.Name = "Number9Button";
            this.Number9Button.Size = new System.Drawing.Size(193, 134);
            this.Number9Button.TabIndex = 6;
            this.Number9Button.Text = "9";
            this.Number9Button.UseVisualStyleBackColor = true;
            this.Number9Button.Click += new System.EventHandler(this.Number9Button_Click);
            // 
            // Number8Button
            // 
            this.Number8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number8Button.Location = new System.Drawing.Point(202, 143);
            this.Number8Button.Name = "Number8Button";
            this.Number8Button.Size = new System.Drawing.Size(193, 134);
            this.Number8Button.TabIndex = 5;
            this.Number8Button.Text = "8";
            this.Number8Button.UseVisualStyleBackColor = true;
            this.Number8Button.Click += new System.EventHandler(this.Number8Button_Click);
            // 
            // Number7Button
            // 
            this.Number7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number7Button.Location = new System.Drawing.Point(3, 143);
            this.Number7Button.Name = "Number7Button";
            this.Number7Button.Size = new System.Drawing.Size(193, 134);
            this.Number7Button.TabIndex = 4;
            this.Number7Button.Text = "7";
            this.Number7Button.UseVisualStyleBackColor = true;
            this.Number7Button.Click += new System.EventHandler(this.Number7Button_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(600, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(195, 134);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(401, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(193, 134);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(202, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(193, 134);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(193, 134);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsToButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(803, 813);
            this.Controls.Add(this.ButtonsPannel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ButtonsPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPannel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EqualsToButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button Number0Button;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button Number3Button;
        private System.Windows.Forms.Button Number2Button;
        private System.Windows.Forms.Button Number1Button;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Number6Button;
        private System.Windows.Forms.Button Number5Button;
        private System.Windows.Forms.Button Number4Button;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button Number9Button;
        private System.Windows.Forms.Button Number8Button;
        private System.Windows.Forms.Button Number7Button;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CButton;
    }
}

