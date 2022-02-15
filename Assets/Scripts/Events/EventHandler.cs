public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp,
    bool isLiftingToolDown, bool isPickingRight, bool isPickingLeft, bool isPickingDown, bool isPickingUp,
    bool isSwingingToolDown, bool isSwingingToolUp, bool isSwingingToolRight, bool isSwingingToolLeft,
    bool idleUp, bool idleDown, bool idleRight, bool idleLeft);

public static class EventHandler
{
    //movement event
    public static event MovementDelegate MovementEvent;

    //movement event call for publishers
    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp,
    bool isLiftingToolDown, bool isPickingRight, bool isPickingLeft, bool isPickingDown, bool isPickingUp,
    bool isSwingingToolDown, bool isSwingingToolUp, bool isSwingingToolRight, bool isSwingingToolLeft,
    bool idleUp, bool idleDown, bool idleRight, bool idleLeft)
    {
        if (MovementEvent != null)
            MovementEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarrying, toolEffect, isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
                isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, isPickingRight, isPickingLeft, isPickingDown, isPickingUp, isSwingingToolDown,
                isSwingingToolUp, isSwingingToolRight, isSwingingToolLeft, idleUp, idleDown, idleRight, idleLeft);
    }
}