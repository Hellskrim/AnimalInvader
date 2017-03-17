using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public Camera myCamera;

    private GameObject defendersParent;

    // Use this for initialization
    void Start () {
        defendersParent = GameObject.Find("Defenders");
        if (!defendersParent)
        {
            defendersParent = new GameObject("Defenders");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Vector2 rawPos = CalculateMousePosition();
        Vector2 roundedPos = snapToGrip(rawPos);
        GameObject newDefender = Instantiate(Button.selectedDefender, roundedPos, Quaternion.identity);

        newDefender.transform.parent = defendersParent.transform;
    }

    Vector2 snapToGrip(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    Vector2 CalculateMousePosition()
    {
        
        float distanceFromCamera = 10f;
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }
}
