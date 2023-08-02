using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioAction : Action
{
    public AudioSource AudioSource;
    public AudioClip[] AudioClips;
    public bool waitForAudioCompletion = true;

    public override IEnumerator Execute()
    {
        if (AudioSource == null)
        {
            Debug.LogError("Audio source is not set!");
            yield break;
        }

        if (AudioClips == null || AudioClips.Length == 0)
        {
            Debug.LogError("No audio clips are set!");
            yield break;
        }

        foreach (var audioClip in AudioClips)
        {
            AudioSource.clip = audioClip;
            AudioSource.Play();

            if (waitForAudioCompletion)
            {
                while (AudioSource.isPlaying)
                {
                    yield return null;
                }
            }
            else
            {
                yield return null;
            }
        }

        yield break;
    }
}


