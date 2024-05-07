using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource sfxSource;
    [SerializeField] public AudioClip jump;

    public AudioClip background;
    public AudioClip hurt;
    public AudioClip death;
    //public AudioClip jump;

    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PauseAudio(AudioClip clip)
    {
        musicSource.Pause();
    }
    
    public void PlayAudio(AudioClip clip)
    {
        musicSource.Play();
    }
}
