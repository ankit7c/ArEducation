using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wiki2 : MonoBehaviour
{
    private Button linkopener;
    public string urlinput;
    // Start is called before the first frame update
    void Start()
    {
        linkopener = GameObject.Find("Link").GetComponent<Button>();
        linkopener.onClick.AddListener(open1);
    }

    // Update is called once per frame
    void open1()
    {
        Application.OpenURL(urlinput);
    }
}
