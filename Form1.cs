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
            this.CalculationResultText.Text = ParseOperation();
            FocusInputText();
        }
        /// <summary>
        /// Parses the user equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                var input = this.UserInputText.Text;
                input = input.Replace(" ","");

                var operation = new Operation();
                var leftSide = true;
                
                for(int i = 0; i < input.Length; i++)
                {
                   // Check if the current character is a number
                   if("0123456789.".Any(c => input[i] == c))
                   {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                        }
                   }
                   // If it is an operator ( + - * / ) then set the operatory type
                   else if("+-/.*".Any(c => input[i] == c))
                   {
                        // if we are on the right side already, we now need to calculate ou current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative vlaue
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator ( + * / or more than one - ) specified without an right side number");
                                }

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set ot the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Then clearing the right side
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            var operatorType = GetOperationType(input[i]);

                            if (operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative vlaue
                                if(operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator ( + * / or more than one - ) specified without an left side number");
                                }

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                   }
                }
                // After we are done parsing, and ther are no exceptions then calculate the current operation

                return CalculateOperation(operation);
            }
            catch(Exception e)
            {
                return $"invalid equation. {e.Message}";
            }
        }
        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation"></param>
        private string CalculateOperation(Operation operation)
        {
            // Storing the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            // check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide,out left))
            {
                throw new InvalidOperationException($"Left side of the equation was not a number. {operation.LeftSide}");
            }

            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException($"Right side of the equation was not a number. {operation.RightSide}");
            }
            try
            {
                switch (operation.OperationType)
                {
                    case (OperationType.Add):
                        return (left + right).ToString();
                    case (OperationType.Minus):
                        return (left - right).ToString();
                    case (OperationType.Multiply):
                        return (left * right).ToString();
                    case (OperationType.Divide):
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkown operator type when calculating operation. {operation.OperationType}");
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to calulate {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {e.Message}");
            }
        }
        /// <summary>
        /// Accepts the character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">Character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Uknown operatory type {character}");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the number, checking for valid characters as it goes. 
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentCharacter">The new character to append to the string</param>
        /// <returns></returns>

        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if(newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            }
            return currentNumber+newCharacter;
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
