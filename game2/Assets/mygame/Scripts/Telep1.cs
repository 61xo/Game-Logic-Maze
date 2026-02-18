using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telep1 : MonoBehaviour
{
    public Transform TL;
    public GameObject Player1;
    public GameObject Player2;
    public Camera mCamera;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.Idv = false;
            redB.istrue = false;
            blueB.istrue = false;
            greenB.istrue = false;
            yallowB.istrue = false;
            Player1.transform.position = TL.position+new Vector3(0,4);
            Player2.transform.position = TL.position + new Vector3(0, -4);
            SoundB.TL.Play();

            if (mCamera != null)
            {
                mCamera.transform.position = TL.position+ new Vector3(0, 0,-10) ;

            }
        }
    }

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
