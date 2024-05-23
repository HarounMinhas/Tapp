using Microsoft.AspNetCore.Components;

namespace TappBlazor.Pages;

public class OpmaakBase : ComponentBase
{
    public static string GetBadgeKleur(int statusId)
    {
        string badgeKleur = String.Empty;
        switch (statusId)
        {
            case 1:
                badgeKleur = "bg-success";
                break;
            case 2:
                badgeKleur = "bg-dark";
                break;
            case 3:
                badgeKleur = "bg-warning";
                break;
            default:
                badgeKleur = "bg-light";
                break;
        }
        return badgeKleur;
    }
}
