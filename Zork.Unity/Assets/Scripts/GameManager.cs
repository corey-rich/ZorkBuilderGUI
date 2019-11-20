using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Zork.Common;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFilename = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private Text ScoreText;

    [SerializeField]
    private Text MovesText;

    [SerializeField]
    private Text LocationText;

    private Game Game { get; set; }

    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFilename);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);
        Game.Player.ScoreChanged += Player_ScoreChanged;
        Game.Player.MovesChanged += Player_MovesChanged;
        Game.Player.LocationChanged += Player_LocationChanged;
    }

    private void Player_LocationChanged(object sender, string e)
    {
        LocationText.text = $"Location: {Game.Player.LocationName}";
    }

    private void Player_ScoreChanged(object sender, int e)
    {
        ScoreText.text = $"Score: {Game.Player.Score}";
    }

    private void Player_MovesChanged(object sender, int e)
    {
        MovesText.text = $"Moves: {Game.Player.Moves}";
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            if(string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
                InputService.ProcessInput();
            }
            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }

        if(Game.IsRunning == false)
        {
            EditorApplication.isPlaying = false;
        }
    }
}
