using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class text : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(player.position.z.ToString("0"));
    }
}
