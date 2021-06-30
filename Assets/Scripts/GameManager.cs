using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public Text _recordText;
    public Text _scoreText;
    public Text _livesText;
    public Text _lastScoreText;

    public GameObject panelGame;
    public GameObject panelStart;
    public GameObject panelGameOver;
    public GameObject _player;
    GameObject player;
    
    public static GameManager Instance { get; private set; }

    private int _score;
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            _scoreText.text = "SCORE : " + _score;
        }
    }

    private int _lives=10;
    public int Lives
    {
        get { return _lives; }
        set
        {
            _lives = value;
            _livesText.text = "LIVES : " + _lives;
        }
    }


    public void PlayClicked()
    {
        panelStart.SetActive(false);
        panelGame.SetActive(true);
        panelGameOver.SetActive(false);

        _lives = 10;
        _score = 0;

        player =Instantiate(_player, new Vector3(0, -7, 0), new Quaternion(0, 0, 0,0));
        _recordText.text = "RECORD : " + PlayerPrefs.GetInt("record").ToString();
        _livesText.text = "LIVES : " + _lives;
        _scoreText.text = "SCORE : " + _score;

    }

    // Use this for initialization
    void Start () {
        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (_lives == 0)
        {
            if (_score > PlayerPrefs.GetInt("record"))
            {
                PlayerPrefs.SetInt("record", _score);
            }
            _lastScoreText.text = "RECORD: "+ _score.ToString();
            panelGame.SetActive(false);
            panelGameOver.SetActive(true);
            Destroy(player);
          

        }
	}
}
