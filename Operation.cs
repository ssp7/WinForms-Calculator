using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculator
    /// </summary>
    class Operation
    {
        /// <summary>
        /// Left side of the operation
        /// </summary>
        public string LeftSide { get; set; }
        /// <summary>
        /// Right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// Type of the operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Inner operation to be performed initially before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

    }
}
