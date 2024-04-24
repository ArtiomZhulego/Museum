using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSlider : MonoBehaviour
{
    public GameObject _checkBox;
    public Vector3 GameObj;
    public GameObject objectToMove;
    private void OnMouseDown()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            objectToMove.transform.position = hit.point;
        }

    }

    private void OnMouseDrag()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity) && hit.transform.tag == "slider") objectToMove.transform.position = hit.point;

    }
}
