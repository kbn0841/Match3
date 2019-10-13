using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TileItem : MonoBehaviour
{
    
	void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        Vector3 punchScale = new Vector3(0.05f, 0.05f, 0.05f);

        transform.DOPunchScale(punchScale, 1.0f);
    }
}
