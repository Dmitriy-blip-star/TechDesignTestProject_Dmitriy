using UnityEngine;
using UnityEngine.SceneManagement;

public class button_switch_scene : MonoBehaviour
{
    public void SwitchScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
