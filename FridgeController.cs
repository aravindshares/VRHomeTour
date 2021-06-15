using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeController : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    bool status = false;
    // Start is called before the first frame update
    public void FridgeControl()
    {
        if (!status)
        {
            anim.SetBool("FridgeController", true);
            status = !status;
        }
        else
        {
            anim.SetBool("FridgeController", false);
            status = !status;
        }
    }
}
