using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{

    public GameObject Game;
    public GameObject Menu;

    public Clicker clicker;

    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clicker.Click();  
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivateMenu();
        }
    }

    public void StartGame()
    {
        Game.SetActive(true);
        Menu.SetActive(false);
    }

    public void ActivateMenu()
    {
        Menu.SetActive(true);
        Game.SetActive(false);
    }
}
