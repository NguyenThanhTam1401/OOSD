using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    class CloseState : MoveState
    {
        public override void GetStateString()
        {
            this._Car.StateString = "Close State";
        }

        public override void Move()
        {
            SetImage();
            GetStateString();
        }

        public override void SetImage()
        {
            this._Car.Image = Game_Dua_Xe.Properties.Resources.boom;
        }
    }
}
