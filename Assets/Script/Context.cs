using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    private StateBase _state;

    public int speed;
    public Context(StateBase state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }

    public StateBase State
    {
        get { return _state; }
        set { _state = value; }
    }


}


public abstract class StateBase
{
    public abstract void Handle(Context context);
}


public class ChangeStance : StateBase
{
    public override void Handle(Context context)
    {
        Debug.Log("Standing");
        context.State = new StandStace();
        context.speed = 0;
        Debug.Log("Your Speed is " + context.speed);
    }
}


public class StandStace : StateBase
{
    public override void Handle(Context context)
    {
        Debug.Log("Walking");
        context.State = new RunState();
        context.speed = 5;
        Debug.Log("Your Speed is " + context.speed);
    }
}

public class RunState : StateBase
{
    public override void Handle(Context context)
    {
        Debug.Log("Running");
        context.State = new ChangeStance();
        context.speed = 10;
        Debug.Log("Your Speed is " + context.speed);
    }
}

