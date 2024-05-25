# Async Methods App

This project is a Windows Forms application that asynchronously executes three different encryption methods: REDOC, SHA, and LUC. The application allows starting and stopping each process separately, as well as starting and stopping all processes simultaneously.

## Functionality

- **REDOC**: Encryption method that converts the input text to Base64.
- **SHA**: Hashing method that computes the SHA-256 hash of the input text.
- **LUC**: Encryption method that converts the input text to Base64 with byte reversal.

## User Interface

- **Input Field**: Text field for entering the text to be encrypted.
- **REDOC Output Field**: Text field for displaying the result of REDOC encryption.
- **SHA Output Field**: Text field for displaying the result of SHA hashing.
- **LUC Output Field**: Text field for displaying the result of LUC encryption.

### Control Buttons

- **Start REDOC**: Starts the REDOC encryption process.
- **Stop REDOC**: Stops the REDOC encryption process.
- **Start SHA**: Starts the SHA hashing process.
- **Stop SHA**: Stops the SHA hashing process.
- **Start LUC**: Starts the LUC encryption process.
- **Stop LUC**: Stops the LUC encryption process.
- **Start All**: Starts all three processes simultaneously.
- **Stop All**: Stops all three processes simultaneously.

## Requirements

- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or newer

