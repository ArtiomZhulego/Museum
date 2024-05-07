using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public BoxCollider cameraCollider;

    private void Start()
    {
        cameraCollider = GetComponent<BoxCollider>();
        Debug.Log("Start метод вызван");
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapBox(cameraCollider.bounds.center, cameraCollider.bounds.extents, transform.rotation);
        bool isColliding = false;

        foreach (Collider collider in colliders)
        {
            if (collider.isTrigger && collider.CompareTag("PassThrought"))
            {
                isColliding = true;
                break;
            }
        }
        cameraCollider.isTrigger = isColliding;
    }
}