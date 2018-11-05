using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour {

    public int arrowDirection;

    public GameObject arrow_1, arrow_2, arrow_3, arrow_4;

    public GameObject canvasPesquisar;
    public GameObject canvasDefault;
    public GameObject canvasArrived;
    // Use this for initialization
    void Start () {
        arrow_1.SetActive(false);
        arrow_2.SetActive(false);
        arrow_3.SetActive(false);
        arrow_4.SetActive(false);
        canvasPesquisar.SetActive(false);
        canvasDefault.SetActive(false);
        canvasArrived.SetActive(false);
    }
	
    public void InsertDirection(int direction) {
        arrowDirection = direction;
    }

    // Update is called once per frame
    void Update () {
        switch (arrowDirection) {
            case 1:
                arrow_1.SetActive(true);
                arrow_2.SetActive(false);
                arrow_3.SetActive(false);
                arrow_4.SetActive(false);
                canvasPesquisar.SetActive(false);
                canvasDefault.SetActive(true);
                canvasArrived.SetActive(false);
                break;
            case 2:
                arrow_1.SetActive(false);
                arrow_2.SetActive(true);
                arrow_3.SetActive(false);
                arrow_4.SetActive(false);
                canvasPesquisar.SetActive(false);
                canvasDefault.SetActive(true);
                canvasArrived.SetActive(false);
                break;
            case 3:
                arrow_1.SetActive(false);
                arrow_2.SetActive(false);
                arrow_3.SetActive(true);
                arrow_4.SetActive(false);
                canvasPesquisar.SetActive(false);
                canvasDefault.SetActive(true);
                canvasArrived.SetActive(false);
                break;
            case 4:
                arrow_1.SetActive(false);
                arrow_2.SetActive(false);
                arrow_3.SetActive(false);
                arrow_4.SetActive(true);
                canvasPesquisar.SetActive(false);
                canvasDefault.SetActive(true);
                canvasArrived.SetActive(false);
                break;
            case -1:
                arrow_1.SetActive(false);
                arrow_2.SetActive(false);
                arrow_3.SetActive(false);
                arrow_4.SetActive(false);
                canvasPesquisar.SetActive(true);
                canvasDefault.SetActive(false);
                canvasArrived.SetActive(false);
                break;
            case 0:
                arrow_1.SetActive(false);
                arrow_2.SetActive(false);
                arrow_3.SetActive(false);
                arrow_4.SetActive(false);
                canvasPesquisar.SetActive(false);
                canvasDefault.SetActive(true);
                canvasArrived.SetActive(true);
                break;

        }
	}
}
