using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyMusic : MonoBehaviour
{
    public GameObject ObjectMusic;
    private AudioSource AudioSource;

    private void Start()
    {
       ObjectMusic = GameObject.FindWithTag("GameMusic");
       AudioSource = ObjectMusic.GetComponent<AudioSource>();
    }

   private void update()
      {
      AudioSource.Pause();
      } 
 }

