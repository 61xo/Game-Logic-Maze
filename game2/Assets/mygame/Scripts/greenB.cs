using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenB : MonoBehaviour
{
    public static bool istrue = false;
    public static bool isCo = false;
    public static bool isp1 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((isCo && Input.GetKeyDown(KeyCode.E)) && (isp1 && Player.player1))
        {

            if (!istrue)
            {
                SoundB.Botton.Play();
                istrue = true;

            }
        }
        else if ((isCo && Input.GetKeyDown(KeyCode.E)) && (!isp1 && !Player.player1))
        {

            if (!istrue)
            {
                SoundB.Botton.Play();
                istrue = true;
               
            }
        }
        if ((isCo && Input.GetKeyDown(KeyCode.F)) && (isp1 && Player.player1))
        {

            if (istrue)
            {
                SoundB.Botton2.Play();
                istrue = false;
               
            }
        }
        if ((isCo && Input.GetKeyDown(KeyCode.F)) && (!isp1 && !Player.player1))
        {

            if (istrue)
            {
                SoundB.Botton2.Play();
                istrue = false;
               
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player1" && Player.player1)
        {
            isp1 = true;
            isCo = true;


        }
        else if (collision.gameObject.name == "player2" && !Player.player1)
        {

            isCo = true;

            isp1 = false;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player1" && Player.player1) { isCo = false; isp1 = true; }

        else if (collision.gameObject.name == "player2" && !Player.player1) { isCo = false; isp1 = false; }
    }
}
