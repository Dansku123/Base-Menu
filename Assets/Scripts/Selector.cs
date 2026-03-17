using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Selector : MonoBehaviour
{

    public Color normalColor = Color.white;
    public Color selectedColor = Color.black;
    public TMP_Text [] items;
    private int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeColors();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index + 1) % items.Length;
            changeColors();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            changeColors();
        }
    }

    void changeColors()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                items[i].color = selectedColor;
            }
            else
            {
                items[i].color = normalColor;
            }
        }
    }
}