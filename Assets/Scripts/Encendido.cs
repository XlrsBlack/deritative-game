using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            Vector3 newPosition = transform.position;
            newPosition.x += animator.GetFloat("Runspeed") * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
