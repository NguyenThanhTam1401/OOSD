﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class StartState:MoveState
    {
        private static StartState _instance;
        protected StartState()
        {

        }
        public static StartState Instance()
        {
            if(_instance == null)
            {
                _instance = new StartState();
            }
            return _instance;
        }
        public override void Move()
        {
            //Set image của context
            SetImage();

            StateTransit();
        }

        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.police;
        }

        //Phương thức chuyển trạng thái
        public override void StateTransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(MoveUp.Instance());

            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(MoveDown.Instance());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(MoveRight.Instance());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(MoveLeft.Instance());
        }

    }
}
