using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BtPesquisar : MonoBehaviour {

	List<GameObject> markers = new List<GameObject>();

    public DontDestroyMarkers markers_;

    public void BackToDefaultState()
    {
        markers = markers_.returnListOfMarkers();

        for (int i = 0; i < markers.Count; i++)
        {
            markers[i].GetComponent<Directions>().InsertDirection(-1);
        }

    }

}
