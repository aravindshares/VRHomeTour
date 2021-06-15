using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    bool status = false;
    public void FridgeControl()
    {
        if (!status)
        {
            anim.SetBool("DoorOpen", true);
            status = !status;
        }
        else
        {
            anim.SetBool("DoorOpen", false);
            status = !status;
        }
    }
}
