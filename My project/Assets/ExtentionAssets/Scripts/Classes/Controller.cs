using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour, IPlayerController
{
    protected ControllerNS controllerNS = new ControllerNS();
    public float move { get; protected set; }

    protected abstract void MyTick();

    public void Moving(float _move)
    {
        move = _move;
    }

    void Start()
    {
        DB.IPlayerControllerDB = GetComponent<IPlayerController>();
    }

    void Update()
    {
        controllerNS.Tick();
        MyTick();
    }

}
