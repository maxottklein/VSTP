using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public Transform tilePrefab;
    public Vector2 mapSize;

    public int CurrentStep;
    public Color StepColor;
    public float Delay;
    public bool isPlaying;

    public AudioClip FirstRowSound;
    public AudioClip SecondRowSound;
    public AudioClip ThirdRowSound;
    public AudioClip FourthRowSound;
    public AudioClip FithRowSound;
    public AudioClip SixthRowSound;
    public AudioClip SeventhRowSound;
    public AudioClip EighthRowSound;
    public AudioClip NinethRowSound;
    public AudioClip TenthRowSound;



    [Range(0,1)]
    public float outlinePercent; 



    void Start()
    {
        GenerateMap();

        StartCoroutine("StartBeat");
    }

    IEnumerator StartBeat()
    {
        while (isPlaying)
        {
            yield return new WaitForSeconds(Delay);
            CurrentStep++;

            if (CurrentStep > mapSize.x - 1)
            {
                CurrentStep = 0;
            }
        }
    }


    public void GenerateMap() {

        string holderName = "Generated Map";

        if (transform.FindChild(holderName)) {

            DestroyImmediate(transform.FindChild(holderName).gameObject);
        }

        Transform mapHolder = new GameObject (holderName).transform;
        mapHolder.parent = transform;
        mapHolder.gameObject.AddComponent<Beat>().BeatColor = StepColor;
        mapHolder.GetComponent<Beat>().Delay = Delay;
        mapHolder.GetComponent<Beat>().isPlaying = isPlaying;


        for (int x = 0; x < mapSize.x; x ++) 
        {
            for (int y = 0; y < mapSize.y; y ++)
            {
            
                Vector3 tilePosition = new Vector3(-mapSize.x/2 + 0.5f + x, 0, -mapSize.y/2 + 0.5f + y);
                Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 90)) as Transform;

                newTile.localScale = Vector3.one * (1 - outlinePercent);
                newTile.parent = mapHolder;
                newTile.gameObject.AddComponent<BoxCollider>().size = new Vector3(1,1,0.1f);
                if (y == 9)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = FirstRowSound;
                }
                if (y == 8)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = SecondRowSound;
                }
                if (y == 7)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = ThirdRowSound;
                }
                if (y == 6)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = FourthRowSound;
                }
                if (y == 5)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = FithRowSound;
                }
                if (y == 4)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = SixthRowSound;
                }
                if (y == 3)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = SeventhRowSound;
                }
                if (y == 2)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = EighthRowSound;
                }
                if (y == 1)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = NinethRowSound;
                }
                if (y == 0)
                {
                    newTile.gameObject.AddComponent<AudioSource>().clip = TenthRowSound;
                }
                newTile.gameObject.AddComponent<Note>();
            }
        }     
    }
}
