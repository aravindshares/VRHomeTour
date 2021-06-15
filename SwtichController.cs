using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichController : MonoBehaviour
{   [SerializeField]
    GameObject LightSource;
    bool status = false;
    // Start is called before the first frame update
    public void TurnOnSwitch()
    {
        if (!status)
        {
            LightSource.SetActive(true);
            status = !status;
        }
        else
        {
            LightSource.SetActive(false);
            status = !status;
        }
    }
}
