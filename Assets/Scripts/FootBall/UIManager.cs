using FootBall;
using UnityEngine;
using UnityEngine.UI;

namespace Football
{
    public class UIManager : MonoBehaviour
    {
        public GameObject SettingsMenu;

        public Image TeamUiImage;

        private void OnEnable()
        {
            PlayerTeamHandler.OnLocalPlayerTeamChanged += UpdateTeamUI;
        }

        private void OnDisable()
        {
            PlayerTeamHandler.OnLocalPlayerTeamChanged -= UpdateTeamUI;
        }

        private void UpdateTeamUI(Team team)
        {
            TypeLogger.TypeLog(this, $"Changed team UI color to {team.ToString()}", 1);
            TeamUiImage.gameObject.SetActive(true);
            TeamUiImage.color = Colors.TeamColors[team];
        }

        private void Update()
        {
            if (InputManager.Data.ToggleMenuTriggered)
            {
                SettingsMenu.SetActive(!SettingsMenu.activeInHierarchy);
            }
        }
    }
}

