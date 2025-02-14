# NI-6510 IO Control

## Overview
This project is a VB.NET application for controlling and monitoring digital I/O using the **NI-6510** device. It allows users to toggle digital outputs and read digital inputs, displaying their states using LEDs in the UI.

## Features
- **Connect/Disconnect NI-6510** for I/O operations.
- **Read digital inputs** from specified ports and update LED indicators.
- **Toggle digital outputs** using buttons, with real-time feedback.
- **Auto-refresh input status** using a timer.

## Requirements
- **.NET Framework 4.5+**
- **National Instruments DAQmx Driver**
- **NI-6510 Device**

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/Izonetoyou/NI-6510_IO.git
   ```
2. Open the project in **Visual Studio**.
3. Build the solution and ensure that all dependencies are installed.
4. Run the application.

## Usage
1. **Select the Input & Output device** from the dropdown list.
2. **Click 'Connect'** to establish a connection with the NI-6510 device.
3. **Toggle Outputs:** Click buttons to turn ON/OFF digital outputs.
4. **Monitor Inputs:** The LED indicators update automatically based on the input signals.
5. **Click 'Disconnect'** to stop I/O operations.

## File Structure
```
📂 NI-6510_IO
├── 📂 Forms
│   ├── Form_NI-6510_IO.vb  # Main application form
├── 📂 Classes
│   ├── Class_NI_IO.vb  # Handles NI device communication
│   ├── Class_Var.vb  # Stores global variables
├── README.md  # Project documentation
```

## Known Issues
- Ensure the **NI DAQmx Driver** is installed before running the program.
- If the device is not detected, restart your PC and reconnect the NI-6510.

## License
This project is licensed under the **MIT License**.

## Contributors
- **Izonetoyou** (@Izonetoyou)

## Contact
For any issues or contributions, feel free to open an **Issue** or **Pull Request** on GitHub.

