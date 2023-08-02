using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableGameObjectAction : Action
{
    public GameObject GameObject;
    public bool Enable;

    public override IEnumerator Execute()
    {
        if (WaitForPreviousAction)
            yield return null; 

        GameObject.SetActive(Enable);
    }
}
