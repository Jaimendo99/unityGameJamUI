using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class musicVolume : MonoBehaviour
{
    public Slider musicSlider;
    
    public AudioSource musicSource;

    public AudioSource musicSource2;

    public TextMeshProUGUI musicText;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SetLevel(){
        musicSource.volume = musicSlider.value;
        musicSource2.volume = musicSlider.value;
        musicText.text = ""+(int)(musicSlider.value * 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
