using Alter.CesiumUnity.Utils;
using UnityEngine;

namespace Alter.CesiumUnity.Player
{
    public class UserManager : GenericSingletonClassPersistant<UserManager>
    {
        public GameObject userCharacter { get; private set; }
        public Avatar userAvatar { get; private set; }

        public void SetUserCharacter(GameObject character, Avatar avatar)
        {
            userCharacter = character;
            userAvatar = avatar;
        }
    }
}

