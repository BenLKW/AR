using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turtle : MonoBehaviour
{
    public GameObject Mic, Book, Fish, Drink;

    public Animator aninmator;
    public Status status;
    
    public enum Status
    {
        Idle,
        Dance,
        Sing,
        Read,
        Drink,
        Eat
    }

    public bool AudioDetected;
    public bool FreezeDetected;
    public bool BookDetected;


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
        if(status == Status.Idle && AudioDetected == false)
        {
            aninmator.SetTrigger("ObjNotDet");
        }

        if(status == Status.Idle && AudioDetected == true)
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

    public void Drnk()
    {
        if (status == Status.Idle && FreezeDetected == false)
        {
            aninmator.SetTrigger("ObjNotDet");
        }

        if (status == Status.Idle && FreezeDetected == true)
        {
            status = Status.Drink;
            aninmator.SetTrigger("Drink");
            Drink.SetActive(true);
        }
        
    }

    public void Sing()
    {
        if (status == Status.Idle && AudioDetected == false)
        {
            aninmator.SetTrigger("ObjNotDet");
        }

        if (status == Status.Idle && AudioDetected == true)
        {
            status = Status.Sing;
            aninmator.SetBool("Sing", true);
            Mic.SetActive(true);
        }
        else if (status == Status.Sing)
        {
            status = Status.Idle;
            aninmator.SetBool("Sing", false);
            Mic.SetActive(false);
        }
    }

    public void Read()
    {
        if (status == Status.Idle && BookDetected == false)
        {
            aninmator.SetTrigger("ObjNotDet");
        }

        if (status == Status.Idle && BookDetected == true)
        {
            status = Status.Read;
            aninmator.SetBool("Read", true);
            Book.SetActive(true);
        }
        else if (status == Status.Read)
        {
            status = Status.Idle;
            aninmator.SetBool("Read", false);
            Book.SetActive(false);
        }
    }

    public void Eat()
    {
        if (status == Status.Idle && FreezeDetected == false)
        {
            aninmator.SetTrigger("ObjNotDet");
        }

        if (status == Status.Idle && FreezeDetected == true)
        {
            status = Status.Eat;
            aninmator.SetTrigger("Eat");
            Fish.SetActive(true);
        }
        
    }

    public void EndTrigger()
    {
        status = Status.Idle;
        Fish.SetActive(false);
        Drink.SetActive(false);
    }
}
