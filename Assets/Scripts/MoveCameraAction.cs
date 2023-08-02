using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraAction : Action
{
    public Transform CameraTransform;
    public Transform TargetTransform;
    public float Duration;

    public override IEnumerator Execute()
    {
        if (WaitForPreviousAction)
            yield return null; 

        float elapsedTime = 0f;
        Vector3 startPosition = CameraTransform.position;
        Quaternion startRotation = CameraTransform.rotation;

        while (elapsedTime < Duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / Duration);
            CameraTransform.position = Vector3.Lerp(startPosition, TargetTransform.position, t);
            CameraTransform.rotation = Quaternion.Slerp(startRotation, TargetTransform.rotation, t);
            yield return null;
        }
    }
}