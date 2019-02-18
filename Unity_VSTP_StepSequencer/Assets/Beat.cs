using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour {

    public Color BeatColor;
    public bool isPlaying;

    public int CurrentStep;
    public float Delay;

    public Transform[] Blocks;

    // Use this for initialization
    void Start () {

        StartCoroutine("StartBeat");
		
	}

    IEnumerator StartBeat()
    {
        while (isPlaying)
        {
            yield return new WaitForSeconds(Delay);
            CurrentStep++;

            if (CurrentStep > 15)
            {
                CurrentStep = 0;
                foreach (Transform T in Blocks)
                {
                    if (T.name != "Generated Map")
                    {
                        T.GetComponent<Note>().Play = false;
                        if (T.transform.position.x == 7.5f)
                        {
                            T.GetComponent<MeshRenderer>().material.color = Color.white;
                        }
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {

        Blocks = GetComponentsInChildren<Transform>();

        foreach (Transform T in Blocks)
        {
            if (T.name != "Generated Map")
            {
                if (T.tag != "Triggered")
                {

                    if (T.transform.position.x == -7.5f + (CurrentStep * 1))
                    {
                        T.GetComponent<MeshRenderer>().material.color = BeatColor;
                    }
                    else if (T.transform.position.x == -7.5f + (CurrentStep * 1) - 1)
                    {
                        T.GetComponent<MeshRenderer>().material.color = Color.white;
                    }
                }
                //1
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                       T.transform.position.z == 4.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //2
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == 3.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //3
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == 2.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //4
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == 1.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //5
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == 0.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //6
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == -0.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //7
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == -1.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //8
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == -2.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //9
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == -3.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }
                //10
                else if (T.transform.position.x == -7.5f + (CurrentStep * 1) &&
                T.transform.position.z == -4.5f)
                {
                    if (T.GetComponent<Note>().Play == false)
                    {
                        T.GetComponent<Note>().Play = true;
                        T.GetComponent<AudioSource>().Play();
                    }
                }

            }
        }
		
	}
}
