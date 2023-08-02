using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{
    public bool WaitForPreviousAction = true; //by default ben el actions hanestana el ablaha tekhlas

    public abstract IEnumerator Execute();
}
