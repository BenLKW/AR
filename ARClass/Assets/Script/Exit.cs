using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject Menu;
    public GameObject InteractUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitMenu()
    {
        Menu.SetActive(true);
        InteractUI.SetActive(false);
    }

    public void Return()
    {
        Menu.SetActive(false);
        InteractUI.SetActive(true);
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
