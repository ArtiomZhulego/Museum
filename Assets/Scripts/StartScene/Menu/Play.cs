using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public new GameObject gameObject;
    
    private void OnMouseDown()
    {
        gameObject.SetActive(true); 
    }
    private void SceneChange(int index)
    {
        
        SceneManager.LoadScene(index);
    }
}
