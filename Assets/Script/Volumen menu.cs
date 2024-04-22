using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumenSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider VolumenMaestro;
    [SerializeField] private Slider VolumenMusica;
    [SerializeField] private Slider VolumenMusicaSFX;


    public void SetMasterVolumen()
    {
        float volumen = VolumenMaestro.value;
        audioMixer.SetFloat("Maestro", Mathf.Log10(volumen) * 20);
    }
    public void SetMusicVolumen()
    {
        float volumen = VolumenMusica.value;
        audioMixer.SetFloat("Musica", Mathf.Log10(volumen) * 20);
    }
    public void SetSFXVolumen()
    {
        float volumen = VolumenMusicaSFX.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(volumen) * 20);
    }
}