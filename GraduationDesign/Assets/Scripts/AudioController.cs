using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public int maxVolume = 0;
    public int presentVolume;
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.SetFloat("volume", 0);
        volumeSlider.value = maxVolume;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
