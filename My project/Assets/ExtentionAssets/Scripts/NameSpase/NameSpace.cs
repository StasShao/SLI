using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB
{
    public static IPlayerController IPlayerControllerDB;
}

public class ControllerNS
{
    private void InputListener()
    {
        DB.IPlayerControllerDB.Moving(Input.GetAxis("Vertical"));
    }
    public void Tick()
    {
        InputListener();
    }

}