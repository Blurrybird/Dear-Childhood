using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour

{
    public Slider volumeSlider;
    public GameObject ObjectMusic;

    // Start is called before the first frame update
    private float MusicVolume = 0f;
    private AudioSource AudioSource;

   private void Start()
    {
       ObjectMusic = GameObject.FindWithTag("GameMusic");
       AudioSource = ObjectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    // Update is called once per frame
    private void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void updateVolume ( float volume)
    {
        MusicVolume = volume;
    }
}
