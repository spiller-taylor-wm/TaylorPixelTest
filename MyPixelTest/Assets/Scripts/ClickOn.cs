using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    public GameObject Player;
    private Material mat;



    public void ClickMe()
    {

        if (gameObject.CompareTag("Red"))
        {
            Player.GetComponent<ColorPicker>().RedColor();
        }
        else if (gameObject.CompareTag("Blue"))
        {
            Player.GetComponent<ColorPicker>().BlueColor();
        }
        else if (gameObject.CompareTag("Green"))
        {
            Player.GetComponent<ColorPicker>().GreenColor();
        }

    }
}
public class ColorPicker : MonoBehaviour
{
    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;
    public GameObject[] color;


    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void BlueColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    public void RedColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    public void GreenColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }


}