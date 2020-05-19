using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class Car:PhuongTien
    {
        public string StateString;
        // A reference to the current state of the Context.
        private MoveState _state = null;

        public Car(MoveState state)
        {
            this.TransitionTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(MoveState state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetCar(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Moving()
        {
            this._state.Move();
        }
        public bool _Up { get; set; }
        public bool _Down { get; set; }
        public bool _Left { get; set; }
        public bool _Right { get; set; }
        public bool isOver { get; set; }

        public Car()
        {
            Speed = 0;
            _Up = false;
            _Down = false;
            _Left = false;
            _Right = false;
        }
    }
}
