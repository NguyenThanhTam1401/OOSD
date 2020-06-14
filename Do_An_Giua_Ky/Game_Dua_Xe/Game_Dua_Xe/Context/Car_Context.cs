using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class CarContext:PhuongTien
    {
        //Tham chiếu đến state hiện tại của Context
        private MoveState _state = null;

        public bool _Up { get; set; }
        public bool _Down { get; set; }
        public bool _Left { get; set; }
        public bool _Right { get; set; }
        public bool isOver { get; set; }

        public CarContext()
        {
            Speed = 0;
            _Up = false;
            _Down = false;
            _Left = false;
            _Right = false;
        }

        public CarContext(MoveState state)
        {
            this.TransitionTo(state);
        }

        // Changing the State 
        public void TransitionTo(MoveState state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        public void Moving()
        {
            this._state.Move();
        }

        public string getState()
        {
            return this._state.GetType().Name;
        }
    }
}
