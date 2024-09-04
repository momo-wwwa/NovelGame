using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace NovelGame
{
    public class UserScriptManager : MonoBehaviour
    {
        [SerializeField] List<TextAsset> _scenarioFiles; // 複数のシナリオファイルを格納するリスト

        // 現在のシナリオの文を格納するリスト
        List<string> _sentences = new List<string>();

        void Awake()
        {
            // デフォルトのシナリオを読み込む
            LoadScenario(0); // デフォルトのシナリオインデックスは必要に応じて変更可能
        }

        // 指定されたシナリオ番号に基づいてシナリオを読み込む
        public void LoadScenario(int scenarioNumber)
        {
            if (scenarioNumber < 0 || scenarioNumber >= _scenarioFiles.Count)
            {
                Debug.LogError("無効なシナリオ番号です！");
                return;
            }

            _sentences.Clear(); // 以前のシナリオの文をクリアする
            StringReader reader = new StringReader(_scenarioFiles[scenarioNumber].text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                _sentences.Add(line);
            }

            // GameManager の行番号をリセット
            GameManager.Instance.lineNumber = 0;
        }

        // 現在の行の文を取得する
        public string GetCurrentSentence()
        {
            if (GameManager.Instance.lineNumber < _sentences.Count)
            {
                return _sentences[GameManager.Instance.lineNumber];
            }
            return string.Empty;
        }

        // 文が命令かどうかを確認する
        public bool IsStatement(string sentence)
        {
            return sentence.Length > 0 && sentence[0] == '&';
        }

        // 命令を実行する
        public void ExecuteStatement(string sentence)
        {
            string[] words = sentence.Split(' ');
            switch (words[0])
            {
                case "&img":
                    GameManager.Instance.imageManager.PutImage(words[1], words[2]);
                    break;
                case "&rmimg":
                    GameManager.Instance.imageManager.RemoveImage(words[1]);
                    break;
                    // 必要に応じて他の命令も追加
            }
        }
    }
}
