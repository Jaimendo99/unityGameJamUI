using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class soundsVolume : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider soundSlider;
    
    public AudioSource soundSource;

    public AudioSource soundSource2;

    public TextMeshProUGUI soundText;

    // Start is called before the first frame update

    public void SetLevel(){
        soundSource.volume = soundSlider.value;
        soundSource2.volume = soundSlider.value;
        soundText.text = ""+(int)(soundSlider.value * 10);
        
    }

}
