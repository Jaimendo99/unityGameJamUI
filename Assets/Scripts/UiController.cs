using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiController : MonoBehaviour
{
    public GameObject mainMenu;

    public GameObject optionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenOptions(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void CloseOptions(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
