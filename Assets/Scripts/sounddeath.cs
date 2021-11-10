using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class sounddeath : MonoBehaviour


{
    public AudioSource asource3;
    public AudioClip aclip3;
    void OnTriggerEnter()
    {

        asource3.PlayOneShot(aclip3);
        


    }


}
