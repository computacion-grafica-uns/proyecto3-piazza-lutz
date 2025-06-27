using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTurnLeft : StateMachineBehaviour
{
    public float rotationTotal = 0f;
    public float targetRotation = -90f;
    private Transform personajeTransform;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        personajeTransform = animator.transform.root;
        rotationTotal = 0f;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    /*override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }*/

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float animationDuration = stateInfo.length;
        float rotationPerSecond = targetRotation / animationDuration;
        float rotationThisFrame = rotationPerSecond * Time.deltaTime;

        if (rotationTotal - rotationThisFrame < targetRotation)
        {
            rotationThisFrame = targetRotation - rotationTotal;
        }

        personajeTransform.Rotate(0f, rotationThisFrame, 0f);
        rotationTotal -= rotationThisFrame;
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}


}
