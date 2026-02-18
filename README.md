# 🧩 Game-Logic-Maze: Twin Reunion

A strategic 2D/3D puzzle-platformer built with **Unity** and **C#**. This project challenges players with complex environmental puzzles that require coordinated logic and state management between two separate entities.

---

## 🚀 Overview
**Game-Logic-Maze** (Twin Reunion) is more than just a platformer; it's a test of logical coordination. The core gameplay revolves around a **Character-Switching Mechanic**, where the player must manipulate two characters to solve interdependent puzzles. This project showcases advanced **Unity C# scripting**, physics-based interactions, and level design.

---

## 🧠 Game Logic & Mechanics

The project implements several sophisticated systems to ensure a smooth and challenging experience:

### 1. Dual-Character Coordination
* **Character Switching:** Implemented a robust state management system to toggle control between two entities while maintaining their world states.
* **Interdependent Puzzles:** Designed triggers and environmental obstacles that require one character to hold a state (e.g., standing on a pressure plate) for the other to progress.

### 2. Level Design & Environmental Logic
* **Logic-Gated Progress:** Used C# events and delegates to handle gate systems, elevators, and moving platforms.
* **Physics Integration:** Optimized Unity's Physics engine for precise platforming and object interaction.

### 3. Object-Oriented Architecture
* **Modular Codebase:** Leveraged C# Inheritance and Interfaces to create reusable scripts for interactable objects (buttons, levers, doors).
* **Version Control:** Maintained a clean repository structure, utilizing `.gitignore` for Unity's specific metadata and temporary files.

---

## 🛠️ Tech Stack
* **Game Engine:** Unity (202X.x)
* **Programming Language:** C# (Advanced Scripting)
* **Version Control:** Git / GitHub
* **Assets:** Custom assets integrated with Unity's URP (Universal Render Pipeline).

---

## 🎮 How to Play

### Option 1: Direct Play (Windows Build)
If you just want to play the game, download the standalone executable:
1. Navigate to the [Releases](https://github.com/61xo/Game-Logic-Maze/Logic-Maze) section.
2. Download `Logic-Maze`.
3. Extract and run `Logic-Maze.exe`.

> **Note for Linux (Arch) Users:** You can run the executable using **Wine**:
> ```bash
> wine TwinReunion.exe
> ```

### Option 2: Run in Unity (Development)
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/61xo/Game-Logic-Maze.git](https://github.com/61xo/Game-Logic-Maze.git)
