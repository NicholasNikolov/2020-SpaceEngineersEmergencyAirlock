# 2020-SpaceEngineersEmergencyAirlock
 
 NOTE: The code is ugly, yes. The editor is very difficult to work with. There is not realtime feedback and it's honestly hard to differentiate the different types of brackets/parenthesis. That's why everything is build into the main method.
 
 # Instructions:
 1. Ensure you have an air vent in the room or rooms you want to be part of the lockdown procedures. 
 2. Ensure you have a door leading into the room or rooms that is part of the lockdown procedures.
 3. Ensure you have a light tied to the door/room or doors/rooms that is part of the lockdown procedures.
 4. Name all of these the same thing. E.g., name your air vent, door, and light "rm1." They should have the same name (this is how my script detects which objects are linked most easily.
 5. Place a programmable block that's connected to these doors.
 6. Paste the script in
 7. Profit??
 
 # Description
 The script will continuously run during the lifetime of the ship (power required) and continuously monitor whether a room can be pressurized. As soon as any vent detects a depressurization, all ship doors will close at once.
 
 Then, the ship will scan all rooms to evaluate whether or not the rooms are re-pressurizing. If yes, then those doors will remain open and the user can go through.
 
 However, if a room is depressurized, the door will be locked (turned off) and prevent the user from turning it back on. The emergency light will begin flashing above that door and an alarm will sound until the hull breach is repaired.
 
 
 # Future Features:
 - Currently, my ship design is a narrow hallway with doors along the hallway, the cockpit on the front end, and the engine room on the back end. Presently, if the cockpit, engine room, or any room is breached, the code will work. HOWEVER, if the hallway is breached, the room doors will not lock since they'll detect a repressurization. I'm considering solutions beyond locking all doors (problematic since you would be trapped in a room and unable to access the ship's exit). Perhaps a monitor in every room can display which room is breached?
 
 
 
 _______________________________________________________________________________________________________________________________________
 
 Code for Space Engineers that locks doors based on compromised hull.

Space Engineers is a voxel-based building game wherein the player designs a ship, including connections for air and fuel.

Each ship can be pressurized and heated through a series of vents that transport oxygen through the craft. If this hull is depressurized, then the oxygen level and temperature will swiftly drop which, in a survival game mode, would mean swift death if not repaired.

The code works by finding objects with the same name. You group your warning light, door, and air vent by calling them the same custom name. E.g., my room 1 air vent was called "rm1", the room 1 door was called "rm1" and the room 1 warning light was called "rm1".

Then the system closes all doors at detection of the hull breach.

The script will then run through and evaluate all rooms and their pressurization. If a room shows that it is pressurized, the system will keep the door unlocked (still closed) and not turn on a warning light. However, if a room cannot pressurize, then the system will turn the light on and shut down all access to that door (rendering it unusable until the ship is repaired from the outside.

This is sort of a fun project. Nothing too serious here but it is a fun challenge! :)
