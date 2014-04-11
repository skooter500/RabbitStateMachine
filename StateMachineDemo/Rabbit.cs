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
    public class Rabbit
    {
        public int bowels;
        public int hunger;
        public int tiredness;
        public int age;
        public StateMachine stateMachine;
        
        Random r = new Random();
         
        public Rabbit()
        {
            bowels = r.Next() % 8;
            hunger = r.Next() % 20;
            tiredness = r.Next() % 10;
            age = 0;
            
            stateMachine = new StateMachine();
            stateMachine.ChangeState(new HoppingState(this));
            
        }
        
        public void Update()
        {           
            hunger ++;
            tiredness ++;
            age ++;
            bowels ++;
            
            stateMachine.Update();            
        }
    }
}

