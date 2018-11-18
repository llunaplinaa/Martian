using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martian
{
    /// <summary>
    /// Represent a class of MoveItem to defining moves for robots
    /// </summary>
    public class MoveItem
    {
        #region Members

        private string _Area = string.Empty;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Area string and sets XArea/YArea props.
        /// </summary>
        public string Area
        {
            get
            {
                return _Area;
            }
            set
            {
                _Area = value;
                var areas = _Area.Replace(" ", string.Empty).ToCharArray();
                if (areas.Length == 2)
                {
                    XArea = Convert.ToInt32(areas[0].ToString());
                    YArea = Convert.ToInt32(areas[1].ToString());
                }
            }
        }

        /// <summary>
        /// Gets or sets X Coordinate
        /// </summary>
        public int XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets Y Coordinate
        /// </summary>
        public int YCoordinate { get; set; }

        /// <summary>
        /// Gets or sets StartDirection
        /// </summary>
        public char StartDirection { get; set; }

        /// <summary>
        /// Gets or sets XArea
        /// </summary>
        public int XArea { get; set; }

        /// <summary>
        /// Gets or sets YArea
        /// </summary>
        public int YArea { get; set; }

        /// <summary>
        /// Gets or sets CommandStr
        /// </summary>
        public string CommandStr { get; set; }

        #endregion
    }
}