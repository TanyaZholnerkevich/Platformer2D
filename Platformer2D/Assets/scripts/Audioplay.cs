using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplay : MonoBehaviour
{
    public AudioSource _audio;
    public static Audioplay Instance;
    private void Awake()
    {
        Instance = this;
    }
}
