#  AR Face Filter Project (Unity + AR Foundation)

This project is an Augmented Reality face filter built using **Unity**, **AR Foundation**, and **Visual Scripting**. It tracks a user’s face in real-time and overlays a 3D sunglasses model using AR face tracking.

##  Features

- Real-time **AR face tracking** using the front camera
- Custom **3D sunglasses** appear on the user's face
- Built with Unity’s **Visual Scripting** (no C# required)
- Supports Android and iOS with ARCore/ARKit
- Optional XR Device Simulator setup for in-editor testing

---

##  Technologies Used

- **Unity 2022.x or 2023.x**
- **AR Foundation**
- **ARKit / ARCore**
- **XR Plugin Management**
- **Unity Visual Scripting**

---

##  Getting Started

### Prerequisites

- Unity Hub + Unity Editor (2022.3 LTS recommended)
- AR-supported Android or iOS device
- Unity packages:
  - `AR Foundation`
  - `ARKit XR Plugin` (for iOS)
  - `ARCore XR Plugin` (for Android)
  - `XR Plugin Management`
  - `Visual Scripting`

## 🛠 Setup Instructions

###  Open the Project in Unity

1. Open the Unity project via Unity Hub or Unity Editor.

2. Go to:  
   `Edit > Project Settings > XR Plug-in Management`

3. Under the relevant platform tab:
   - ✅ Enable **ARKit** for iOS  
   - ✅ Enable **ARCore** for Android

---

###  Hierarchy Setup

Ensure the following objects are present in your scene:

- `AR Session`
- `AR Session Origin`
- `AR Face Manager`

### ⚙️ Build Settings

Make sure your build settings are configured as follows:

- **Platform**: Android or iOS
- **Architecture**: `ARM64`
- **Scripting Backend**: `IL2CPP`
- **Camera Permission**: Enabled (required for AR to work)

---

##  Visual Scripting Overview

This project uses Unity Visual Scripting to:

-  Detect `On Button Click` events
-  Use `FindWithTag` to locate hidden child GameObjects (e.g., filters)
-  Enable their `MeshRenderer` at runtime to make them visible
-  Log actions with `Debug.Log` for runtime feedback
-  Use a `Sequence` node to perform multiple actions from one button press

---

## 📱 Demo Screenshots

Here are a few snapshots:

![Screenshot 2025-07-07 124729](https://github.com/user-attachments/assets/3508d3b9-2a01-4541-8cf9-a692edfeed92)

![FILTER_AR](https://github.com/user-attachments/assets/ead20f05-856e-49c0-97b2-11c19892701a)

