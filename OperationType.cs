using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Type of Operation the calculator can perform 
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Add two values together
        /// </summary>
        Add, 
        /// <summary>
        /// Subtract two values
        /// </summary>
        Minus,
        /// <summary>
        /// Divides two values
        /// </summary>
        Divide,
        /// <summary>
        /// Multiply two values
        /// </summary>
        Multiply 
    }
}
