using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudio : MonoBehaviour {

    public AudioSource _music;
    public AudioSource _Fx;
    public AudioSource _preguntasSound;
    

    float _volumen = 0.5f;
    float _Fxvolume = 0.3f;
    float _PreguntasVolume = 0.5f;


    private void Start()
    {
        
    }

    private void Update()
    {
        _music.volume = _volumen;
        _Fx.volume = _Fxvolume;
        _preguntasSound.volume = _PreguntasVolume;
    }

    public void SetVolumen(float _level)
    {
        _volumen = _level;
    }
    public void SetFxVolumen(float _level)
    {
        _Fxvolume = _level;
    }
    public void SetPreguntasVolumen(float _level)
    {
        _PreguntasVolume = _level;
    }

    public void Mute()
    {
        _music.mute = !_music.mute;
        _Fx.mute = !_Fx.mute;
        _preguntasSound.mute = !_preguntasSound.mute;
    }
}
