using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turtle : MonoBehaviour
{
    public Animator aninmator;
    Status status;
    public enum Status
    {
        Idle,
        Dance
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Whendetect()
    {
        aninmator.SetTrigger("Detected");
    }

    public void Dance()
    {
        if(status == Status.Idle)
        {
            status = Status.Dance;
            aninmator.SetBool("Dance", true);
        }
        else if(status == Status.Dance)
        {
            status = Status.Idle;
            aninmator.SetBool("Dance", false);
        }
    }
}
