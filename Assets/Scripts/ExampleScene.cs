using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScene : MonoBehaviour
{
    public SequenceController SequenceController;
    public Animator Animator; // el animator beta3 el player (el capsule)
    public AudioSource AudioSource; //el audio source (ma7tout 3ala el Main Camera Object)
    public AudioClip[] AudioClips;
    public GameObject GameObject; //el game object el hayet3emelo disable fel example
    public Transform CameraTransform; 
    public Transform TargetTransform;
    public bool waitForAnimationCompletion = true;
    public bool waitForAudioCompletion = true;

    void Start()
    {
        //Han create list of actions
        List<Action> actions = new List<Action>();

        //Hanzawed PlayAnimationAction lel list el fyha el actions
        PlayAnimationAction playAnimationAction = new PlayAnimationAction();
        playAnimationAction.Animator = Animator;
        playAnimationAction.AnimationName = "Walk";
        playAnimationAction.waitForAnimationCompletion = waitForAnimationCompletion;
        actions.Add(playAnimationAction);

        //Hanzawed PlayAudioAction lel list el fyha el actions
        PlayAudioAction playAudioAction = new PlayAudioAction();
        playAudioAction.AudioSource = AudioSource;
        playAudioAction.AudioClips = AudioClips; 
        playAudioAction.waitForAudioCompletion = waitForAudioCompletion;
        actions.Add(playAudioAction);

        //Hanzawed EnableDisableGameObjectAction lel list el fyha el actions
        EnableDisableGameObjectAction enableDisableGameObjectAction = new EnableDisableGameObjectAction();
        enableDisableGameObjectAction.GameObject = GameObject;
        enableDisableGameObjectAction.Enable = false;
        actions.Add(enableDisableGameObjectAction);

        //Hanzawed MoveCameraAction lel list el fyha el actions
        MoveCameraAction moveCameraAction = new MoveCameraAction();
        moveCameraAction.CameraTransform = CameraTransform;
        moveCameraAction.TargetTransform = TargetTransform;
        moveCameraAction.Duration = 2f;
        actions.Add(moveCameraAction);

        //Hena ba2a han set el list of actions 3ala the SequenceController
        SequenceController.Actions = actions;
    }
}
