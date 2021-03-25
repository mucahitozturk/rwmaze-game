using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource Ses;
    public AudioClip sesClip;
    private void Awake()
    {
        foreach(Button btn in Resources.FindObjectsOfTypeAll<Button>())
        {
            btn.onClick.AddListener(() => btnSesCalma());
        }
    }

    public void btnSesCalma()
    {
        Ses.PlayOneShot(sesClip, 1);
    }
}
