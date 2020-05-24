﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class MoveLeft:MoveState
    {
        public override void GetStateString()
        {
            this._CarContext.StateString = "Move Left";
        }

        public override void Move()
        {
            if (this._CarContext.Left > 5)
                this._CarContext.Left -= this._CarContext.Speed;
            if (this._CarContext.isOver)
                return;
            SetImage();
            GetStateString();

            if (this._CarContext._Up)
                this._CarContext.TransitionTo(new MoveUp());

            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(new MoveDown());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(new MoveRight());

            //else this._CarContext.TransitionTo(new NormalState());

        }

        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeLeft;
        }
    }
}
