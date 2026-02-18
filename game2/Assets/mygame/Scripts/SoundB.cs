using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundB : MonoBehaviour
{

    public AudioClip soundJump;
    public static AudioSource jump;

    public AudioClip soundBotton;
    public static AudioSource Botton;

    public AudioClip soundBottonFalse;
    public static AudioSource Botton2;

    public AudioClip soundDoor;
    public static AudioSource door;


    public AudioClip soundTl;
    public static AudioSource TL;

    // Start is called before the first frame update
    void Start()
    {
        Botton = gameObject.AddComponent<AudioSource>();
        Botton.clip = soundBotton;

        Botton2 = gameObject.AddComponent<AudioSource>();
        Botton2.clip = soundBottonFalse;


        door = gameObject.AddComponent<AudioSource>();
        door.clip = soundDoor;
        

        TL = gameObject.AddComponent<AudioSource>();
        TL.clip = soundTl;

        jump= gameObject.AddComponent<AudioSource>();
        jump.clip = soundJump;
    }
}

    // Update is called once per frame
    
