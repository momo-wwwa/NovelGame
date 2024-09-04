using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace NovelGame
{
    public class UserScriptManager : MonoBehaviour
    {
        [SerializeField] List<TextAsset> _scenarioFiles; // �����̃V�i���I�t�@�C�����i�[���郊�X�g

        // ���݂̃V�i���I�̕����i�[���郊�X�g
        List<string> _sentences = new List<string>();

        void Awake()
        {
            // �f�t�H���g�̃V�i���I��ǂݍ���
            LoadScenario(0); // �f�t�H���g�̃V�i���I�C���f�b�N�X�͕K�v�ɉ����ĕύX�\
        }

        // �w�肳�ꂽ�V�i���I�ԍ��Ɋ�Â��ăV�i���I��ǂݍ���
        public void LoadScenario(int scenarioNumber)
        {
            if (scenarioNumber < 0 || scenarioNumber >= _scenarioFiles.Count)
            {
                Debug.LogError("�����ȃV�i���I�ԍ��ł��I");
                return;
            }

            _sentences.Clear(); // �ȑO�̃V�i���I�̕����N���A����
            StringReader reader = new StringReader(_scenarioFiles[scenarioNumber].text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                _sentences.Add(line);
            }

            // GameManager �̍s�ԍ������Z�b�g
            GameManager.Instance.lineNumber = 0;
        }

        // ���݂̍s�̕����擾����
        public string GetCurrentSentence()
        {
            if (GameManager.Instance.lineNumber < _sentences.Count)
            {
                return _sentences[GameManager.Instance.lineNumber];
            }
            return string.Empty;
        }

        // �������߂��ǂ������m�F����
        public bool IsStatement(string sentence)
        {
            return sentence.Length > 0 && sentence[0] == '&';
        }

        // ���߂����s����
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
                    // �K�v�ɉ����đ��̖��߂��ǉ�
            }
        }
    }
}
