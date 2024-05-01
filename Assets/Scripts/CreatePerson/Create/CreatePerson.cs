using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreatePerson : MonoBehaviour
{
    public GameObject _panel;

    private RectTransform rect;

    public GameObject Parent;

    public string[] massFolderFiles;

    private string mypath;

    public List<string> items;

    public string[] _item;

    private int top = 200;

    private int bottom = 800;

    private int createPerson = 0; 

    private void Start()
    {
        mypath = Application.dataPath + "/Resources/Models";
        massFolderFiles = Directory.GetFiles(mypath).ToArray<string>();

        foreach (string item in massFolderFiles)
        {
            if (item.Length > 10)
            {
                _item = item.Split('\\');
            }

            if (_item[1] != null)
            {
                try
                {
                    if (_item[1].Split('.')[1] == "prefab" && _item[1].Split('.').Length == 2)
                    {
                        items.Add(_item[1].Split('.')[0]);
                    }

                }
                catch
                {
                }

            }

        }

        if (items.Count > 0 && createPerson <= 6)
        {

            for (int i = 0; i < items.Count && createPerson <= 6; i++)
            {
                GameObject panel = Instantiate(_panel, new Vector3(), Quaternion.identity);
                panel.transform.SetParent(Parent.transform);

                rect = panel.GetComponent<RectTransform>();
                SetPadding(rect, 15, top, 15, bottom);

                rect.transform.localScale = Vector3.one;
                rect.transform.localRotation = Quaternion.identity;
                rect.transform.localPosition = new Vector3(rect.localPosition.x, rect.localPosition.y, 0);

                top += 80;
                bottom -= 80;

                Transform child = panel.transform.Find("Name");
                TMP_Text _text = child.GetComponent<TMP_Text>();

                if (_text != null)
                {
                    _text.text = items[i];
                }

                createPerson++;
            }
        }

    }

    static void SetPadding(RectTransform rect, float left, float top, float right, float bottom)
    {
        rect.offsetMax = new Vector2(-right, -top);
        rect.offsetMin = new Vector2(left, bottom);
    }
}
