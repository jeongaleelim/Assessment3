using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Tweener tweener;
    private string lastInput;
    private string currentInput;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            lastInput = "w";


        }
    }
}
