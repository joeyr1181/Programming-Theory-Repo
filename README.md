# OOP Theory Project

## Overview

This is a simple top-down clicker game built in Unity to demonstrate the **four pillars of Object-Oriented Programming (OOP)**:  
- **Inheritance**  
- **Polymorphism**  
- **Encapsulation**  
- **Abstraction**

Players click on randomly spawning colored shapes to earn points. Different shapes award different points. The goal is to reach the winning score before missing too many shapes.

---

## Gameplay

- Shapes spawn randomly on a plane at set intervals.  
- Click shapes to earn points.  
- Missing shapes (letting them disappear) increases miss count.  
- Game ends when player reaches the winning score (win) or misses 3 shapes (lose).  
- UI includes score display, “To Win” target, and win/lose panels with replay and quit buttons.

---

## How to Play 

1. Enter your name on the start menu and hit **Start**.  
2. Click the shapes before they disappear to earn points.  
3. Avoid missing 3 shapes.  
4. Reach the target score to win!  
5. Use menu buttons to restart, quit, or return to main menu.

---

## Project Structure

- **Shape.cs** (Base class) — Defines common shape behavior.  
- **RedShape.cs, BlueShape.cs, GreenShape.cs** - Inherit from `Shape` and override behavior.  
- **GameManager.cs** — Handles game state, win/lose logic, and UI panels.  
- **ScoreManager.cs** — Tracks and updates score and misses.  
- **ShapeSpawner.cs** — Controls spawning shapes randomly on the plane.  
- **UI Scripts** — Manage menu interactions and scene loading.

---

## Download & Play (for Players/Reviewers)

> [Download OOP Theory Build (Windows)](https://github.com/your-username/OOPTheory/releases/latest)

> Known Issue: Build may not open on some systems due to Unity 2020 LTS compatibility.  
> All scripts and source code are available in the repo for review.


## How to Run (for Developers)

- Open the project in Unity 2020.3.7f1 (or later).  
- Ensure all scenes (`StartMenu`, `Main`) are added to **Build Settings**.  
- Press **Play** in the editor or build the project to a platform of your choice.  

---

## Credits

Created by Joey Rangel as a demonstration of OOP concepts using Unity.
