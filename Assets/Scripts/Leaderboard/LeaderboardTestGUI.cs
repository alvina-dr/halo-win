using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class LeaderboardTestGUI : MonoBehaviour {
    private string _nameInput = "";
    private string _scoreInput = "0";

    public TMP_Text FirstName;
    public TMP_Text FirstScore;

    public TMP_Text SecondName;
    public TMP_Text SecondScore;

    public TMP_Text ThirdName;
    public TMP_Text ThirdScore;

    public TMP_Text FourthName;
    public TMP_Text FourthScore;

    public TMP_Text FiveName;
    public TMP_Text FiveScore;

    public TMP_Text SixName;
    public TMP_Text SixScore;

    public TMP_Text SevenName;
    public TMP_Text SevenScore;

    public TMP_Text EightName;
    public TMP_Text EightScore;

    public TMP_Text NineName;
    public TMP_Text NineScore;

    public TMP_Text TenName;
    public TMP_Text TenScore;
 
    private void OnGUI() {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
 
        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(0);
            FirstName.text = entry.name;
            FirstScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(1);
            SecondName.text = entry.name;
            SecondScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(2);
            ThirdName.text = entry.name;
            ThirdScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(3);
            FourthName.text = entry.name;
            FourthScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(4);
            FiveName.text = entry.name;
            FiveScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(5);
            SixName.text = entry.name;
            SixScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(6);
            SevenName.text = entry.name;
            SevenScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(7);
            EightName.text = entry.name;
            EightScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(8);
            NineName.text = entry.name;
            NineScore.text = entry.score.ToString();
        }

        for (int i = 0; i < Leaderboard.EntryCount; ++i) {
            Leaderboard.ScoreEntry entry = Leaderboard.GetEntry(9);
            TenName.text = entry.name;
            TenScore.text = entry.score.ToString();
        }

        
 
        _nameInput = GUILayout.TextField(_nameInput);
        _scoreInput = GUILayout.TextField(_scoreInput);
 
        if (GUILayout.Button("Record")) {
            int score;
            int.TryParse(_scoreInput, out score);
 
            Leaderboard.Record(_nameInput, score);
 
            // Reset for next input.
            _nameInput = "";
            _scoreInput = "0";
        }

        if (GUILayout.Button("Clear")) {
            Leaderboard.Clear();
        }

    }
}

