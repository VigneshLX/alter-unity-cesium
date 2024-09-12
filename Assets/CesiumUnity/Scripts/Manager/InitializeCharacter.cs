using Alter.CesiumUnity.Player;
using UnityEngine;

namespace Alter.Cesiumunity.Player
{
    public class InitializeCharacter : MonoBehaviour
    {
        [SerializeField] private Animator thirdPersonAnimator;
        private void Awake()
        {
            var character = Instantiate(UserManager.Instance.userCharacter, this.transform);
            thirdPersonAnimator.avatar = UserManager.Instance.userAvatar;
        }
    }
}
