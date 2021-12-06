using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChange : MonoBehaviour
{
    Context states = new Context(new ChangeStance());

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            states.Request();
        }
    }
}
