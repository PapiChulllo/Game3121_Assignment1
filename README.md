# Game3121 Assignment 1

**Educational Unity assignment (Game3121)** split into two Unity Learn–style challenges:

- **Part1 — Challenge 1:** plane follow-cam, propeller spin, player control, obstacles  
- **Part2 — Challenge 2:** forward-moving animals, spawn manager, destroy out of bounds, collision detect, player dog spawn with **cooldown** (anti-spam)

---

## What was modified

Course starter scripts under each part’s `Challenge N/Scripts/`. Notable student change called out in git history: **dog spawn cooldown** in Part2 (`spawnCooldown = 2s`) so Space cannot spam dogs. Commits also mention Unity Recorder package usage and a recording for submission (Recorder may be package-local; treat recordings as assignment evidence, not a product trailer claim).

**Status / limitations:** **course assignment**, not original IP. Built on Unity **Course Library** challenge content. Unity version in Part trees: **2022.3.46f1**. No automated tests; Editor play not re-verified here.

## Tech stack

| Area | What it uses |
|---|---|
| Engine | **Unity** `2022.3.46f1` (separate projects under `Part1/`, `Part2/`) |
| Input | Legacy `Input` (e.g. Space for dogs in Part2) |
| Content | Unity Learn Challenge 1 & 2 + Course Library |

## What's in the project

| Part | Key scripts |
|---|---|
| Part1 | `FollowPlayerX.cs`, `PlayerControllerX.cs`, `PropellerSpin.cs`, `Obstacle.cs` |
| Part2 | `PlayerControllerX.cs` (dog cooldown), `SpawnManagerX.cs`, `MoveForwardX.cs`, `DestroyOutOfBoundsX.cs`, `DetectCollisionsX.cs` |

### Code / system highlights

- **Part2 dog anti-spam:** `PlayerControllerX` tracks `lastSpawnTime` and only instantiates when `Time.time - lastSpawnTime > spawnCooldown`.
- Other scripts follow standard Challenge 1/2 patterns (move, spawn, destroy off-screen).

## Scenes

Open `Part1/` or `Part2/` as separate Unity projects and use each challenge’s scene under `Assets/Challenge N/Scenes/` / `Assets/Scenes/` as imported with the course package.

## Third-party assets

| Asset | Notes |
|---|---|
| **Unity Course Library / Challenge packs** | Primary art and starter scripts |
| Student edits | Cooldown and related assignment tweaks in challenge scripts |

## About this repository

**Labeled educational / course assignment (Game3121 Assignment 1).** Public under **PapiChulllo**. Portfolio value is coursework completion and the documented cooldown change, not a standalone commercial game.
