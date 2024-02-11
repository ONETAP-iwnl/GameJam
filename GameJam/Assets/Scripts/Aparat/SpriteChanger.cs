using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private Image image;

    public void Start()
    {
        image = GetComponent<Image>();
        image.sprite = sprite1;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            image.sprite = sprite2;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            image.sprite = sprite1;
        }
    }
}
