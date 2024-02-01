using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BoxControl : MonoBehaviour
{
    static float timer = 0f;
    public GameObject boxes;
    public GameObject spawnObject;
    public GameObject anim;
    public GameObject CounterText;
    int counter=0;
    public int counterontext = 0;
    int index = 0;
    GameObject go;
    collidercontroller _collidercontroller;

    public Image randomImage;
    public Sprite s0;
    public Sprite s1;
    public Sprite s2;
    public Sprite[] images;



    public List<GameObject> notes = new List<GameObject>();
                                                                                               // do 1, re 2, mi 3, fa 4, sol 5, la 6, si 7, do 8 //
    int [] Notes= new int[59]
        { 5,3,3,3,5,3,3,3,5,6,5,3,4,2,4,2,
          2,2,4,2,2,2,4,5,4,2,3,1,5,3,3,3,
          5,3,3,3,5,6,5,3,4,2,4,2,2,2,4,2,
          2,2,4,5,4,2,3,1,5,3,3,        };
    //   sol mi mi mi | sol mi mi mi | sol la sol mi | fa re
    //   fa re re re | fa re re re | fa sol fa re | mi do
    //   sol mi mi mi| sol mi mi mi | sol la sol mi | fa re
    //   fa re re re | fa re re re | fa sol fa re | mi do



    void Start()
    {
        //create = true;
        // Invoke("checkNotes", 2f);
        //InvokeRepeating("checkNotes", 1f, 2f);
        _collidercontroller = FindObjectOfType<collidercontroller>();
        images = new Sprite[3];
        images[0] = s0;
        images[1] = s1;
        images[2] = s2;

    }
    public void CounteronText(int a)
    {
        counterontext = a;
        CounterText.GetComponent<Text>().text = counterontext + "/56";
    }

    void Update()
    {
        CounteronText(counterontext);
       timer +=Time.deltaTime;
     if (timer > 1)
        {
          Debug.Log(timer);
          SpawnNotes();
          timer = 0;
          index++;
          Debug.Log(timer);
         }
        
    }

    //public void Sol(GameObject a) { 

    //  Destroy(a);


    //}


    //void checkNotesX(){
    //      Invoke("checkNotes",0.1f);
    //  }

    //void checkNotes()
    //{
    //    do
    //    {
    //        create = true;
    //       if (create == true)
    //        {
    //            for (int i = 0; i < 56; i++)
    //            {

    //                    if (Notes[i] == 5) // sol
    //                    {
    //                        go = Instantiate(boxes, new Vector3(1517f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                        //for (int f = 0; f < 14; f++)
    //                        //{
    //                        //    for (int k = 0; k < 4; k++)
    //                        //    {
    //                        //        Array.Clear(Notes, 0, 1);
    //                        //        break;
    //                        //    }
    //                        //}
    //                        break;
    //                    }
    //                    else if (Notes[i] == 3) // mi
    //                    {
    //                        go = Instantiate(boxes, new Vector3(897f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                        //for (int f = 0; f < 14; f++)
    //                        //{
    //                        //    for (int k = 0; k < 4; k++)
    //                        //    {
    //                        Array.Clear(Notes, 0, 1);
    //                        //        break;
    //                        //    }
    //                        //}
    //                        break;
    //                    }
    //                    else if (Notes[i] == 6) // la
    //                    {
    //                        go = Instantiate(boxes, new Vector3(1827f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                        break;
    //                    }
    //                    else if (Notes[i] == 2) // re
    //                    {
    //                        go = Instantiate(boxes, new Vector3(570f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                       break;
    //                    }
    //                    else if (Notes[i] == 4) // fa
    //                    {
    //                        go = Instantiate(boxes, new Vector3(1195f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                        break;
    //                    }
    //                    else if (Notes[i] == 1) // do1
    //                    {
    //                        go = Instantiate(boxes, new Vector3(276f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                         break;
    //                    }
    //                    else if (Notes[i] == 7) // si
    //                    {
    //                        go = Instantiate(boxes, new Vector3(2136f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                        Array.Clear(Notes, 0, 1);
    //                        break;
    //                    }
    //                    else if (Notes[i] == 8) // do2
    //                    {
    //                        go = Instantiate(boxes, new Vector3(2451f, 1400f, 0), Quaternion.identity, spawnObject.transform) as GameObject;
    //                        create = false;
    //                        counter++;
    //                       Array.Clear(Notes, 0, 1);
    //                        break;
    //                    }
    //                      Array.Clear(Notes, 0, 1);


    //            }
    //           // Array.Clear(Notes, 0, 1);
    //            //break;
    //            // 2d arr delete, clear
    //            //for (int i = 0; i < 14; i++)
    //            //{
    //            //    for (int j = 0; j < 4; j++)
    //            //    {
    //            //        Array.Clear(Notes, 0, 1);
    //            //        break;
    //            //    }
    //            //}
    //            }
    //         else
    //        {

    //        }
    //    } while (counter > 1);
    //    //while(create == true);



    //}


    //public void CountonText()
    //{
    //    counterontext++;
    //    counterText.text = counterontext + "/56";
    //}
    void RandomImager()
    {
            int num = UnityEngine.Random.Range(0, images.Length);
            randomImage.sprite = images[num];
    }
    
    void SpawnNotes()
    {
        if (index < 56)
        {
            if (Notes[index] == 5) // sol
            {
                RandomImager();
                go = Instantiate(boxes, notes[4].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
                Array.Clear(Notes, 0, 1);
            }
            else if (Notes[index] == 3) // mi
            {
                RandomImager();
                go = Instantiate(boxes, notes[2].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
                Array.Clear(Notes, 0, 1);
            }
            else if (Notes[index] == 6) // la
            {
                RandomImager();
                go = Instantiate(boxes, notes[5].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
                Array.Clear(Notes, 0, 1);
            }
            else if (Notes[index] == 2) // re
            {
                RandomImager();
                go = Instantiate(boxes, notes[1].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
                Array.Clear(Notes, 0, 1);
            }
            else if (Notes[index] == 4) // fa
            {
                RandomImager();
                go = Instantiate(boxes, notes[3].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;

            }
            else if (Notes[index] == 1) // do1
            {
                RandomImager();
                go = Instantiate(boxes, notes[0].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
            }
            else if (Notes[index] == 7) // si
            {
                RandomImager();
                go = Instantiate(boxes, notes[6].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
            }
            else if (Notes[index] == 8) // do2
            {
                RandomImager();
                go = Instantiate(boxes, notes[7].transform.position, Quaternion.identity, spawnObject.transform) as GameObject;
                counter++;
            }
            
        }
        else
        {
               
                anim.SetActive(true);
        }
        Debug.Log("Counter:");
        Debug.Log(counter);
    }








}
