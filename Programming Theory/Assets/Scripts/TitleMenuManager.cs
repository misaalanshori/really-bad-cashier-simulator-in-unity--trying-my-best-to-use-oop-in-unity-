using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenuManager : MonoBehaviour
{
    [SerializeField] TMP_InputField storeNameField;

    private void Start()
    {
        //storeNameField.text = MainManager.Instance.storeName;
    }

    public void EnterStore()
    {
        if (!string.IsNullOrEmpty(storeNameField.text))
        {
            MainManager.Instance.storeName = storeNameField.text;
            SceneManager.LoadScene(1);
        }
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
