using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationAction : Action
{
    public Animator Animator;
    public string AnimationName;
    public int layerIndex = 0;
    public bool waitForAnimationCompletion = true;

    public override IEnumerator Execute()
    {
        if (WaitForPreviousAction)
            yield return null; 

        Animator.Play(AnimationName, layerIndex, 0);

        if (waitForAnimationCompletion)
        {
            while (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
            {
                yield return null;
            }
        }
        else
        {
            yield return null;
        }
    }
}
