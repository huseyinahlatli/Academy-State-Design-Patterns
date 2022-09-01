using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            GameManager.Instance.ConsoleController = new Defence();
            GameManager.Instance.SetStateText(GameManager.Instance.defenceText, GameManager.Instance.attackText);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            GameManager.Instance.ConsoleController = new Attack();
            GameManager.Instance.SetStateText(GameManager.Instance.attackText, GameManager.Instance.defenceText);
        }
        
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            GameManager.Instance.Triangle();
        
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            GameManager.Instance.KeyX();
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            GameManager.Instance.Square();
        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            GameManager.Instance.Circle();
    }
}
