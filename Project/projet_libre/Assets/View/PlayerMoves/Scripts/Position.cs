using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.View.Player_moves
{
    public class Position
    {
        #region Attributes
        private int x;
        private int y;
        #endregion

        #region Getters
        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
        #endregion

        #region Setters
        public void SetX(int posX)
        {
            this.x = posX;
        }

        public void SetY(int posY)
        {
            this.y = posY;
        }
        #endregion
    }
}
