
using UnityEngine;


public class MovementAnimationParameterControl : MonoBehaviour
{
    
    private Animator animator;

    //use this for initialization

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    private void SetAnimationParameters(float xInput, float yInput, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp,
    bool isLiftingToolDown, bool isPickingRight, bool isPickingLeft, bool isPickingDown, bool isPickingUp,
    bool isSwingingToolDown, bool isSwingingToolUp, bool isSwingingToolRight, bool isSwingingToolLeft,
    bool idleUp, bool idleDown, bool idleRight, bool idleLeft)
    {
        animator.SetFloat(Settings.xInput, xInput);
        animator.SetFloat(Settings.yInput, yInput);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        if (isUsingToolDown)
            animator.SetTrigger(Settings.isUsingToolDown);
        if (isUsingToolUp)
            animator.SetTrigger(Settings.isUsingToolUp);
        if (isUsingToolRight)
            animator.SetTrigger(Settings.isUsingToolRight);
        if (isUsingToolLeft)
            animator.SetTrigger(Settings.isUsingToolLeft);

        if (isLiftingToolDown)
            animator.SetTrigger(Settings.isLiftingToolDown);
        if (isLiftingToolUp)
            animator.SetTrigger(Settings.isLiftingToolUp);
        if (isLiftingToolRight)
            animator.SetTrigger(Settings.isLiftingToolRight);
        if (isLiftingToolLeft)
            animator.SetTrigger(Settings.isLiftingToolLeft);

        if (isSwingingToolDown)
            animator.SetTrigger(Settings.isSwingingToolDown);
        if (isSwingingToolUp)
            animator.SetTrigger(Settings.isSwingingToolUp);
        if (isSwingingToolRight)
            animator.SetTrigger(Settings.isSwingingToolRight);
        if (isSwingingToolLeft)
            animator.SetTrigger(Settings.isSwingingToolLeft);

        if (isPickingDown)
            animator.SetTrigger(Settings.isPickingDown);
        if (isPickingUp)
            animator.SetTrigger(Settings.isPickingUp);
        if (isPickingRight)
            animator.SetTrigger(Settings.isPickingRight);
        if (isPickingLeft)
            animator.SetTrigger(Settings.isPickingLeft);

        if (idleDown)
            animator.SetTrigger(Settings.idleDown);
        if (idleUp)
            animator.SetTrigger(Settings.idleUp);
        if (idleRight)
            animator.SetTrigger(Settings.idleRight);
        if (idleLeft)
            animator.SetTrigger(Settings.idleLeft);

    }

    private void AnimationEventPlayFootstepSound()
    {

    }
}
