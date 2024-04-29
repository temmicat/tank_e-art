using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    private UIDocument _document;
    
    // Start is called before the first frame update
    void Start()
    {
        _document = GetComponent<UIDocument>();
        VisualElement _root = _document.rootVisualElement;

        Button buttonPlay = _root.Q<Button>("PlayButton");
        if(buttonPlay is not null)
        {
            buttonPlay.RegisterCallback<ClickEvent>(OnClickedPlay);
        }
        
        Button buttonQuit = _root.Q<Button>("QuitButton");
        if(buttonQuit is not null)
        {
            buttonQuit.RegisterCallback<ClickEvent>(OnClickedQuit);
        }
    }

    private void OnClickedPlay(ClickEvent evt)
    {
        Debug.Log("J'ai cliqué sur le bouton Play.");
        SceneManager.LoadScene("tuto");
    }

    private void OnClickedQuit(ClickEvent evt)
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
