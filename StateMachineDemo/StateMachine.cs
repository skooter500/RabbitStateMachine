//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace StateMachineDemo
{
    public class StateMachine
    {
        public State state;
        
        public StateMachine()
        {
        }
        
        public void Update()
        {
            state.Update();
        }
        
        public void ChangeState(State newState)
        {
            if (state != null)
            {
                state.Exit();
            }
            state = newState;
            
            if (state != null)
            {
                state.Enter();
            }
        }
    }
}
