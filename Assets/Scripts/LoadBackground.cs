using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBackground : MonoBehaviour
{

    [SerializeField] Image background;
    [SerializeField] Sprite[] images;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, images.Length - 1);
        background.sprite = images[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
