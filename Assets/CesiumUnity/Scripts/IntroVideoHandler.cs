using UnityEngine;
using UnityEngine.Video;

namespace Alter.CesiumUnity.Controller
{
    public class IntroVideoHandler : MonoBehaviour
    {
        [SerializeField] private VideoPlayer player;
        [SerializeField] private GameObject characterSection;
        private void Start()
        {
            player.loopPointReached += ShowCharacterSelection;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ShowCharacterSelection(player);
        }

        private void ShowCharacterSelection(VideoPlayer source)
        {
            source.enabled = false;
            characterSection.SetActive(true);
        }

    }
}
