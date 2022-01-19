using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeScript : MonoBehaviour
{
    public int pipType;
    public string currentOrientaion;
    public string[] correctOrientations;
    public bool isNeeded = false;
    public bool isCorrect = false;
    private bool isSet = false;
    // Start is called before the first frame update
    void Start()
    {
        OrientationChecker();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotate()
    {
        transform.Rotate(0f, 0f, 90.0f);
        OrientationChecker();
    }

    void OrientationChecker()
    {
        if (pipType == 1)
        {
            if ((transform.rotation.eulerAngles.z / 90f) % 2 == 1)
            {
                currentOrientaion = "vertical";
            }
            else
            {
                currentOrientaion = "horizontal";
            }
        }
        else if (pipType == 2)
        {
            if ((transform.rotation.eulerAngles.z / 90) % 4 == 0)
            {
                currentOrientaion = "horizontalUp";
            }
            else if ((transform.rotation.eulerAngles.z / 90) % 4 == 1)
            {
                currentOrientaion = "verticalLeft";
            }
            else if ((transform.rotation.eulerAngles.z / 90) % 4 == 2)
            {
                currentOrientaion = "horizontalDown";
            }
            else
            {
                currentOrientaion = "verticalRight";
            }
        }
        else
        {
            if ((transform.rotation.eulerAngles.z / 90) % 4 == 0)
            {
                currentOrientaion = "verticalRight";
            }
            else if ((transform.rotation.eulerAngles.z / 90) % 4 == 1)
            {
                currentOrientaion = "verticalLeft";
            }
            else if ((transform.rotation.eulerAngles.z / 90) % 4 == 2)
            {
                currentOrientaion = "inverseVerticalLeft";
            }
            else
            {
                currentOrientaion = "InverseVerticalRight";
            }
        }

        if(Array.Exists(correctOrientations,x=>x==currentOrientaion))
        {
            isCorrect = true;
            isSet = true;
        }
        else
        {
            isCorrect = false;  
        }
    }

   
}
