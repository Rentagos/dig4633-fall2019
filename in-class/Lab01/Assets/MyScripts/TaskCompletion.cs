using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCompletion : MonoBehaviour
{
    public bool chicken1 = false;
    public bool chicken2 = false;
    public bool sheep = false;
    public GameObject WinScreen;

    public Animator animator;

    public void TaskOne()
    {
        chicken1 = true;
    }

    public void TaskTwo()
    {
        chicken2 = true;
    }

    public void TaskThree()
    {
        sheep = true;
    }

    public void FadeOut()
    {
        animator.SetTrigger("FadeOut");
    }

    // Update is called once per frame
    void Update()
    {
        


        if (chicken1 && chicken2 && sheep == true)
        {
            
            WinScreen.SetActive(true);
            FadeOut();
        }
    }
}
