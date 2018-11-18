using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martian
{
    /// <summary>
    /// Represent a class of OperationManager to seperate commands for robots.
    /// </summary>
    public class OperationManager
    {
        #region Public Methods

        public MoveItem Commander(MoveItem moveItem, List<string> commandStr)
        {
            var coordinates = commandStr[0].Replace(" ", string.Empty).ToCharArray();

            moveItem.XCoordinate = Convert.ToInt32(coordinates[0].ToString());
            moveItem.YCoordinate = Convert.ToInt32(coordinates[1].ToString());
            moveItem.StartDirection = Convert.ToChar(coordinates[2]);
            moveItem.CommandStr = commandStr[1].Replace(" ", string.Empty).Trim();

            return moveItem;
        }

        #endregion
    }
}