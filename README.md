# 2020-SpaceEngineersEmergencyAirlock
 
 NOTE: The code is ugly, yes. The editor is very difficult to work with. There is not realtime feedback and it's honestly hard to differentiate the different types of brackets/parenthesis. That's why everything is build into the main method.
 
 Code for Space Engineers that locks doors based on compromised hull.

Space Engineers is a voxel-based building game wherein the player designs a ship, including connections for air and fuel.

Each ship can be pressurized and heated through a series of vents that transport oxygen through the craft. If this hull is depressurized, then the oxygen level and temperature will swiftly drop which, in a survival game mode, would mean swift death if not repaired.

The code works by finding objects with the same name. You group your warning light, door, and air vent by calling them the same custom name. E.g., my room 1 air vent was called "rm1", the room 1 door was called "rm1" and the room 1 warning light was called "rm1".

Then the system closes all doors at detection of the hull breach.

The script will then run through and evaluate all rooms and their pressurization. If a room shows that it is pressurized, the system will keep the door unlocked (still closed) and not turn on a warning light. However, if a room cannot pressurize, then the system will turn the light on and shut down all access to that door (rendering it unusable until the ship is repaired from the outside.

This is sort of a fun project. Nothing too serious here but it is a fun challenge! :)
