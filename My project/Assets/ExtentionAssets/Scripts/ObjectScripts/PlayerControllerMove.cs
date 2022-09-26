using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMove : Controller
{
    protected override void MyTick()
    {
        switch (move)
        {
            case > 0:
                Debug.Log("Move forward!!!");
                break;
            case < 0:
                Debug.Log("Move back!!");
                break;
            default:
                break;
        }
    }
}
