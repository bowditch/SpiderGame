using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowEncounter : MonoBehaviour
{
    public Animator cameraAnimator;
    public Animator bird;
    public BoxCollider birdKillzone;
    public SpiderMove player;
    public Animator birdAniamtor;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Spider")
        {
            cameraAnimator.SetTrigger("Shadow");
            birdAniamtor.SetTrigger("Flying");
            bird.SetTrigger("Flyover");
            birdKillzone.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Spider")
        {
            cameraAnimator.SetTrigger("ShadowEND");
            birdKillzone.enabled = false;
        }
        
    }
}
