using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    [SerializeField] Button _backButton;

    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate{BackMainMenu(_backButton);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void BackMainMenu(Button button)
        { 
            SceneManager.LoadScene("SceneMainMenu");
        } 
}
