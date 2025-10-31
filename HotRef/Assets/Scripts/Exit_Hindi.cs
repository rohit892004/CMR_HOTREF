using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    public string languageSelectionScene = "CMR_Hot_Refining_VR_Language_Selection";

    public void ExitTraining()
    {
        SceneManager.LoadScene(languageSelectionScene);
    }
}
