using UnityEngine;
using System.Collections;

public class MultiObjSwitch : MonoBehaviour
{

    public GameObject[] objects;
    private int objIndex;

    

    // Use this for initialization
    void Start()
    {
		objIndex = 0;
		objects[objIndex].SetActive(true);

		if (objIndex == 0)
        {
			for (int i = 1; i < objects.Length; i++)
            {
				objects[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        

       
    }


    public void ObjSwitch()
    {

            switchObj();
    }

    private void switchObj()
    {
		for (int k = 0; k < objects.Length; k++)
        {
			objects[k].SetActive(false);
        }

		if (objIndex < objects.Length - 1)
        {
			objIndex += 1;
        }

		else if (objIndex >= objects.Length - 1)
        {
			objIndex = 0;
        }

		objects[objIndex].SetActive(true);

		if (objIndex> 0)
        {
			objects[objIndex - 1].SetActive(false);
        }

		if (objIndex == 0)
        {
			for (int i = 1; i < objects.Length; i++)
            {
				objects[i].SetActive(false);
            }
        }
    }

}
