# Better Crystal Heart
This mod enhances Crystal Heart to be a viable attack in 
combat.

Crystal Heart's charging time is reduced when 
Sprintmaster, Dashmaster and Quick Focus are equipped. 
This bonus is based on their notch costs, with the maximum
bonus being a 44% reduction.

Crystal Heart now deals damage equal to a fraction of the 
enemy's max health. This bonus is based on the player's 
max health, and is increased by 36% if Deep Focus is 
equipped.

So if a player has 9 Masks, a fully upgraded nail, and 
Sprintmaster, Dashmaster, Quick Focus and Deep Focus 
equipped, Crystal Heart will take about 0.44 seconds to 
charge and will deal about 120 extra damage to an enemy
with 1000 health.

Additionally, both bonuses can be customized using the 
menu plugin. The maximum value is 100%, doubling all 
bonuses to damage and charge time, and the minimum value 
is -100%, negating all bonuses.

## Synergies
- Dynamic Crystal Dash now has a synergy that is toggled
via the mod menu. If the synergy is active and the mod is
installed, the damage is multiplied based on how much
faster (or slower) the CDash is compared to the default.
This bonus is further enhanced by the same charm synergy
as the charge time bonus, since Dynamic CDash negates
that bonus.

## Patch Notes
1.2.0.0
- Synergy added with Dynamic Crystal Dash

1.1.1.0
- Bug fix limiting scope of the "remove input delay" code

1.1.0.0
- Removed input delay from Crystal Heart, making it easier to trigger quickly
- Improved logic for getting enemy health so initial CDash doesn't do less than 1% damage
- Added nail damage to damage bonus
