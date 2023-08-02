using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using UnityEngine.Rendering.VirtualTexturing;

public class SequenceController : MonoBehaviour
{
    public List<Action> Actions;

    void Start()
    {
        StartCoroutine(RunSequence());
    }

    IEnumerator RunSequence()
    {
        foreach (Action action in Actions)
        {
            yield return StartCoroutine(action.Execute());
        }
    }
}




