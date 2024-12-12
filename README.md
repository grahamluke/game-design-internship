# Unity Prototype: Phase Shift, Stim, and Cloak Mechanics

This project is a Unity prototype demonstrating three common gameplay mechanics: Phase Shift, Stim, and Cloak. Each mechanic is implemented using simple scripts and is designed for easy integration and testing.

---

## Mechanics

### 1. Phase Shift
- Key: `Q`  
- Temporarily makes the player invulnerable and changes their appearance.  

### 2. Stim
- Key: `E`  
- Temporarily increases player speed and regenerates health.  

### 3. Cloak
- Key: `C`  
- Temporarily makes the player invisible.

---

## How to Use

1. Clone or Download the Project:
   - Open Unity.
   - Import the project files into your workspace.

2. Play the Prototype:
   - Press Play in the Unity Editor.
   - Use the following keys to activate mechanics:
     - `Q` for Phase Shift.
     - `E` for Stim.
     - `C` for Cloak.

---

## Setup Notes

- The `Player` object must have:
  - A `Renderer` component for material changes.
  - A `CharacterController` for movement (used in Stim).
  - A `HealthSystem` script for health regeneration (used in Stim).

- Materials for effects:
  - Phase Material: For the ghostly look during Phase Shift.
  - Invisible Material: Fully transparent for Cloak.

---

## File Overview

- Scripts:
  - `PhaseShift.cs`
  - `Stim.cs`
  - `Cloak.cs`
  - `HealthSystem.cs` (for health regeneration in Stim)
- Materials:
  - Configurable materials for normal, phase, and invisible states.

---

## Customization

- Modify values (e.g., duration, speed, materials) directly in the Unity Inspector for each script to suit your needs.

---
