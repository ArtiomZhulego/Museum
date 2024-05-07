using UnityEngine;

public class LightSlider : MonoBehaviour
{
    public GameObject objectToMove;

    // ������� ������� ��� ����������� �������
    public delegate void ObjectMovedEvent();
    public static event ObjectMovedEvent OnObjectMoved;

    private void OnMouseDown()
    {
        UpdateObjectPosition();
    }

    private void OnMouseDrag()
    {
        UpdateObjectPosition();
    }

    private void UpdateObjectPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            objectToMove.transform.position = hit.point;

            // �������� ������� OnObjectMoved
            OnObjectMoved?.Invoke();
        }
    }
}