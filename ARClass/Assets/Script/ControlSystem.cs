using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    public Turtle Turtle;
    public GameObject Audio;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DetectAudio()
    {
        Turtle.AudioDetected = true;
    }

    public void DetectAudioLost()
    {
        Turtle.AudioDetected = false;
    }

    public void DetectBook()
    {
        Turtle.BookDetected = true;
    }

    public void DetectBookLost()
    {
        Turtle.BookDetected = false;
    }

    public void DetectFreeze()
    {
        Turtle.FreezeDetected = true;
    }

    public void DetectFreezeLost()
    {
        Turtle.FreezeDetected = false;
    }
}
