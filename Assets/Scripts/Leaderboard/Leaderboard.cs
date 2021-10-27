using System.Collections;

using UnityEngine;
 
using System.Collections.Generic;

using TMPro;
 
public static class Leaderboard {
    public const int EntryCount = 10;
 
    public struct ScoreEntry {
        public string name;
        public int score;
 
        public ScoreEntry(string name, int score) {
            this.name = name;
            this.score = score;
        }
    }
 
    public static List<ScoreEntry> s_Entries;
 
    public static List<ScoreEntry> Entries {
        get {
            if (s_Entries == null) {
                s_Entries = new List<ScoreEntry>();
                LoadScores();
            }
            return s_Entries;
        }
    }
 
    private const string PlayerPrefsBaseKey = "leaderboard";
 
    private static void SortScores() {
        s_Entries.Sort((a, b) => b.score.CompareTo(a.score));
    }
 
    private static void LoadScores() {
        s_Entries.Clear();

        for (int i = 0; i < EntryCount; ++i) {
            ScoreEntry entry;
            entry.name = PlayerPrefs.GetString(PlayerPrefsBaseKey + "[" + i + "].name", "");
            entry.score = PlayerPrefs.GetInt(PlayerPrefsBaseKey + "[" + i + "].score", 0);
            s_Entries.Add(entry);
        }
 
        SortScores();
    }
 
    private static void SaveScores() {
        for (int i = 0; i < EntryCount; ++i) {
            var entry = s_Entries[i];
            PlayerPrefs.SetString(PlayerPrefsBaseKey + "[" + i + "].name", entry.name);
            PlayerPrefs.SetInt(PlayerPrefsBaseKey + "[" + i + "].score", entry.score);
        }
    }

    public static ScoreEntry GetEntry(int index) {
        return Entries[index];
    }

    public static void Clear() {
        for (int i = 0; i < EntryCount; ++i)
            s_Entries[i] = new ScoreEntry("", 0);
        SaveScores();
    }
 
    public static void Record(string name, int score) {
        Entries.Add(new ScoreEntry(name, score));
        SortScores();
        Entries.RemoveAt(Entries.Count - 1);
        SaveScores();
    }

        public static bool CheckScore(int currentScore) {
        for (int i = 0; i < EntryCount; ++i) {
            if(Entries[i].score < currentScore)
                {
                    return true;
                }
        }
        return false;
    }
    
}