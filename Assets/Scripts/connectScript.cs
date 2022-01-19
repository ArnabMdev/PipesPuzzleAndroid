using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectScript : MonoBehaviour
{
    public PipeScript[] pipes;
    public GameObject youWin;
    
    // Start is called before the first frame update
    void Start()
    {
        pipes = GetComponentsInChildren<PipeScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ConnectedTrue())
        {
            youWin.SetActive(true);
            Time.timeScale = 0;

        }
    }

    bool ConnectedTrue()
    {
        bool flag = true;
        foreach (PipeScript pipe in pipes)
        {
            if (pipe.isNeeded && !pipe.isCorrect)
            {
                flag = false;
            }
        }
        return flag;
    }

    public void endGame()
    {
        Application.Quit();
    }
}
