using UnityEngine;
using System.Collections;

public class RotatingDoor : MonoBehaviour {

    public GameObject door;
    public float doorOpenAngle;
    public float doorOpenSpeed = 20.0f;

    private float yVelocity = 0.0F;
    private bool doortoOpen = false;
    private Quaternion target;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (doortoOpen)
        {
            target = Quaternion.Euler(0, doorOpenAngle, 0);
        }

        else
        {
            target = Quaternion.Euler(0, 0, 0);
        }

        door.transform.rotation = Quaternion.Slerp(door.transform.rotation, target, doorOpenSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doortoOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doortoOpen = false;
        }
    }
}
