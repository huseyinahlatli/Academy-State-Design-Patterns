public class Attack : IConsoleController
{
    public void PressSquare()
    {
        GameManager.Instance.stateText.text = "Şut çekiliyor!";
    }

    public void PressTriangle()
    {
        GameManager.Instance.stateText.text = "Ara pası veriliyor!";
    }

    public void PressCircle()
    {
        GameManager.Instance.stateText.text = "Havadan pas atılıyor!";
    }

    public void PressX()
    {
        GameManager.Instance.stateText.text = "Kısa pas veriliyor!";
    }
}