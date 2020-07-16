using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum SoundEffect
    {
        Fire1,
        Fire2,
        Fire3,
        Jump
    }
    public enum BackgroundMusic
    {
        bgmusic1
    }

    public AudioSource fire1Effect;
    public AudioSource fire2Effect;
    public AudioSource fire3Effect;
    public AudioSource JumpEffect;
    public AudioSource backgroundMusic;

    public static AudioManager Instance;

    private void Awake() {
        Instance = this;
    }
    
    public void PlaySoundEffect(SoundEffect effect){
        switch (effect)
        {
            case SoundEffect.Fire1:
            fire1Effect.Play();
            break;
            case SoundEffect.Fire2:
            fire2Effect.Play();
            break;
            case SoundEffect.Fire3:
            fire3Effect.Play();
            break;
            case SoundEffect.Jump:
            JumpEffect.Play();
            break;
        
        }
    }

    public void PlayBackGroundMusic(BackgroundMusic bgmusic){
        switch (bgmusic)
        {
            case BackgroundMusic.bgmusic1:
            backgroundMusic.Play();
            break;
        
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
