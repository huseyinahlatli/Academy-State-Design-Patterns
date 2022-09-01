using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header ("State Texts")]
    public TextMeshProUGUI stateText;
    public GameObject defenceText;
    public GameObject attackText;
    
    public IConsoleController ConsoleController;
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        Startup();
    }
    
    public void Square() { ConsoleController.PressSquare(); }
    public void Triangle() { ConsoleController.PressTriangle(); }
    public void Circle() { ConsoleController.PressCircle(); }
    public void KeyX() { ConsoleController.PressX(); }
    
    public void SetStateText(GameObject visibleText, GameObject hiddenText)
    {
        visibleText.SetActive(true);
        hiddenText.SetActive(false);
        stateText.text = null;
    }

    private void Startup()
    {
        ConsoleController = new Defence();
        SetStateText(defenceText, attackText);
    }
}
