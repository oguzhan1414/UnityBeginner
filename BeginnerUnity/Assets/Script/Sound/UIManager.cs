using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void ButonaBasildi(int hangiButon)
    {
        SoundManager.instance.MusicCal(hangiButon);
    }
}
