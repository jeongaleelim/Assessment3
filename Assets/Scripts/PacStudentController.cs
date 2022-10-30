using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Tweener tweener;

    private string lastInput;
    private string currentInput;

    private float speed = 2.5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            lastInput = "w";
            Debug.Log(lastInput);

            if (tweener != null)
            {
                if (!tweener.TweenExists(transform))
                {
                    tweener.AddTween(transform, transform.position, Vector3.up, speed);
                }

            }
        }

    }

}
