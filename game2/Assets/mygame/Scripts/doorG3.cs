using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorG3 : MonoBehaviour
{
    public static bool dooro = false;
    private Vector3 ot;
    // Start is called before the first frame update
    void Start()
    {
        ot = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!greenB.istrue && blueB.istrue) dooro = true;
        else dooro = false;

        if (dooro)
        {

            transform.position = new Vector3(100, 100, 100);
        }

        else transform.position = ot;


    }
}
