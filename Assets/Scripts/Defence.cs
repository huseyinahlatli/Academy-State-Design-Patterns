public class Defence : IConsoleController
{
    public void PressSquare()
    {
        GameManager.Instance.stateText.text = "Top uzaklaştırılıyor!";
    }

    public void PressTriangle()
    {
        GameManager.Instance.stateText.text = "Kaleci savunma için çıkıyor!";
    }

    public void PressCircle()
    {
        GameManager.Instance.stateText.text = "Kayarak müdahele ediliyor!";
    }

    public void PressX()
    {
        GameManager.Instance.stateText.text = "Press yapılıyor!";
    }
}