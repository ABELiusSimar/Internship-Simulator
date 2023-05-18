/*************************************************************************************************
* Copyright 2022 Theai, Inc. (DBA Inworld)
*
* Use of this source code is governed by the Inworld.ai Software Development Kit License Agreement
* that can be found in the LICENSE.md file or at https://www.inworld.ai/sdk-license
*************************************************************************************************/
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Inworld.Sample.UI
{
    /// <summary>
    ///     This class is for each detailed chat bubble.
    /// </summary>
    public class ChatBubble : MonoBehaviour
    {
        /// <summary>
        ///     Set the bubble's property.
        /// </summary>
        /// <param name="charName">The bubble's owner's name</param>
        /// <param name="thumbnail">The bubble's owner's thumbnail</param>
        /// <param name="text">The bubble's content</param>
        public void SetBubble(string charName, Texture2D thumbnail, string text = null)
        {
            m_CharacterName.text = charName;
            m_Icon.texture = thumbnail;
            if (!string.IsNullOrEmpty(text))
                m_TextField.text = text;
        }

        #region Inspector Variables
        [SerializeField] TMP_Text m_TextField;
        [SerializeField] RawImage m_Icon;
        [SerializeField] TMP_Text m_CharacterName;
        // My Stuff
        private GameObject _SelectJudgement;
        public bool JudgementOpen = false;
        #endregion

        #region Properties
        /// <summary>
        ///     Get/Set the bubble's main content.
        /// </summary>
        public string Text
        {
            get => m_TextField.text;
            set => m_TextField.text = value;
        }
        /// <summary>
        ///     Get the bubble's height.
        /// </summary>
        public float Height => GetComponent<RectTransform>().sizeDelta.y + 20;
        /// <summary>
        ///     Get/Set the bubble's speaker's name.
        /// </summary>
        public string CharacterName
        {
            get => m_CharacterName.text;
            set => m_CharacterName.text = value;
        }
        /// <summary>
        ///     Get/Set the Thumbnail of the bubble.
        ///     NOTE: For the worldspace's floating text, Icon will not be displayed.
        /// </summary>
        public RawImage Icon
        {
            get => m_Icon;
            set => m_Icon = value;
        }
        #endregion

        // My Stuff
        private void Awake()
        {
            // Find the right game object
            _SelectJudgement = GameObject.FindGameObjectWithTag("Judgement");
        }

        private void Update()
        {
            /* To-Do list
             * Create a function here that keeps on reading the audio input to find the right input
             * When the right input is read, open the corresponing judgement system
             */
            if (JudgementOpen == false)
            {
                if (Text.Contains("Of course"))
                {
                    Debug.Log("Judgement 1");
                    _SelectJudgement.GetComponent<JudgementSystem>().Open1();
                }
                else if (Text.Contains("Sure"))
                {
                    Debug.Log("Judgement 2");
                    _SelectJudgement.GetComponent<JudgementSystem>().Open2();
                }
                else if (Text.Contains("Why not"))
                {
                    Debug.Log("Judgement 3");
                    _SelectJudgement.GetComponent<JudgementSystem>().Open3();
                }
                else if (Text.Contains("if you insist"))
                {
                    Debug.Log("Judgement 4");
                    _SelectJudgement.GetComponent<JudgementSystem>().Open4();
                }

                JudgementOpen = true;
            }
        }
    }
}
