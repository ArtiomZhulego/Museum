using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class RaycastPicture : MonoBehaviour
{
    public TMP_Text CanvasText;
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,40);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Belarus":
                    CanvasText.text = "Hажмите <color=orange>Е</color> для путешествия в мир Аграрно-экономического колледжа Республики Беларусь";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("http://ggaek.by/" + Application.identifier);
                    }
                    break;
                case "Cinema":
                    CanvasText.text = "Hажмите <color=green>Е</color> для путешествия в мир киносьёмки Беларуси";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(3);
                    }
                    break;
                case "Kitchen":
                    CanvasText.text = "Hажмите <color=green>Е</color> для путешествия на кухню Республики Беларусь";
                    break;
                case "ArtGalery":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с миром живописи Республики Беларусь";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(4);
                    }
                    break;
                case "Finish":
                    CanvasText.text = "Вы просмотрели все доступные локации, для выхода к главному меню необходимо нажать <color=green>Е</color>";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("StartScene");
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                    break;
                /*case "Bookcase":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с библиотекой";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(5);
                    }
                    break;*/
                case "BookcaseSummer":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с мультиком о Лете";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://vk.com/video-54443855_168050768" + Application.identifier);
                    }
                        break;
                case "BookcaseAutumn":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с мультиком о Осени";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=w66cJV5k3Rk&t=60s" + Application.identifier);
                    }
                    break;
                case "BookcaseWinter":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с мультиком о Зиме";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=9ZQ43LLjLfY&t=7s" + Application.identifier);
                    }
                    break;
                case "BookcaseSpring":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с мультиком о Весне";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://vk.com/video/@sovmultinfo" + Application.identifier);
                    }
                    break;
                case "BookcaseAll":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с мультфильмом про времена года";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=1PVZGivbAOY" + Application.identifier);
                    }
                    break;
                case "LeaveSCENE":
                    CanvasText.text = "Hажмите <color=green>Е</color> для выхода из костюм сцены";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(2);
                    }
                    break;
                case "SignSCE":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с областями Гомеля";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(5);
                    }
                    break;
            }
        }
    }
}
