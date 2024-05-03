using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    private Transform cameraObject;
    void Awake()
    {
        cameraObject = GetComponent<Transform>();

        if (PlayerPrefs.HasKey("PlayerName"))
        {
            GameObject player = Instantiate(Resources.Load("Person/" + PlayerPrefs.GetString("PlayerName"))) as GameObject;
            player.transform.localPosition = new Vector3(-138, 60, -69);
            player.transform.localRotation = new Quaternion(0, 0, 0, 0);
            player.transform.localScale = new Vector3(8, 8, 8);
            player.tag = "Player";

            Rigidbody playerRigitbody = player.GetComponent<Rigidbody>();
            playerRigitbody.freezeRotation = true;

            player.GetComponent<BoxCollider>();
            player.AddComponent<Running>();


            player.name = PlayerPrefs.GetString("PlayerName");

            cameraObject.SetParent(player.transform, false);
            cameraObject.localPosition = new Vector3(0, 2.2f, -4f);
            cameraObject.Rotate(0, 0, 0);
        }



    }
}
