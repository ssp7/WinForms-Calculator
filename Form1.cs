using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Constructor 

        #region Delete Method

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            FocusInputText();
        }

        private void CButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();
            FocusInputText();
        }

        #endregion Delete Method
        
        #region Operator Functions
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void EqualsToButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }
         
        #endregion Operator Functions

        private void CalculateEquation()
        {
            var useInput = this.UserInputText.Text;

            FocusInputText();
        }

        #region Number Methods
        private void Number7Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void Number9Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        
        private void Number4Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void Number6Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        
        private void Number1Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void Number2Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void Number0Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        } 

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }
        #endregion Number Methods

        #region Private Helpers
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        private void InsertTextValue(string value)
        {
            var selectionStart = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart,value);
            this.UserInputText.SelectionStart = selectionStart + value.Length;
            this.UserInputText.SelectionLength = 0;
        }

        private void DeleteTextValue()
        {
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            var selectionStart = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            this.UserInputText.SelectionStart = selectionStart;
            this.UserInputText.SelectionLength = 0;
        }
        #endregion Private Helpers
    }
}
