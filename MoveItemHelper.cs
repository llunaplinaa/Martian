using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martian
{
    /// <summary>
    /// Represent helper for defining char commands as enum
    /// </summary>
    public class MoveItemHelper
    {
        /// <summary>
        /// Turn/Move command enums
        /// </summary>
        public enum CommandChars
        {
            Left='L',
            Right='R',
            Move='M'
        }

        /// <summary>
        /// Rotation enums
        /// </summary>
        public enum RotationChars
        {
            North = 'N',
            East = 'E',
            South = 'S',
            West='W'
        }
    }
}