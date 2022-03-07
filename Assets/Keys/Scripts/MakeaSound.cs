using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeaSound: MonoBehaviour
{
    enum Key
    {
        C5, 
        Cis5,
        D5,
        Dis5,
        E5,
        F5,
        Fis5,
        G5,
        Gis5,
        A5,
        Ais5,
        H5,
        C6,
        Cis6,
        D6,
        Dis6,
        E6
    }
    [SerializeField] private Key key;
    AudioSource ad;
    AudioClip ac;

    void Start()
    {
        ad = GetComponent<AudioSource>();
        ac = ad.clip;
        ad.pitch = Mathf.Pow(2.0f, (float)(key)/12.0f);
    }

    void Update()
    {
        switch (key)
        {
            case Key.C5:
                KeyPush(KeyCode.A);
                break;
            case Key.Cis5:
                KeyPush(KeyCode.W);
                break;
            case Key.D5:
                KeyPush(KeyCode.S);
                break;
            case Key.Dis5:
                KeyPush(KeyCode.E);
                break;
            case Key.E5:
                KeyPush(KeyCode.D);
                break;
            case Key.F5:
                KeyPush(KeyCode.F);
                break;
            case Key.Fis5:
                KeyPush(KeyCode.T);
                break;
            case Key.G5:
                KeyPush(KeyCode.G);
                break;
            case Key.Gis5:
                KeyPush(KeyCode.Y);
                break;
            case Key.A5:
                KeyPush(KeyCode.H);
                break;
            case Key.Ais5:
                KeyPush(KeyCode.U);
                break;
            case Key.H5:
                KeyPush(KeyCode.J);
                break;
            case Key.C6:
                KeyPush(KeyCode.K);
                break;
            case Key.Cis6:
                KeyPush(KeyCode.O);
                break;
            case Key.D6:
                KeyPush(KeyCode.L);
                break;
            case Key.Dis6:
                KeyPush(KeyCode.P);
                break;
            case Key.E6:
                KeyPush(KeyCode.Colon);
                break;
            default:
                break;
        }    
    }

    void KeyPush(KeyCode code)
    {
        if (Input.GetKeyDown(code))
        {
            Sound();
        }
        else if (Input.GetKeyUp(code))
        {
            ad.Stop();
        }
    }

    public void Sound()
    {
        ad.PlayOneShot(ac);
    }


    public void OnClickUp()
    {
        ad.Stop();
    }
}
