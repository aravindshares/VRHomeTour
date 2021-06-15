using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnterTrigger : MonoBehaviour
{   [SerializeField]
    Animator anim;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider cameracon)
    {
        if (cameracon.gameObject.tag == "CamCon")
        {
            anim.SetBool("DoorOpen", true);
        }
    }

    private void OnTriggerExit(Collider cameracon)
    {
        if (cameracon.gameObject.tag == "CamCon")
        {
            anim.SetBool("DoorOpen", false);
        }
    }
}
