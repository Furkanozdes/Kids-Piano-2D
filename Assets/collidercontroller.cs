using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collidercontroller : MonoBehaviour
{
    BoxControl boxControl;
    public static string tıklananNota;
    static bool temasEtti=false;
    static GameObject temp;

    void Start()
    {
        //boxControl =GameObject.Find("GameManager").GetComponent<BoxControl>();
    }
    public void Tıklanan(string a)
    {
        tıklananNota = a;
        Debug.Log(tıklananNota);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ColliderSol")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderFa")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderMi")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderRe")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderLa")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderSi")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderDo1")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderDo2")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else
        {

        }
    }
    private void LateUpdate()
    {
        if (temasEtti)
        {
            if (temp.name == tıklananNota)
            {
           
                Destroy(gameObject);
                /*BoxControl.CountonText()*/;
                tıklananNota = "0";
                Time.timeScale = 1;
                temasEtti = false;
            }
        }
    }

}
