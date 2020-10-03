using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameCredit: MonoBehaviour
{
    [SerializeField] Button _backToButton;
    // Start is called before the first frame update
    void Start()
    {
        _backToButton.onClick.AddListener(delegate { BackCreToMainMenuButtonClick(_backToButton); });
    }

    // Update is called once per frame
    void Update()
    { 

    }
    public void BackCreToMainMenuButtonClick(Button button)
        {
            SceneManager.UnloadSceneAsync("SceneCredit");
            SceneManager.LoadScene("SceneMainMenu");
        } 
    }
