using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martian
{
    public class Robot
    {
        #region Members

        private bool isXMove = true;
        private bool isYMove = true;

        #endregion

        #region Public Properties

        public MoveItem CurrentItem { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Prints robot's last location
        /// </summary>
        /// <returns></returns>
        public string Output()
        {
            return $"{this.CurrentItem.XCoordinate} {this.CurrentItem.YCoordinate} {this.CurrentItem.StartDirection.ToString()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Do seperate robot's command
        /// </summary>
        public void DoOperation()
        {
            char[] commands = CurrentItem.CommandStr.ToCharArray();

            foreach (char command in commands)
            {
                var commandStr = this.CurrentItem.StartDirection.ToString();
                switch (command)
                {
                    case ((char)MoveItemHelper.CommandChars.Left):
                        {

                            if (commandStr.Contains((char)MoveItemHelper.RotationChars.North))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.West;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.West))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.South;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.South))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.East;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.East))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.North;
                            }
                        }
                        break;
                    case ((char)MoveItemHelper.CommandChars.Right):
                        {

                            if (commandStr.Contains((char)MoveItemHelper.RotationChars.North))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.East;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.East))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.South;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.South))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.West;
                            }
                            else if (commandStr.Contains((char)MoveItemHelper.RotationChars.West))
                            {
                                this.CurrentItem.StartDirection = (char)MoveItemHelper.RotationChars.North;
                            }
                        }
                        break;
                    case ((char)MoveItemHelper.CommandChars.Move):
                        {
                            CoordinateChecker();
                            Mover();
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Checks the area coordinates
        /// </summary>
        private void CoordinateChecker()
        {

            if (this.CurrentItem.XCoordinate < 0 || this.CurrentItem.XCoordinate > this.CurrentItem.XArea)
                isXMove = false;

            if (this.CurrentItem.YCoordinate < 0 || this.CurrentItem.YCoordinate > this.CurrentItem.YArea)
                isYMove = false;
        }

        /// <summary>
        /// Makes robot's move 
        /// </summary>
        private void Mover()
        {
            switch (this.CurrentItem.StartDirection)
            {
                case ((char)MoveItemHelper.RotationChars.North):
                    if (isYMove)
                        this.CurrentItem.YCoordinate += 1;

                    break;

                case ((char)MoveItemHelper.RotationChars.East):
                    if (isXMove)
                        this.CurrentItem.XCoordinate += 1;
                    break;

                case ((char)MoveItemHelper.RotationChars.South):
                    if (isYMove)
                        this.CurrentItem.YCoordinate -= 1;
                    break;

                case ((char)MoveItemHelper.RotationChars.West):
                    if (isXMove)
                        this.CurrentItem.XCoordinate -= 1;
                    break;
            }
            if (this.CurrentItem.XCoordinate != 0 && !isXMove)
                this.CurrentItem.XCoordinate = this.CurrentItem.XArea;
            if (this.CurrentItem.YCoordinate != 0 && !isYMove)
                this.CurrentItem.YCoordinate = this.CurrentItem.YArea; ;
        }

        #endregion

    }

}
