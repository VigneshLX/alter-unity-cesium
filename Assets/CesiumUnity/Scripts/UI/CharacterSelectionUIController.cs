using Alter.Cesiumunity.Common;
using Alter.CesiumUnity.Player;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Alter.CesiumUnity.Controller
{
    public class CharacterSelectionUIController : MonoBehaviour
    {
        [SerializeField] public List<CharacterContent> characters = new List<CharacterContent>();

        private void Start()
        {
            characters[0].character.gameObject.SetActive(true);
        }
        public void HideAllCharacter()
        {
            foreach (var characterContent in characters)
            {
                characterContent.character.SetActive(false);
            }
        }

        public void OnSelectButtonPressed(GameObject selectedCharacter)
        {
            foreach (var item in characters)
            {
                if (item.character.name == selectedCharacter.name)
                {
                    UserManager.Instance.SetUserCharacter(selectedCharacter, item.avatar); //the selected character is the original fbx imported that we gonna use in the main scene
                    break;
                }

            }
        }

        public void OnDiveInButtonClicked()
        {
            SceneManager.LoadSceneAsync(1);
        }
    }
}
