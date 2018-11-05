using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToSelectType : MonoBehaviour {

    public GameObject areaType;
    public GameObject selectType;

	public void BackToSelectTypeSearch()
    {
        areaType.SetActive(false);
        selectType.SetActive(true);
    }
}
